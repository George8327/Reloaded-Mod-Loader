﻿using HeroesModLoaderConfig.Styles.Controls.Animated;
using HeroesModLoaderConfig.Styles.Controls.Enhanced;

namespace HeroesModLoaderConfig.Windows.Children
{
    partial class Main_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeroesModLoaderConfig.Styles.Animation.AnimProperties animProperties1 = new HeroesModLoaderConfig.Styles.Animation.AnimProperties();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage1 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage2 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            HeroesModLoaderConfig.Styles.Animation.AnimProperties animProperties2 = new HeroesModLoaderConfig.Styles.Animation.AnimProperties();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage3 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage4 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimProperties animProperties3 = new HeroesModLoaderConfig.Styles.Animation.AnimProperties();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage5 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage6 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimProperties animProperties4 = new HeroesModLoaderConfig.Styles.Animation.AnimProperties();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage7 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            HeroesModLoaderConfig.Styles.Animation.AnimMessage animMessage8 = new HeroesModLoaderConfig.Styles.Animation.AnimMessage();
            this.item_GameList = new HeroesModLoaderConfig.Styles.Controls.Animated.AnimatedDataGridView();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_GameListBox = new HeroesModLoaderConfig.Styles.Controls.Animated.AnimatedButton();
            this.box_NoteBox = new HeroesModLoaderConfig.Styles.Controls.Animated.AnimatedButton();
            this.box_LocationBox = new HeroesModLoaderConfig.Styles.Controls.Animated.AnimatedButton();
            this.item_NoteBoxVerPath = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_NoteBoxEXEPath = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_NoteBoxVERTitle = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_NoteBoxEXETitle = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_NoteBoxGameName = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_NoteBoxSeparator = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_LocationBoxEXEPath = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_LocationBoxDirectoryPath = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_LocationBoxDirectoryTitle = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            this.item_LocationBoxEXETitle = new HeroesModLoaderConfig.Styles.Controls.EnhancedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.item_GameList)).BeginInit();
            this.SuspendLayout();
            // 
            // item_GameList
            // 
            this.item_GameList.AllowUserToAddRows = false;
            this.item_GameList.AllowUserToDeleteRows = false;
            this.item_GameList.AllowUserToResizeColumns = false;
            this.item_GameList.AllowUserToResizeRows = false;
            animMessage1.Control = this.item_GameList;
            animMessage1.PlayAnimation = true;
            animProperties1.BackColorMessage = animMessage1;
            animMessage2.Control = this.item_GameList;
            animMessage2.PlayAnimation = true;
            animProperties1.ForeColorMessage = animMessage2;
            animProperties1.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties1.MouseEnterDuration = 0F;
            animProperties1.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties1.MouseEnterFramerate = 0F;
            animProperties1.MouseEnterOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties1.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties1.MouseLeaveDuration = 0F;
            animProperties1.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties1.MouseLeaveFramerate = 0F;
            animProperties1.MouseLeaveOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.item_GameList.AnimProperties = animProperties1;
            this.item_GameList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.item_GameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_GameList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.item_GameList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.item_GameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_GameList.ColumnHeadersVisible = false;
            this.item_GameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modDirectory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_GameList.DefaultCellStyle = dataGridViewCellStyle3;
            this.item_GameList.EnableHeadersVisualStyles = false;
            this.item_GameList.GridColor = System.Drawing.Color.White;
            this.item_GameList.Location = new System.Drawing.Point(41, 40);
            this.item_GameList.MultiSelect = false;
            this.item_GameList.Name = "item_GameList";
            this.item_GameList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.item_GameList.RowHeadersVisible = false;
            this.item_GameList.RowTemplate.Height = 30;
            this.item_GameList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.item_GameList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_GameList.Size = new System.Drawing.Size(518, 251);
            this.item_GameList.TabIndex = 14;
            // 
            // modName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.modName.DefaultCellStyle = dataGridViewCellStyle1;
            this.modName.FillWeight = 152.2843F;
            this.modName.HeaderText = "Mod name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            this.modName.Width = 200;
            // 
            // modDirectory
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.modDirectory.DefaultCellStyle = dataGridViewCellStyle2;
            this.modDirectory.FillWeight = 47.71573F;
            this.modDirectory.HeaderText = "Mod Directory";
            this.modDirectory.Name = "modDirectory";
            this.modDirectory.ReadOnly = true;
            this.modDirectory.Width = 318;
            // 
            // box_GameListBox
            // 
            animMessage3.Control = this.box_GameListBox;
            animMessage3.PlayAnimation = true;
            animProperties2.BackColorMessage = animMessage3;
            animMessage4.Control = this.box_GameListBox;
            animMessage4.PlayAnimation = true;
            animProperties2.ForeColorMessage = animMessage4;
            animProperties2.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties2.MouseEnterDuration = 0F;
            animProperties2.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties2.MouseEnterFramerate = 0F;
            animProperties2.MouseEnterOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties2.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties2.MouseLeaveDuration = 0F;
            animProperties2.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties2.MouseLeaveFramerate = 0F;
            animProperties2.MouseLeaveOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_GameListBox.AnimProperties = animProperties2;
            this.box_GameListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.CaptureChildren = false;
            this.box_GameListBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_GameListBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_GameListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_GameListBox.IgnoreMouse = true;
            this.box_GameListBox.IgnoreMouseClicks = true;
            this.box_GameListBox.Location = new System.Drawing.Point(40, 39);
            this.box_GameListBox.Margin = new System.Windows.Forms.Padding(0);
            this.box_GameListBox.Name = "box_GameListBox";
            this.box_GameListBox.Size = new System.Drawing.Size(520, 253);
            this.box_GameListBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.box_GameListBox.TabIndex = 13;
            this.box_GameListBox.Text = null;
            this.box_GameListBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.box_GameListBox.UseVisualStyleBackColor = false;
            // 
            // box_NoteBox
            // 
            animMessage5.Control = this.box_NoteBox;
            animMessage5.PlayAnimation = true;
            animProperties3.BackColorMessage = animMessage5;
            animMessage6.Control = this.box_NoteBox;
            animMessage6.PlayAnimation = true;
            animProperties3.ForeColorMessage = animMessage6;
            animProperties3.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties3.MouseEnterDuration = 0F;
            animProperties3.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties3.MouseEnterFramerate = 0F;
            animProperties3.MouseEnterOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties3.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties3.MouseLeaveDuration = 0F;
            animProperties3.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties3.MouseLeaveFramerate = 0F;
            animProperties3.MouseLeaveOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_NoteBox.AnimProperties = animProperties3;
            this.box_NoteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.CaptureChildren = true;
            this.box_NoteBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_NoteBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_NoteBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_NoteBox.IgnoreMouse = false;
            this.box_NoteBox.IgnoreMouseClicks = true;
            this.box_NoteBox.Location = new System.Drawing.Point(589, 154);
            this.box_NoteBox.Name = "box_NoteBox";
            this.box_NoteBox.Size = new System.Drawing.Size(273, 138);
            this.box_NoteBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_NoteBox.TabIndex = 5;
            this.box_NoteBox.Text = null;
            this.box_NoteBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_NoteBox.UseVisualStyleBackColor = false;
            // 
            // box_LocationBox
            // 
            animMessage7.Control = this.box_LocationBox;
            animMessage7.PlayAnimation = true;
            animProperties4.BackColorMessage = animMessage7;
            animMessage8.Control = this.box_LocationBox;
            animMessage8.PlayAnimation = true;
            animProperties4.ForeColorMessage = animMessage8;
            animProperties4.MouseEnterBackColor = System.Drawing.Color.Empty;
            animProperties4.MouseEnterDuration = 0F;
            animProperties4.MouseEnterForeColor = System.Drawing.Color.Empty;
            animProperties4.MouseEnterFramerate = 0F;
            animProperties4.MouseEnterOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseEnterOverride.None;
            animProperties4.MouseLeaveBackColor = System.Drawing.Color.Empty;
            animProperties4.MouseLeaveDuration = 0F;
            animProperties4.MouseLeaveForeColor = System.Drawing.Color.Empty;
            animProperties4.MouseLeaveFramerate = 0F;
            animProperties4.MouseLeaveOverride = HeroesModLoaderConfig.Styles.Animation.AnimOverrides.MouseLeaveOverride.None;
            this.box_LocationBox.AnimProperties = animProperties4;
            this.box_LocationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.CaptureChildren = true;
            this.box_LocationBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.box_LocationBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_LocationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_LocationBox.IgnoreMouse = false;
            this.box_LocationBox.IgnoreMouseClicks = true;
            this.box_LocationBox.Location = new System.Drawing.Point(40, 322);
            this.box_LocationBox.Name = "box_LocationBox";
            this.box_LocationBox.Size = new System.Drawing.Size(822, 77);
            this.box_LocationBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.box_LocationBox.TabIndex = 0;
            this.box_LocationBox.Text = null;
            this.box_LocationBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.box_LocationBox.UseVisualStyleBackColor = false;
            // 
            // item_NoteBoxVerPath
            // 
            this.item_NoteBoxVerPath.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxVerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxVerPath.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxVerPath.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxVerPath.IgnoreMouse = false;
            this.item_NoteBoxVerPath.Location = new System.Drawing.Point(666, 257);
            this.item_NoteBoxVerPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxVerPath.Name = "item_NoteBoxVerPath";
            this.item_NoteBoxVerPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxVerPath.Size = new System.Drawing.Size(187, 24);
            this.item_NoteBoxVerPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxVerPath.TabIndex = 11;
            this.item_NoteBoxVerPath.Text = "Retail[US]";
            this.item_NoteBoxVerPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_NoteBoxVerPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxEXEPath
            // 
            this.item_NoteBoxEXEPath.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxEXEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxEXEPath.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxEXEPath.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxEXEPath.IgnoreMouse = false;
            this.item_NoteBoxEXEPath.Location = new System.Drawing.Point(666, 222);
            this.item_NoteBoxEXEPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxEXEPath.Name = "item_NoteBoxEXEPath";
            this.item_NoteBoxEXEPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxEXEPath.Size = new System.Drawing.Size(187, 24);
            this.item_NoteBoxEXEPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxEXEPath.TabIndex = 10;
            this.item_NoteBoxEXEPath.Text = "NoRestrict";
            this.item_NoteBoxEXEPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_NoteBoxEXEPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxVERTitle
            // 
            this.item_NoteBoxVERTitle.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxVERTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxVERTitle.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxVERTitle.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxVERTitle.IgnoreMouse = false;
            this.item_NoteBoxVERTitle.Location = new System.Drawing.Point(604, 257);
            this.item_NoteBoxVERTitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxVERTitle.Name = "item_NoteBoxVERTitle";
            this.item_NoteBoxVERTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxVERTitle.Size = new System.Drawing.Size(57, 24);
            this.item_NoteBoxVERTitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxVERTitle.TabIndex = 9;
            this.item_NoteBoxVERTitle.Text = "VER:";
            this.item_NoteBoxVERTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxEXETitle
            // 
            this.item_NoteBoxEXETitle.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxEXETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxEXETitle.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxEXETitle.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxEXETitle.IgnoreMouse = false;
            this.item_NoteBoxEXETitle.Location = new System.Drawing.Point(604, 222);
            this.item_NoteBoxEXETitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxEXETitle.Name = "item_NoteBoxEXETitle";
            this.item_NoteBoxEXETitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxEXETitle.Size = new System.Drawing.Size(57, 24);
            this.item_NoteBoxEXETitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxEXETitle.TabIndex = 8;
            this.item_NoteBoxEXETitle.Text = "EXE:";
            this.item_NoteBoxEXETitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxGameName
            // 
            this.item_NoteBoxGameName.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxGameName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxGameName.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxGameName.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxGameName.IgnoreMouse = false;
            this.item_NoteBoxGameName.Location = new System.Drawing.Point(592, 164);
            this.item_NoteBoxGameName.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxGameName.Name = "item_NoteBoxGameName";
            this.item_NoteBoxGameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxGameName.Size = new System.Drawing.Size(269, 24);
            this.item_NoteBoxGameName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxGameName.TabIndex = 7;
            this.item_NoteBoxGameName.Text = "Sonic Riders";
            this.item_NoteBoxGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.item_NoteBoxGameName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_NoteBoxSeparator
            // 
            this.item_NoteBoxSeparator.BackColor = System.Drawing.Color.Transparent;
            this.item_NoteBoxSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_NoteBoxSeparator.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_NoteBoxSeparator.ForeColor = System.Drawing.Color.White;
            this.item_NoteBoxSeparator.IgnoreMouse = false;
            this.item_NoteBoxSeparator.Location = new System.Drawing.Point(592, 185);
            this.item_NoteBoxSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.item_NoteBoxSeparator.Name = "item_NoteBoxSeparator";
            this.item_NoteBoxSeparator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_NoteBoxSeparator.Size = new System.Drawing.Size(269, 24);
            this.item_NoteBoxSeparator.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_NoteBoxSeparator.TabIndex = 6;
            this.item_NoteBoxSeparator.Text = "_____________________";
            this.item_NoteBoxSeparator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.item_NoteBoxSeparator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxEXEPath
            // 
            this.item_LocationBoxEXEPath.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxEXEPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxEXEPath.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxEXEPath.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxEXEPath.IgnoreMouse = false;
            this.item_LocationBoxEXEPath.Location = new System.Drawing.Point(172, 365);
            this.item_LocationBoxEXEPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxEXEPath.Name = "item_LocationBoxEXEPath";
            this.item_LocationBoxEXEPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_LocationBoxEXEPath.Size = new System.Drawing.Size(680, 24);
            this.item_LocationBoxEXEPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxEXEPath.TabIndex = 4;
            this.item_LocationBoxEXEPath.Text = "$DIRECTORY + SonicRiders.exe";
            this.item_LocationBoxEXEPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_LocationBoxEXEPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxDirectoryPath
            // 
            this.item_LocationBoxDirectoryPath.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxDirectoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxDirectoryPath.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxDirectoryPath.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxDirectoryPath.IgnoreMouse = false;
            this.item_LocationBoxDirectoryPath.Location = new System.Drawing.Point(172, 331);
            this.item_LocationBoxDirectoryPath.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxDirectoryPath.Name = "item_LocationBoxDirectoryPath";
            this.item_LocationBoxDirectoryPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.item_LocationBoxDirectoryPath.Size = new System.Drawing.Size(680, 24);
            this.item_LocationBoxDirectoryPath.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxDirectoryPath.TabIndex = 3;
            this.item_LocationBoxDirectoryPath.Text = "C:\\Program Files (x86)\\SEGA\\Sonic Riders";
            this.item_LocationBoxDirectoryPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.item_LocationBoxDirectoryPath.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxDirectoryTitle
            // 
            this.item_LocationBoxDirectoryTitle.AutoSize = true;
            this.item_LocationBoxDirectoryTitle.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxDirectoryTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxDirectoryTitle.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.item_LocationBoxDirectoryTitle.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxDirectoryTitle.IgnoreMouse = false;
            this.item_LocationBoxDirectoryTitle.Location = new System.Drawing.Point(52, 331);
            this.item_LocationBoxDirectoryTitle.Margin = new System.Windows.Forms.Padding(0);
            this.item_LocationBoxDirectoryTitle.Name = "item_LocationBoxDirectoryTitle";
            this.item_LocationBoxDirectoryTitle.Size = new System.Drawing.Size(120, 24);
            this.item_LocationBoxDirectoryTitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxDirectoryTitle.TabIndex = 1;
            this.item_LocationBoxDirectoryTitle.Text = "DIRECTORY:";
            this.item_LocationBoxDirectoryTitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // item_LocationBoxEXETitle
            // 
            this.item_LocationBoxEXETitle.AutoSize = true;
            this.item_LocationBoxEXETitle.BackColor = System.Drawing.Color.Transparent;
            this.item_LocationBoxEXETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_LocationBoxEXETitle.Font = new System.Drawing.Font("Roboto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.item_LocationBoxEXETitle.ForeColor = System.Drawing.Color.White;
            this.item_LocationBoxEXETitle.IgnoreMouse = false;
            this.item_LocationBoxEXETitle.Location = new System.Drawing.Point(52, 365);
            this.item_LocationBoxEXETitle.Name = "item_LocationBoxEXETitle";
            this.item_LocationBoxEXETitle.Size = new System.Drawing.Size(109, 24);
            this.item_LocationBoxEXETitle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.item_LocationBoxEXETitle.TabIndex = 2;
            this.item_LocationBoxEXETitle.Text = "EXE PATH:";
            this.item_LocationBoxEXETitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(900, 512);
            this.Controls.Add(this.item_GameList);
            this.Controls.Add(this.box_GameListBox);
            this.Controls.Add(this.item_NoteBoxVerPath);
            this.Controls.Add(this.item_NoteBoxEXEPath);
            this.Controls.Add(this.item_NoteBoxVERTitle);
            this.Controls.Add(this.item_NoteBoxEXETitle);
            this.Controls.Add(this.item_NoteBoxGameName);
            this.Controls.Add(this.item_NoteBoxSeparator);
            this.Controls.Add(this.box_NoteBox);
            this.Controls.Add(this.item_LocationBoxEXEPath);
            this.Controls.Add(this.item_LocationBoxDirectoryPath);
            this.Controls.Add(this.item_LocationBoxDirectoryTitle);
            this.Controls.Add(this.item_LocationBoxEXETitle);
            this.Controls.Add(this.box_LocationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Screen";
            this.Text = "Main_Screen";
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_GameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Styles.Controls.Animated.AnimatedButton box_LocationBox;
        private Styles.Controls.EnhancedLabel item_LocationBoxDirectoryTitle;
        private Styles.Controls.EnhancedLabel item_LocationBoxEXETitle;
        private Styles.Controls.EnhancedLabel item_LocationBoxDirectoryPath;
        private Styles.Controls.EnhancedLabel item_LocationBoxEXEPath;
        private Styles.Controls.Animated.AnimatedButton box_NoteBox;
        private Styles.Controls.EnhancedLabel item_NoteBoxSeparator;
        private Styles.Controls.EnhancedLabel item_NoteBoxGameName;
        private Styles.Controls.EnhancedLabel item_NoteBoxEXETitle;
        private Styles.Controls.EnhancedLabel item_NoteBoxVERTitle;
        private Styles.Controls.EnhancedLabel item_NoteBoxEXEPath;
        private Styles.Controls.EnhancedLabel item_NoteBoxVerPath;
        private Styles.Controls.Animated.AnimatedButton box_GameListBox;
        private AnimatedDataGridView item_GameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDirectory;
    }
}