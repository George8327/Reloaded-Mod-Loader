﻿/*
    [Reloaded] Mod Loader Common Library (libReloaded)
    The main library acting as common, shared code between the Reloaded Mod 
    Loader Launcher, Mods as well as plugins.
    Copyright (C) 2018  Sewer. Sz (Sewer56)

    [Reloaded] is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    [Reloaded] is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using Reloaded.Native.Functions;
using Reloaded.Native.WinAPI;

namespace Reloaded.Overlay.External.WinForms
{
    public partial class TransparentWinform : Form
    {
        /// <summary>
        /// Sets/Gets a handle for the game window whose client area the window will expand and move to match.
        /// </summary>
        public IntPtr GameWindowHandle { get; set; }

        /// <summary>
        /// Delegate which will be triggered upon resizing of the game window.
        /// </summary>
        public Action GameWindowResizeDelegate { get; set; }

        /// <summary>
        /// Delegate which will be triggered upon the movement of the game window or shape/size changes.
        /// </summary>
        private WindowEventHooks.WinEventDelegate WindowEventDelegate { get; set; }

        /// <summary>
        /// Defines the last size of the window, used to determine if a window has been resized.
        /// </summary>
        private Point lastWindowSize { get; set; }

        /// <summary>
        /// Constructor for the overlay form, is executed upon creation of the overlay.
        /// </summary>
        public TransparentWinform(IntPtr gameWindowHandle)
        {
            // Initialize Windows Form
            InitializeComponent();

            // Set handle to game window.
            GameWindowHandle = gameWindowHandle;

            // Set owner window
            WindowStyles.SetWindowLongPtr(Handle, -8, gameWindowHandle);

            // Set up the glass window to overlay over target window.
            SetupWindow();
        }

        /// <summary>
        /// Sets up the overlay window properties such as window style, topmost status, etc.
        /// </summary>
        private void SetupWindow()
        {
            // Set the appropriate window styles.
            SetWindowStyles();

            // Adjust window size and properties to overlap the game window.
            AdjustOverlayToGameWindow();

            // Setup hook for when the game window is moved, resized, changes shape...
            WindowEventDelegate += WinEventProc;
            WindowEventHooks.SetWinEventHook
            (
                WindowEventHooks.EVENT_OBJECT_LOCATIONCHANGE,       // Minimum event code to capture
                WindowEventHooks.EVENT_OBJECT_LOCATIONCHANGE,       // Maximum event code to capture
                IntPtr.Zero,                                        // DLL Handle (none required) 
                WindowEventDelegate,                                // Pointer to the hook function. (Delegate in our case)
                0,                                                  // Process ID (0 = all)
                0,                                                  // Thread ID (0 = all)
                WindowEventHooks.WINEVENT_OUTOFCONTEXT              // Flags: Allow cross-process event hooking
            );

            // Expand Aero Glass onto Client Area
            ExtendFrameToClientArea();
        }

        /// <summary>
        /// Sets the appropriate extended and non-extended window styles and attributes.
        /// The window is made topmost, transparent and layered and the layered window alpha
        /// is set to the maximum posible value.
        /// </summary>
        private void SetWindowStyles()
        {
            // Retrieve the original window style.
            long initialStyle = (long)WindowStyles.GetWindowLongPtr(Handle, Constants.GWL_EXSTYLE);

            // Set window as visible
            Visible = true;

            // Set the new window style
            WindowStyles.SetWindowLongPtr
            (
                Handle,                // Handle reference for the window.  
                Constants.GWL_EXSTYLE, // nIndex which writes to the currently set window style.

                // Set window as layered window, transparent (removes hit testing when layered) and keep it topmost.
                (IntPtr)(initialStyle | Constants.WS_EX_LAYERED | Constants.WS_EX_TRANSPARENT)
            ); 

            // Set the Alpha on the Layered Window to 255 (solid)
            WindowStyles.SetLayeredWindowAttributes(Handle, 0, 255, Constants.LWA_ALPHA);

            // Set window as topmost.
            TopMost = false;
        }

        /// <summary>
        /// Expands the Frame Border Effect to the whole form.
        /// Normally, without background rendering and a border, a window should technically
        /// be invisible. However, this unfortunately is not the case as compositing does not default
        /// apply to the client area of the window. Well, let's just make it apply and see the windows
        /// underneath, sounds good?
        /// </summary>
        private void ExtendFrameToClientArea()
        {
            // Instantiate a new instance of the margins class.
            Structures.WinapiRectangle formMargins = new Structures.WinapiRectangle
            {
                LeftBorder = 0,
                TopBorder = 0,
                RightBorder = Width,
                BottomBorder = Height
            };
            
            // Extend the frame into client area.
            WindowFunctions.DwmExtendFrameIntoClientArea(Handle, ref formMargins);
        }

        /// <summary>
        /// Sets the overlay window location to overlap the window of the game instance.
        /// Both moves the window to the game location and sets appropriate height and width for the window.
        /// </summary>
        public void AdjustOverlayToGameWindow()
        {
            // Get game client edges.
            Structures.WinapiRectangle gameClientSize = WindowProperties.GetClientRectangle(GameWindowHandle);

            // Set overlay edges to the edges of the client area.
            Left = gameClientSize.LeftBorder;
            Top = gameClientSize.TopBorder;

            // Set width and height.
            Width = gameClientSize.RightBorder - gameClientSize.LeftBorder;
            Height = gameClientSize.BottomBorder - gameClientSize.TopBorder;

            // Call resize delegate.
            if (lastWindowSize != WindowProperties.GetClientAreaSize2(GameWindowHandle))
            { GameWindowResizeDelegate?.Invoke(); }

            lastWindowSize = WindowProperties.GetClientAreaSize2(GameWindowHandle);
        }

        /// <summary>
        /// Defines the delegate method which is fired when the game window is moved or resized within this class.
        /// Simply resizes the overlay window back to match the target game's window.
        /// </summary>
        private void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            // Filter out non-HWND changes, e.g. items within a listbox.
            // Technically speaking shouldn't be necessary, though just in case.
            if (idObject != 0 || idChild != 0) return;

            // Set the size and location of the external overlay to match the game/target window.
            // Only if an object has changed location, shape, or size.
            if (eventType == 0x800B)
                AdjustOverlayToGameWindow();
        }

        /// <summary>
        /// Do not paint the background, override the background painting method with an empty method.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e) { }

        /// <summary>
        /// If the window is set to visible, put the game window in first.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparentWinform_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                // Set active window
                Native.WinAPI.WindowFunctions.SetActiveWindow(GameWindowHandle);
                this.Refresh();
                this.Invalidate();
            }
        }
    }
}