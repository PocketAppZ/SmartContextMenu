﻿namespace SmartContextMenu.Forms
{
    partial class ApplicationSettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpGeneral = new System.Windows.Forms.TabPage();
            this.grpbDisplay = new System.Windows.Forms.GroupBox();
            this.chkEnableHighDPI = new System.Windows.Forms.CheckBox();
            this.grpbLanguage = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.grpbMouseHotkeys = new System.Windows.Forms.GroupBox();
            this.tabpMenu = new System.Windows.Forms.TabPage();
            this.grpbHotkeys = new System.Windows.Forms.GroupBox();
            this.btnMenuItemDown = new System.Windows.Forms.Button();
            this.btnMenuItemUp = new System.Windows.Forms.Button();
            this.gvHotkeys = new System.Windows.Forms.DataGridView();
            this.clmnMenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHotkeys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnChangeHotkey = new SmartContextMenu.Controls.DataGridViewDisableButtonColumn();
            this.tabpMenuSize = new System.Windows.Forms.TabPage();
            this.grpbSizer = new System.Windows.Forms.GroupBox();
            this.cmbSizer = new System.Windows.Forms.ComboBox();
            this.grpbWindowSize = new System.Windows.Forms.GroupBox();
            this.btnWindowSizeDown = new System.Windows.Forms.Button();
            this.btnWindowSizeUp = new System.Windows.Forms.Button();
            this.btnAddWindowSize = new System.Windows.Forms.Button();
            this.gvWindowSize = new System.Windows.Forms.DataGridView();
            this.clmWindowSizeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeHotKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWindowSizeEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmWindowSizeDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabpMenuStart = new System.Windows.Forms.TabPage();
            this.grpbStartProgram = new System.Windows.Forms.GroupBox();
            this.btnStartProgramDown = new System.Windows.Forms.Button();
            this.btnStartProgramUp = new System.Windows.Forms.Button();
            this.btnAddStartProgram = new System.Windows.Forms.Button();
            this.gvStartProgram = new System.Windows.Forms.DataGridView();
            this.clmStartProgramTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartProgramPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartProgramArguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartProgramEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmStartProgramDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTipAddProcessName = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain.SuspendLayout();
            this.tabpGeneral.SuspendLayout();
            this.grpbDisplay.SuspendLayout();
            this.grpbLanguage.SuspendLayout();
            this.tabpMenu.SuspendLayout();
            this.grpbHotkeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHotkeys)).BeginInit();
            this.tabpMenuSize.SuspendLayout();
            this.grpbSizer.SuspendLayout();
            this.grpbWindowSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWindowSize)).BeginInit();
            this.tabpMenuStart.SuspendLayout();
            this.grpbStartProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStartProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpGeneral);
            this.tabMain.Controls.Add(this.tabpMenu);
            this.tabMain.Controls.Add(this.tabpMenuSize);
            this.tabMain.Controls.Add(this.tabpMenuStart);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(565, 416);
            this.tabMain.TabIndex = 0;
            // 
            // tabpGeneral
            // 
            this.tabpGeneral.Controls.Add(this.grpbDisplay);
            this.tabpGeneral.Controls.Add(this.grpbLanguage);
            this.tabpGeneral.Controls.Add(this.grpbMouseHotkeys);
            this.tabpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabpGeneral.Name = "tabpGeneral";
            this.tabpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpGeneral.Size = new System.Drawing.Size(557, 390);
            this.tabpGeneral.TabIndex = 0;
            this.tabpGeneral.UseVisualStyleBackColor = true;
            // 
            // grpbDisplay
            // 
            this.grpbDisplay.Controls.Add(this.chkEnableHighDPI);
            this.grpbDisplay.Location = new System.Drawing.Point(8, 87);
            this.grpbDisplay.Name = "grpbDisplay";
            this.grpbDisplay.Size = new System.Drawing.Size(541, 69);
            this.grpbDisplay.TabIndex = 2;
            this.grpbDisplay.TabStop = false;
            // 
            // chkEnableHighDPI
            // 
            this.chkEnableHighDPI.AutoSize = true;
            this.chkEnableHighDPI.Location = new System.Drawing.Point(6, 28);
            this.chkEnableHighDPI.Name = "chkEnableHighDPI";
            this.chkEnableHighDPI.Size = new System.Drawing.Size(15, 14);
            this.chkEnableHighDPI.TabIndex = 0;
            this.chkEnableHighDPI.UseVisualStyleBackColor = true;
            // 
            // grpbLanguage
            // 
            this.grpbLanguage.Controls.Add(this.cmbLanguage);
            this.grpbLanguage.Location = new System.Drawing.Point(8, 16);
            this.grpbLanguage.Name = "grpbLanguage";
            this.grpbLanguage.Size = new System.Drawing.Size(541, 68);
            this.grpbLanguage.TabIndex = 0;
            this.grpbLanguage.TabStop = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(6, 28);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(166, 21);
            this.cmbLanguage.TabIndex = 0;
            // 
            // grpbMouseHotkeys
            // 
            this.grpbMouseHotkeys.Location = new System.Drawing.Point(8, 160);
            this.grpbMouseHotkeys.Name = "grpbMouseHotkeys";
            this.grpbMouseHotkeys.Size = new System.Drawing.Size(541, 224);
            this.grpbMouseHotkeys.TabIndex = 3;
            this.grpbMouseHotkeys.TabStop = false;
            // 
            // tabpMenu
            // 
            this.tabpMenu.Controls.Add(this.grpbHotkeys);
            this.tabpMenu.Location = new System.Drawing.Point(4, 22);
            this.tabpMenu.Name = "tabpMenu";
            this.tabpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMenu.Size = new System.Drawing.Size(557, 390);
            this.tabpMenu.TabIndex = 2;
            this.tabpMenu.UseVisualStyleBackColor = true;
            // 
            // grpbHotkeys
            // 
            this.grpbHotkeys.Controls.Add(this.btnMenuItemDown);
            this.grpbHotkeys.Controls.Add(this.btnMenuItemUp);
            this.grpbHotkeys.Controls.Add(this.gvHotkeys);
            this.grpbHotkeys.Location = new System.Drawing.Point(8, 16);
            this.grpbHotkeys.Name = "grpbHotkeys";
            this.grpbHotkeys.Size = new System.Drawing.Size(541, 368);
            this.grpbHotkeys.TabIndex = 3;
            this.grpbHotkeys.TabStop = false;
            // 
            // btnMenuItemDown
            // 
            this.btnMenuItemDown.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowDown;
            this.btnMenuItemDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuItemDown.Location = new System.Drawing.Point(504, 339);
            this.btnMenuItemDown.Name = "btnMenuItemDown";
            this.btnMenuItemDown.Size = new System.Drawing.Size(31, 23);
            this.btnMenuItemDown.TabIndex = 4;
            this.btnMenuItemDown.UseVisualStyleBackColor = true;
            this.btnMenuItemDown.Click += new System.EventHandler(this.ButtonMenuItemDownClick);
            // 
            // btnMenuItemUp
            // 
            this.btnMenuItemUp.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowUp;
            this.btnMenuItemUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuItemUp.Location = new System.Drawing.Point(467, 339);
            this.btnMenuItemUp.Name = "btnMenuItemUp";
            this.btnMenuItemUp.Size = new System.Drawing.Size(31, 23);
            this.btnMenuItemUp.TabIndex = 3;
            this.btnMenuItemUp.UseVisualStyleBackColor = true;
            this.btnMenuItemUp.Click += new System.EventHandler(this.ButtonMenuItemUpClick);
            // 
            // gvHotkeys
            // 
            this.gvHotkeys.AllowUserToAddRows = false;
            this.gvHotkeys.AllowUserToDeleteRows = false;
            this.gvHotkeys.AllowUserToResizeColumns = false;
            this.gvHotkeys.AllowUserToResizeRows = false;
            this.gvHotkeys.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvHotkeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvHotkeys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvHotkeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHotkeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnMenuItemName,
            this.clmnHotkeys,
            this.clmnShow,
            this.clmnChangeHotkey});
            this.gvHotkeys.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvHotkeys.GridColor = System.Drawing.SystemColors.Control;
            this.gvHotkeys.Location = new System.Drawing.Point(6, 19);
            this.gvHotkeys.MultiSelect = false;
            this.gvHotkeys.Name = "gvHotkeys";
            this.gvHotkeys.RowHeadersVisible = false;
            this.gvHotkeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHotkeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHotkeys.Size = new System.Drawing.Size(529, 314);
            this.gvHotkeys.TabIndex = 0;
            this.gvHotkeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewHotkeysCellContentClick);
            this.gvHotkeys.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewHotkeysCellDoubleClick);
            // 
            // clmnMenuItemName
            // 
            this.clmnMenuItemName.HeaderText = "clmnMenuItemName";
            this.clmnMenuItemName.MinimumWidth = 200;
            this.clmnMenuItemName.Name = "clmnMenuItemName";
            this.clmnMenuItemName.ReadOnly = true;
            this.clmnMenuItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnMenuItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnMenuItemName.Width = 200;
            // 
            // clmnHotkeys
            // 
            this.clmnHotkeys.HeaderText = "clmnHotkeys";
            this.clmnHotkeys.MinimumWidth = 200;
            this.clmnHotkeys.Name = "clmnHotkeys";
            this.clmnHotkeys.Width = 200;
            // 
            // clmnShow
            // 
            this.clmnShow.HeaderText = "";
            this.clmnShow.Name = "clmnShow";
            this.clmnShow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnShow.Width = 30;
            // 
            // clmnChangeHotkey
            // 
            this.clmnChangeHotkey.HeaderText = "";
            this.clmnChangeHotkey.Name = "clmnChangeHotkey";
            this.clmnChangeHotkey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnChangeHotkey.Text = "...";
            this.clmnChangeHotkey.UseColumnTextForButtonValue = true;
            this.clmnChangeHotkey.Width = 30;
            // 
            // tabpMenuSize
            // 
            this.tabpMenuSize.Controls.Add(this.grpbSizer);
            this.tabpMenuSize.Controls.Add(this.grpbWindowSize);
            this.tabpMenuSize.Location = new System.Drawing.Point(4, 22);
            this.tabpMenuSize.Name = "tabpMenuSize";
            this.tabpMenuSize.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMenuSize.Size = new System.Drawing.Size(557, 390);
            this.tabpMenuSize.TabIndex = 3;
            this.tabpMenuSize.UseVisualStyleBackColor = true;
            // 
            // grpbSizer
            // 
            this.grpbSizer.Controls.Add(this.cmbSizer);
            this.grpbSizer.Location = new System.Drawing.Point(8, 16);
            this.grpbSizer.Name = "grpbSizer";
            this.grpbSizer.Size = new System.Drawing.Size(541, 68);
            this.grpbSizer.TabIndex = 0;
            this.grpbSizer.TabStop = false;
            // 
            // cmbSizer
            // 
            this.cmbSizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizer.FormattingEnabled = true;
            this.cmbSizer.Location = new System.Drawing.Point(6, 28);
            this.cmbSizer.Name = "cmbSizer";
            this.cmbSizer.Size = new System.Drawing.Size(166, 21);
            this.cmbSizer.TabIndex = 0;
            // 
            // grpbWindowSize
            // 
            this.grpbWindowSize.Controls.Add(this.btnWindowSizeDown);
            this.grpbWindowSize.Controls.Add(this.btnWindowSizeUp);
            this.grpbWindowSize.Controls.Add(this.btnAddWindowSize);
            this.grpbWindowSize.Controls.Add(this.gvWindowSize);
            this.grpbWindowSize.Location = new System.Drawing.Point(8, 87);
            this.grpbWindowSize.Name = "grpbWindowSize";
            this.grpbWindowSize.Size = new System.Drawing.Size(541, 297);
            this.grpbWindowSize.TabIndex = 1;
            this.grpbWindowSize.TabStop = false;
            // 
            // btnWindowSizeDown
            // 
            this.btnWindowSizeDown.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowDown;
            this.btnWindowSizeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWindowSizeDown.Location = new System.Drawing.Point(450, 268);
            this.btnWindowSizeDown.Name = "btnWindowSizeDown";
            this.btnWindowSizeDown.Size = new System.Drawing.Size(31, 23);
            this.btnWindowSizeDown.TabIndex = 2;
            this.btnWindowSizeDown.UseVisualStyleBackColor = true;
            this.btnWindowSizeDown.Click += new System.EventHandler(this.ButtonArrowDownClick);
            // 
            // btnWindowSizeUp
            // 
            this.btnWindowSizeUp.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowUp;
            this.btnWindowSizeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWindowSizeUp.Location = new System.Drawing.Point(413, 268);
            this.btnWindowSizeUp.Name = "btnWindowSizeUp";
            this.btnWindowSizeUp.Size = new System.Drawing.Size(31, 23);
            this.btnWindowSizeUp.TabIndex = 1;
            this.btnWindowSizeUp.UseVisualStyleBackColor = true;
            this.btnWindowSizeUp.Click += new System.EventHandler(this.ButtonArrowUpClick);
            // 
            // btnAddWindowSize
            // 
            this.btnAddWindowSize.Location = new System.Drawing.Point(504, 268);
            this.btnAddWindowSize.Name = "btnAddWindowSize";
            this.btnAddWindowSize.Size = new System.Drawing.Size(31, 23);
            this.btnAddWindowSize.TabIndex = 3;
            this.btnAddWindowSize.Text = "+";
            this.btnAddWindowSize.UseVisualStyleBackColor = true;
            this.btnAddWindowSize.Click += new System.EventHandler(this.ButtonAddWindowSizeClick);
            // 
            // gvWindowSize
            // 
            this.gvWindowSize.AllowUserToAddRows = false;
            this.gvWindowSize.AllowUserToDeleteRows = false;
            this.gvWindowSize.AllowUserToResizeColumns = false;
            this.gvWindowSize.AllowUserToResizeRows = false;
            this.gvWindowSize.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvWindowSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvWindowSize.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvWindowSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWindowSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmWindowSizeTitle,
            this.clmWindowSizeLeft,
            this.clmWindowSizeTop,
            this.clmWindowSizeWidth,
            this.clmWindowSizeHeight,
            this.clmWindowSizeHotKey,
            this.clmWindowSizeEdit,
            this.clmWindowSizeDelete});
            this.gvWindowSize.GridColor = System.Drawing.SystemColors.Control;
            this.gvWindowSize.Location = new System.Drawing.Point(6, 19);
            this.gvWindowSize.MultiSelect = false;
            this.gvWindowSize.Name = "gvWindowSize";
            this.gvWindowSize.RowHeadersVisible = false;
            this.gvWindowSize.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvWindowSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvWindowSize.Size = new System.Drawing.Size(529, 243);
            this.gvWindowSize.TabIndex = 0;
            this.gvWindowSize.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewWindowSizeCellContentClick);
            this.gvWindowSize.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewWindowSizeCellDoubleClick);
            // 
            // clmWindowSizeTitle
            // 
            this.clmWindowSizeTitle.HeaderText = "clmWindowSizeTitle";
            this.clmWindowSizeTitle.Name = "clmWindowSizeTitle";
            this.clmWindowSizeTitle.ReadOnly = true;
            this.clmWindowSizeTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmWindowSizeLeft
            // 
            this.clmWindowSizeLeft.HeaderText = "clmWindowSizeLeft";
            this.clmWindowSizeLeft.Name = "clmWindowSizeLeft";
            this.clmWindowSizeLeft.ReadOnly = true;
            this.clmWindowSizeLeft.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeLeft.Width = 50;
            // 
            // clmWindowSizeTop
            // 
            this.clmWindowSizeTop.HeaderText = "clmWindowSizeTop";
            this.clmWindowSizeTop.Name = "clmWindowSizeTop";
            this.clmWindowSizeTop.ReadOnly = true;
            this.clmWindowSizeTop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeTop.Width = 50;
            // 
            // clmWindowSizeWidth
            // 
            this.clmWindowSizeWidth.HeaderText = "clmWindowSizeWidth";
            this.clmWindowSizeWidth.Name = "clmWindowSizeWidth";
            this.clmWindowSizeWidth.ReadOnly = true;
            this.clmWindowSizeWidth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmWindowSizeWidth.Width = 50;
            // 
            // clmWindowSizeHeight
            // 
            this.clmWindowSizeHeight.HeaderText = "clmWindowSizeHeight";
            this.clmWindowSizeHeight.Name = "clmWindowSizeHeight";
            this.clmWindowSizeHeight.ReadOnly = true;
            this.clmWindowSizeHeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmWindowSizeHeight.Width = 50;
            // 
            // clmWindowSizeHotKey
            // 
            this.clmWindowSizeHotKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmWindowSizeHotKey.HeaderText = "";
            this.clmWindowSizeHotKey.Name = "clmWindowSizeHotKey";
            this.clmWindowSizeHotKey.ReadOnly = true;
            // 
            // clmWindowSizeEdit
            // 
            this.clmWindowSizeEdit.HeaderText = "";
            this.clmWindowSizeEdit.Name = "clmWindowSizeEdit";
            this.clmWindowSizeEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeEdit.Text = "...";
            this.clmWindowSizeEdit.UseColumnTextForButtonValue = true;
            this.clmWindowSizeEdit.Width = 30;
            // 
            // clmWindowSizeDelete
            // 
            this.clmWindowSizeDelete.HeaderText = "";
            this.clmWindowSizeDelete.Name = "clmWindowSizeDelete";
            this.clmWindowSizeDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmWindowSizeDelete.Text = "-";
            this.clmWindowSizeDelete.UseColumnTextForButtonValue = true;
            this.clmWindowSizeDelete.Width = 30;
            // 
            // tabpMenuStart
            // 
            this.tabpMenuStart.Controls.Add(this.grpbStartProgram);
            this.tabpMenuStart.Location = new System.Drawing.Point(4, 22);
            this.tabpMenuStart.Name = "tabpMenuStart";
            this.tabpMenuStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMenuStart.Size = new System.Drawing.Size(557, 390);
            this.tabpMenuStart.TabIndex = 1;
            this.tabpMenuStart.UseVisualStyleBackColor = true;
            // 
            // grpbStartProgram
            // 
            this.grpbStartProgram.Controls.Add(this.btnStartProgramDown);
            this.grpbStartProgram.Controls.Add(this.btnStartProgramUp);
            this.grpbStartProgram.Controls.Add(this.btnAddStartProgram);
            this.grpbStartProgram.Controls.Add(this.gvStartProgram);
            this.grpbStartProgram.Location = new System.Drawing.Point(8, 16);
            this.grpbStartProgram.Name = "grpbStartProgram";
            this.grpbStartProgram.Size = new System.Drawing.Size(541, 368);
            this.grpbStartProgram.TabIndex = 0;
            this.grpbStartProgram.TabStop = false;
            // 
            // btnStartProgramDown
            // 
            this.btnStartProgramDown.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowDown;
            this.btnStartProgramDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartProgramDown.Location = new System.Drawing.Point(450, 339);
            this.btnStartProgramDown.Name = "btnStartProgramDown";
            this.btnStartProgramDown.Size = new System.Drawing.Size(31, 23);
            this.btnStartProgramDown.TabIndex = 2;
            this.btnStartProgramDown.UseVisualStyleBackColor = true;
            this.btnStartProgramDown.Click += new System.EventHandler(this.ButtonArrowDownClick);
            // 
            // btnStartProgramUp
            // 
            this.btnStartProgramUp.BackgroundImage = global::SmartContextMenu.Properties.Resources.ArrowUp;
            this.btnStartProgramUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartProgramUp.Location = new System.Drawing.Point(413, 339);
            this.btnStartProgramUp.Name = "btnStartProgramUp";
            this.btnStartProgramUp.Size = new System.Drawing.Size(31, 23);
            this.btnStartProgramUp.TabIndex = 1;
            this.btnStartProgramUp.UseVisualStyleBackColor = true;
            this.btnStartProgramUp.Click += new System.EventHandler(this.ButtonArrowUpClick);
            // 
            // btnAddStartProgram
            // 
            this.btnAddStartProgram.Location = new System.Drawing.Point(504, 339);
            this.btnAddStartProgram.Name = "btnAddStartProgram";
            this.btnAddStartProgram.Size = new System.Drawing.Size(31, 23);
            this.btnAddStartProgram.TabIndex = 3;
            this.btnAddStartProgram.Text = "+";
            this.btnAddStartProgram.UseVisualStyleBackColor = true;
            this.btnAddStartProgram.Click += new System.EventHandler(this.ButtonAddStartProgramClick);
            // 
            // gvStartProgram
            // 
            this.gvStartProgram.AllowUserToAddRows = false;
            this.gvStartProgram.AllowUserToDeleteRows = false;
            this.gvStartProgram.AllowUserToResizeColumns = false;
            this.gvStartProgram.AllowUserToResizeRows = false;
            this.gvStartProgram.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvStartProgram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvStartProgram.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvStartProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStartProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStartProgramTitle,
            this.clmStartProgramPath,
            this.clmStartProgramArguments,
            this.clmStartProgramEdit,
            this.clmStartProgramDelete});
            this.gvStartProgram.GridColor = System.Drawing.SystemColors.Control;
            this.gvStartProgram.Location = new System.Drawing.Point(6, 19);
            this.gvStartProgram.MultiSelect = false;
            this.gvStartProgram.Name = "gvStartProgram";
            this.gvStartProgram.RowHeadersVisible = false;
            this.gvStartProgram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvStartProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStartProgram.Size = new System.Drawing.Size(529, 314);
            this.gvStartProgram.TabIndex = 0;
            this.gvStartProgram.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewStartProgramCellContentClick);
            this.gvStartProgram.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewStartProgramCellDoubleClick);
            // 
            // clmStartProgramTitle
            // 
            this.clmStartProgramTitle.Name = "clmStartProgramTitle";
            this.clmStartProgramTitle.ReadOnly = true;
            this.clmStartProgramTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStartProgramTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmStartProgramPath
            // 
            this.clmStartProgramPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmStartProgramPath.Name = "clmStartProgramPath";
            this.clmStartProgramPath.ReadOnly = true;
            this.clmStartProgramPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStartProgramPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmStartProgramArguments
            // 
            this.clmStartProgramArguments.Name = "clmStartProgramArguments";
            this.clmStartProgramArguments.ReadOnly = true;
            this.clmStartProgramArguments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStartProgramArguments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmStartProgramArguments.Width = 72;
            // 
            // clmStartProgramEdit
            // 
            this.clmStartProgramEdit.HeaderText = "";
            this.clmStartProgramEdit.Name = "clmStartProgramEdit";
            this.clmStartProgramEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStartProgramEdit.Text = "...";
            this.clmStartProgramEdit.UseColumnTextForButtonValue = true;
            this.clmStartProgramEdit.Width = 30;
            // 
            // clmStartProgramDelete
            // 
            this.clmStartProgramDelete.HeaderText = "";
            this.clmStartProgramDelete.Name = "clmStartProgramDelete";
            this.clmStartProgramDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStartProgramDelete.Text = "-";
            this.clmStartProgramDelete.UseColumnTextForButtonValue = true;
            this.clmStartProgramDelete.Width = 30;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(384, 432);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 35);
            this.btnApply.TabIndex = 1;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.ButtonApplyClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(473, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownClick);
            this.tabMain.ResumeLayout(false);
            this.tabpGeneral.ResumeLayout(false);
            this.grpbDisplay.ResumeLayout(false);
            this.grpbDisplay.PerformLayout();
            this.grpbLanguage.ResumeLayout(false);
            this.tabpMenu.ResumeLayout(false);
            this.grpbHotkeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHotkeys)).EndInit();
            this.tabpMenuSize.ResumeLayout(false);
            this.grpbSizer.ResumeLayout(false);
            this.grpbWindowSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvWindowSize)).EndInit();
            this.tabpMenuStart.ResumeLayout(false);
            this.grpbStartProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStartProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabpGeneral;
        private System.Windows.Forms.TabPage tabpMenuStart;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTipAddProcessName;
        private System.Windows.Forms.GroupBox grpbStartProgram;
        private System.Windows.Forms.Button btnAddStartProgram;
        private System.Windows.Forms.DataGridView gvStartProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartProgramTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartProgramPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartProgramArguments;
        private System.Windows.Forms.DataGridViewButtonColumn clmStartProgramEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmStartProgramDelete;
        private System.Windows.Forms.Button btnStartProgramDown;
        private System.Windows.Forms.Button btnStartProgramUp;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.GroupBox grpbMouseHotkeys;
        private System.Windows.Forms.TabPage tabpMenu;
        private System.Windows.Forms.GroupBox grpbHotkeys;
        private System.Windows.Forms.DataGridView gvHotkeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHotkeys;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnShow;
        private SmartContextMenu.Controls.DataGridViewDisableButtonColumn clmnChangeHotkey;
        private System.Windows.Forms.TabPage tabpMenuSize;
        private System.Windows.Forms.GroupBox grpbWindowSize;
        private System.Windows.Forms.Button btnWindowSizeDown;
        private System.Windows.Forms.Button btnWindowSizeUp;
        private System.Windows.Forms.Button btnAddWindowSize;
        private System.Windows.Forms.DataGridView gvWindowSize;
        private System.Windows.Forms.GroupBox grpbLanguage;
        private System.Windows.Forms.GroupBox grpbSizer;
        private System.Windows.Forms.ComboBox cmbSizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWindowSizeHotKey;
        private System.Windows.Forms.DataGridViewButtonColumn clmWindowSizeEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmWindowSizeDelete;
        private System.Windows.Forms.Button btnMenuItemDown;
        private System.Windows.Forms.Button btnMenuItemUp;
        private System.Windows.Forms.GroupBox grpbDisplay;
        private System.Windows.Forms.CheckBox chkEnableHighDPI;
    }
}