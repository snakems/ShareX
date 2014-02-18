﻿namespace ShareX
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
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.cbRememberMainFormSize = new System.Windows.Forms.CheckBox();
            this.cbTaskbarProgressEnabled = new System.Windows.Forms.CheckBox();
            this.cbTrayIconProgressEnabled = new System.Windows.Forms.CheckBox();
            this.cbShellContextMenu = new System.Windows.Forms.CheckBox();
            this.cbCheckUpdates = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.cbShowTray = new System.Windows.Forms.CheckBox();
            this.cbSendToMenu = new System.Windows.Forms.CheckBox();
            this.tpPaths = new System.Windows.Forms.TabPage();
            this.lblNotePersonalFolderPath = new System.Windows.Forms.Label();
            this.btnOpenScreenshotsFolder = new System.Windows.Forms.Button();
            this.lblPreviewPersonalFolderPath = new System.Windows.Forms.Label();
            this.btnBrowsePersonalFolderPath = new System.Windows.Forms.Button();
            this.lblPersonalFolderPath = new System.Windows.Forms.Label();
            this.txtPersonalFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseCustomScreenshotsPath = new System.Windows.Forms.Button();
            this.btnOpenPersonalFolderPath = new System.Windows.Forms.Button();
            this.txtCustomScreenshotsPath = new System.Windows.Forms.TextBox();
            this.cbUseCustomScreenshotsPath = new System.Windows.Forms.CheckBox();
            this.lblSaveImageSubFolderPattern = new System.Windows.Forms.Label();
            this.lblSaveImageSubFolderPatternPreview = new System.Windows.Forms.Label();
            this.txtSaveImageSubFolderPattern = new System.Windows.Forms.TextBox();
            this.tpProxy = new System.Windows.Forms.TabPage();
            this.lblProxyNote = new System.Windows.Forms.Label();
            this.cbProxyMethod = new System.Windows.Forms.ComboBox();
            this.lblProxyMethod = new System.Windows.Forms.Label();
            this.cbProxyType = new System.Windows.Forms.ComboBox();
            this.lblProxyType = new System.Windows.Forms.Label();
            this.lblProxyHost = new System.Windows.Forms.Label();
            this.txtProxyHost = new System.Windows.Forms.TextBox();
            this.nudProxyPort = new System.Windows.Forms.NumericUpDown();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.lblProxyPassword = new System.Windows.Forms.Label();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.lblProxyUsername = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.tpUpload = new System.Windows.Forms.TabPage();
            this.gbBandwidth = new System.Windows.Forms.GroupBox();
            this.lblUploadLimit = new System.Windows.Forms.Label();
            this.nudUploadLimit = new System.Windows.Forms.NumericUpDown();
            this.lblUploadLimitHint = new System.Windows.Forms.Label();
            this.lblBufferSize = new System.Windows.Forms.Label();
            this.cbBufferSize = new System.Windows.Forms.ComboBox();
            this.gbClipboardFormats = new System.Windows.Forms.GroupBox();
            this.btnClipboardFormatEdit = new System.Windows.Forms.Button();
            this.btnClipboardFormatRemove = new System.Windows.Forms.Button();
            this.btnClipboardFormatAdd = new System.Windows.Forms.Button();
            this.lvClipboardFormats = new HelpersLib.MyListView();
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbIfUploadFailRetryOnce = new System.Windows.Forms.CheckBox();
            this.tpPrint = new System.Windows.Forms.TabPage();
            this.cbDontShowPrintSettingDialog = new System.Windows.Forms.CheckBox();
            this.btnShowImagePrintSettings = new System.Windows.Forms.Button();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.cbSilentRun = new System.Windows.Forms.CheckBox();
            this.tcSettings.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpPaths.SuspendLayout();
            this.tpProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyPort)).BeginInit();
            this.tpUpload.SuspendLayout();
            this.gbBandwidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).BeginInit();
            this.gbClipboardFormats.SuspendLayout();
            this.tpPrint.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpGeneral);
            this.tcSettings.Controls.Add(this.tpPaths);
            this.tcSettings.Controls.Add(this.tpProxy);
            this.tcSettings.Controls.Add(this.tpUpload);
            this.tcSettings.Controls.Add(this.tpPrint);
            this.tcSettings.Controls.Add(this.tpAdvanced);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(3, 3);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(530, 334);
            this.tcSettings.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.cbSilentRun);
            this.tpGeneral.Controls.Add(this.cbRememberMainFormSize);
            this.tpGeneral.Controls.Add(this.cbTaskbarProgressEnabled);
            this.tpGeneral.Controls.Add(this.cbTrayIconProgressEnabled);
            this.tpGeneral.Controls.Add(this.cbShellContextMenu);
            this.tpGeneral.Controls.Add(this.cbCheckUpdates);
            this.tpGeneral.Controls.Add(this.cbStartWithWindows);
            this.tpGeneral.Controls.Add(this.cbShowTray);
            this.tpGeneral.Controls.Add(this.cbSendToMenu);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(522, 308);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // cbRememberMainFormSize
            // 
            this.cbRememberMainFormSize.AutoSize = true;
            this.cbRememberMainFormSize.Location = new System.Drawing.Point(16, 208);
            this.cbRememberMainFormSize.Name = "cbRememberMainFormSize";
            this.cbRememberMainFormSize.Size = new System.Drawing.Size(162, 17);
            this.cbRememberMainFormSize.TabIndex = 7;
            this.cbRememberMainFormSize.Text = "Remember main window size";
            this.cbRememberMainFormSize.UseVisualStyleBackColor = true;
            this.cbRememberMainFormSize.CheckedChanged += new System.EventHandler(this.cbRememberMainFormSize_CheckedChanged);
            // 
            // cbTaskbarProgressEnabled
            // 
            this.cbTaskbarProgressEnabled.AutoSize = true;
            this.cbTaskbarProgressEnabled.Location = new System.Drawing.Point(16, 184);
            this.cbTaskbarProgressEnabled.Name = "cbTaskbarProgressEnabled";
            this.cbTaskbarProgressEnabled.Size = new System.Drawing.Size(178, 17);
            this.cbTaskbarProgressEnabled.TabIndex = 6;
            this.cbTaskbarProgressEnabled.Text = "Show progress in taskbar button";
            this.cbTaskbarProgressEnabled.UseVisualStyleBackColor = true;
            this.cbTaskbarProgressEnabled.CheckedChanged += new System.EventHandler(this.cbTaskbarProgressEnabled_CheckedChanged);
            // 
            // cbTrayIconProgressEnabled
            // 
            this.cbTrayIconProgressEnabled.AutoSize = true;
            this.cbTrayIconProgressEnabled.Location = new System.Drawing.Point(16, 160);
            this.cbTrayIconProgressEnabled.Name = "cbTrayIconProgressEnabled";
            this.cbTrayIconProgressEnabled.Size = new System.Drawing.Size(150, 17);
            this.cbTrayIconProgressEnabled.TabIndex = 5;
            this.cbTrayIconProgressEnabled.Text = "Show progress in tray icon";
            this.cbTrayIconProgressEnabled.UseVisualStyleBackColor = true;
            this.cbTrayIconProgressEnabled.CheckedChanged += new System.EventHandler(this.cbTrayIconProgressEnabled_CheckedChanged);
            // 
            // cbShellContextMenu
            // 
            this.cbShellContextMenu.AutoSize = true;
            this.cbShellContextMenu.Location = new System.Drawing.Point(16, 112);
            this.cbShellContextMenu.Name = "cbShellContextMenu";
            this.cbShellContextMenu.Size = new System.Drawing.Size(301, 17);
            this.cbShellContextMenu.TabIndex = 3;
            this.cbShellContextMenu.Text = "Show \"Upload using ShareX\" button in shell context menu";
            this.cbShellContextMenu.UseVisualStyleBackColor = true;
            this.cbShellContextMenu.CheckedChanged += new System.EventHandler(this.cbShellContextMenu_CheckedChanged);
            // 
            // cbCheckUpdates
            // 
            this.cbCheckUpdates.AutoSize = true;
            this.cbCheckUpdates.Location = new System.Drawing.Point(16, 136);
            this.cbCheckUpdates.Name = "cbCheckUpdates";
            this.cbCheckUpdates.Size = new System.Drawing.Size(209, 17);
            this.cbCheckUpdates.TabIndex = 4;
            this.cbCheckUpdates.Text = "Automatically check updates at startup";
            this.cbCheckUpdates.UseVisualStyleBackColor = true;
            this.cbCheckUpdates.CheckedChanged += new System.EventHandler(this.cbCheckUpdates_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(16, 64);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(188, 17);
            this.cbStartWithWindows.TabIndex = 1;
            this.cbStartWithWindows.Text = "Run ShareX when Windows starts";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // cbShowTray
            // 
            this.cbShowTray.AutoSize = true;
            this.cbShowTray.Location = new System.Drawing.Point(16, 16);
            this.cbShowTray.Name = "cbShowTray";
            this.cbShowTray.Size = new System.Drawing.Size(96, 17);
            this.cbShowTray.TabIndex = 0;
            this.cbShowTray.Text = "Show tray icon";
            this.cbShowTray.UseVisualStyleBackColor = true;
            this.cbShowTray.CheckedChanged += new System.EventHandler(this.cbShowTray_CheckedChanged);
            // 
            // cbSendToMenu
            // 
            this.cbSendToMenu.AutoSize = true;
            this.cbSendToMenu.Location = new System.Drawing.Point(16, 88);
            this.cbSendToMenu.Name = "cbSendToMenu";
            this.cbSendToMenu.Size = new System.Drawing.Size(181, 17);
            this.cbSendToMenu.TabIndex = 2;
            this.cbSendToMenu.Text = "Show ShareX in \"Send to\" menu";
            this.cbSendToMenu.UseVisualStyleBackColor = true;
            this.cbSendToMenu.CheckedChanged += new System.EventHandler(this.cbSendToMenu_CheckedChanged);
            // 
            // tpPaths
            // 
            this.tpPaths.Controls.Add(this.lblNotePersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnOpenScreenshotsFolder);
            this.tpPaths.Controls.Add(this.lblPreviewPersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnBrowsePersonalFolderPath);
            this.tpPaths.Controls.Add(this.lblPersonalFolderPath);
            this.tpPaths.Controls.Add(this.txtPersonalFolderPath);
            this.tpPaths.Controls.Add(this.btnBrowseCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.btnOpenPersonalFolderPath);
            this.tpPaths.Controls.Add(this.txtCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.cbUseCustomScreenshotsPath);
            this.tpPaths.Controls.Add(this.lblSaveImageSubFolderPattern);
            this.tpPaths.Controls.Add(this.lblSaveImageSubFolderPatternPreview);
            this.tpPaths.Controls.Add(this.txtSaveImageSubFolderPattern);
            this.tpPaths.Location = new System.Drawing.Point(4, 22);
            this.tpPaths.Name = "tpPaths";
            this.tpPaths.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaths.Size = new System.Drawing.Size(522, 308);
            this.tpPaths.TabIndex = 1;
            this.tpPaths.Text = "Paths";
            this.tpPaths.UseVisualStyleBackColor = true;
            // 
            // lblNotePersonalFolderPath
            // 
            this.lblNotePersonalFolderPath.AutoSize = true;
            this.lblNotePersonalFolderPath.Location = new System.Drawing.Point(16, 96);
            this.lblNotePersonalFolderPath.Name = "lblNotePersonalFolderPath";
            this.lblNotePersonalFolderPath.Size = new System.Drawing.Size(354, 13);
            this.lblNotePersonalFolderPath.TabIndex = 19;
            this.lblNotePersonalFolderPath.Text = "Note: You must reopen ShareX for personal folder changes to take effect.";
            // 
            // btnOpenScreenshotsFolder
            // 
            this.btnOpenScreenshotsFolder.Location = new System.Drawing.Point(16, 208);
            this.btnOpenScreenshotsFolder.Name = "btnOpenScreenshotsFolder";
            this.btnOpenScreenshotsFolder.Size = new System.Drawing.Size(80, 23);
            this.btnOpenScreenshotsFolder.TabIndex = 18;
            this.btnOpenScreenshotsFolder.Text = "Open...";
            this.btnOpenScreenshotsFolder.UseVisualStyleBackColor = true;
            this.btnOpenScreenshotsFolder.Click += new System.EventHandler(this.btnOpenScreenshotsFolder_Click);
            // 
            // lblPreviewPersonalFolderPath
            // 
            this.lblPreviewPersonalFolderPath.AutoSize = true;
            this.lblPreviewPersonalFolderPath.Location = new System.Drawing.Point(104, 69);
            this.lblPreviewPersonalFolderPath.Name = "lblPreviewPersonalFolderPath";
            this.lblPreviewPersonalFolderPath.Size = new System.Drawing.Size(16, 13);
            this.lblPreviewPersonalFolderPath.TabIndex = 17;
            this.lblPreviewPersonalFolderPath.Text = "...";
            // 
            // btnBrowsePersonalFolderPath
            // 
            this.btnBrowsePersonalFolderPath.Location = new System.Drawing.Point(432, 39);
            this.btnBrowsePersonalFolderPath.Name = "btnBrowsePersonalFolderPath";
            this.btnBrowsePersonalFolderPath.Size = new System.Drawing.Size(80, 23);
            this.btnBrowsePersonalFolderPath.TabIndex = 16;
            this.btnBrowsePersonalFolderPath.Text = "Browse...";
            this.btnBrowsePersonalFolderPath.UseVisualStyleBackColor = true;
            this.btnBrowsePersonalFolderPath.Click += new System.EventHandler(this.btnBrowsePersonalFolderPath_Click);
            // 
            // lblPersonalFolderPath
            // 
            this.lblPersonalFolderPath.AutoSize = true;
            this.lblPersonalFolderPath.Location = new System.Drawing.Point(16, 16);
            this.lblPersonalFolderPath.Name = "lblPersonalFolderPath";
            this.lblPersonalFolderPath.Size = new System.Drawing.Size(117, 13);
            this.lblPersonalFolderPath.TabIndex = 15;
            this.lblPersonalFolderPath.Text = "ShareX personal folder:";
            // 
            // txtPersonalFolderPath
            // 
            this.txtPersonalFolderPath.Location = new System.Drawing.Point(16, 40);
            this.txtPersonalFolderPath.Name = "txtPersonalFolderPath";
            this.txtPersonalFolderPath.Size = new System.Drawing.Size(408, 20);
            this.txtPersonalFolderPath.TabIndex = 14;
            this.txtPersonalFolderPath.TextChanged += new System.EventHandler(this.txtPersonalFolderPath_TextChanged);
            // 
            // btnBrowseCustomScreenshotsPath
            // 
            this.btnBrowseCustomScreenshotsPath.Location = new System.Drawing.Point(432, 151);
            this.btnBrowseCustomScreenshotsPath.Name = "btnBrowseCustomScreenshotsPath";
            this.btnBrowseCustomScreenshotsPath.Size = new System.Drawing.Size(80, 23);
            this.btnBrowseCustomScreenshotsPath.TabIndex = 10;
            this.btnBrowseCustomScreenshotsPath.Text = "Browse...";
            this.btnBrowseCustomScreenshotsPath.UseVisualStyleBackColor = true;
            this.btnBrowseCustomScreenshotsPath.Click += new System.EventHandler(this.btnBrowseCustomScreenshotsPath_Click);
            // 
            // btnOpenPersonalFolderPath
            // 
            this.btnOpenPersonalFolderPath.Location = new System.Drawing.Point(16, 64);
            this.btnOpenPersonalFolderPath.Name = "btnOpenPersonalFolderPath";
            this.btnOpenPersonalFolderPath.Size = new System.Drawing.Size(80, 23);
            this.btnOpenPersonalFolderPath.TabIndex = 0;
            this.btnOpenPersonalFolderPath.Text = "Open...";
            this.btnOpenPersonalFolderPath.UseVisualStyleBackColor = true;
            this.btnOpenPersonalFolderPath.Click += new System.EventHandler(this.btnOpenPersonalFolder_Click);
            // 
            // txtCustomScreenshotsPath
            // 
            this.txtCustomScreenshotsPath.Location = new System.Drawing.Point(16, 152);
            this.txtCustomScreenshotsPath.Name = "txtCustomScreenshotsPath";
            this.txtCustomScreenshotsPath.Size = new System.Drawing.Size(408, 20);
            this.txtCustomScreenshotsPath.TabIndex = 9;
            this.txtCustomScreenshotsPath.TextChanged += new System.EventHandler(this.txtCustomScreenshotsPath_TextChanged);
            // 
            // cbUseCustomScreenshotsPath
            // 
            this.cbUseCustomScreenshotsPath.AutoSize = true;
            this.cbUseCustomScreenshotsPath.Location = new System.Drawing.Point(16, 128);
            this.cbUseCustomScreenshotsPath.Name = "cbUseCustomScreenshotsPath";
            this.cbUseCustomScreenshotsPath.Size = new System.Drawing.Size(174, 17);
            this.cbUseCustomScreenshotsPath.TabIndex = 8;
            this.cbUseCustomScreenshotsPath.Text = "Use custom screenshots folder:";
            this.cbUseCustomScreenshotsPath.UseVisualStyleBackColor = true;
            this.cbUseCustomScreenshotsPath.CheckedChanged += new System.EventHandler(this.cbUseCustomScreenshotsPath_CheckedChanged);
            // 
            // lblSaveImageSubFolderPattern
            // 
            this.lblSaveImageSubFolderPattern.AutoSize = true;
            this.lblSaveImageSubFolderPattern.Location = new System.Drawing.Point(16, 184);
            this.lblSaveImageSubFolderPattern.Name = "lblSaveImageSubFolderPattern";
            this.lblSaveImageSubFolderPattern.Size = new System.Drawing.Size(94, 13);
            this.lblSaveImageSubFolderPattern.TabIndex = 11;
            this.lblSaveImageSubFolderPattern.Text = "Sub folder pattern:";
            // 
            // lblSaveImageSubFolderPatternPreview
            // 
            this.lblSaveImageSubFolderPatternPreview.AutoSize = true;
            this.lblSaveImageSubFolderPatternPreview.Location = new System.Drawing.Point(104, 213);
            this.lblSaveImageSubFolderPatternPreview.Name = "lblSaveImageSubFolderPatternPreview";
            this.lblSaveImageSubFolderPatternPreview.Size = new System.Drawing.Size(16, 13);
            this.lblSaveImageSubFolderPatternPreview.TabIndex = 13;
            this.lblSaveImageSubFolderPatternPreview.Text = "...";
            // 
            // txtSaveImageSubFolderPattern
            // 
            this.txtSaveImageSubFolderPattern.Location = new System.Drawing.Point(120, 180);
            this.txtSaveImageSubFolderPattern.Name = "txtSaveImageSubFolderPattern";
            this.txtSaveImageSubFolderPattern.Size = new System.Drawing.Size(392, 20);
            this.txtSaveImageSubFolderPattern.TabIndex = 12;
            this.txtSaveImageSubFolderPattern.TextChanged += new System.EventHandler(this.txtSaveImageSubFolderPattern_TextChanged);
            // 
            // tpProxy
            // 
            this.tpProxy.Controls.Add(this.lblProxyNote);
            this.tpProxy.Controls.Add(this.cbProxyMethod);
            this.tpProxy.Controls.Add(this.lblProxyMethod);
            this.tpProxy.Controls.Add(this.cbProxyType);
            this.tpProxy.Controls.Add(this.lblProxyType);
            this.tpProxy.Controls.Add(this.lblProxyHost);
            this.tpProxy.Controls.Add(this.txtProxyHost);
            this.tpProxy.Controls.Add(this.nudProxyPort);
            this.tpProxy.Controls.Add(this.lblProxyPort);
            this.tpProxy.Controls.Add(this.lblProxyPassword);
            this.tpProxy.Controls.Add(this.txtProxyPassword);
            this.tpProxy.Controls.Add(this.lblProxyUsername);
            this.tpProxy.Controls.Add(this.txtProxyUsername);
            this.tpProxy.Location = new System.Drawing.Point(4, 22);
            this.tpProxy.Name = "tpProxy";
            this.tpProxy.Padding = new System.Windows.Forms.Padding(5);
            this.tpProxy.Size = new System.Drawing.Size(522, 308);
            this.tpProxy.TabIndex = 2;
            this.tpProxy.Text = "Proxy";
            this.tpProxy.UseVisualStyleBackColor = true;
            // 
            // lblProxyNote
            // 
            this.lblProxyNote.AutoSize = true;
            this.lblProxyNote.Location = new System.Drawing.Point(264, 48);
            this.lblProxyNote.Name = "lblProxyNote";
            this.lblProxyNote.Size = new System.Drawing.Size(196, 13);
            this.lblProxyNote.TabIndex = 12;
            this.lblProxyNote.Text = "SOCKS proxy is only supported by FTP. ";
            // 
            // cbProxyMethod
            // 
            this.cbProxyMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProxyMethod.FormattingEnabled = true;
            this.cbProxyMethod.Location = new System.Drawing.Point(120, 12);
            this.cbProxyMethod.Name = "cbProxyMethod";
            this.cbProxyMethod.Size = new System.Drawing.Size(136, 21);
            this.cbProxyMethod.TabIndex = 1;
            this.cbProxyMethod.SelectedIndexChanged += new System.EventHandler(this.cbProxyMethod_SelectedIndexChanged);
            // 
            // lblProxyMethod
            // 
            this.lblProxyMethod.AutoSize = true;
            this.lblProxyMethod.Location = new System.Drawing.Point(16, 16);
            this.lblProxyMethod.Name = "lblProxyMethod";
            this.lblProxyMethod.Size = new System.Drawing.Size(100, 13);
            this.lblProxyMethod.TabIndex = 0;
            this.lblProxyMethod.Text = "Proxy configuration:";
            // 
            // cbProxyType
            // 
            this.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProxyType.FormattingEnabled = true;
            this.cbProxyType.Location = new System.Drawing.Point(120, 44);
            this.cbProxyType.Name = "cbProxyType";
            this.cbProxyType.Size = new System.Drawing.Size(136, 21);
            this.cbProxyType.TabIndex = 11;
            this.cbProxyType.SelectedIndexChanged += new System.EventHandler(this.cboProxyType_SelectedIndexChanged);
            // 
            // lblProxyType
            // 
            this.lblProxyType.AutoSize = true;
            this.lblProxyType.Location = new System.Drawing.Point(16, 48);
            this.lblProxyType.Name = "lblProxyType";
            this.lblProxyType.Size = new System.Drawing.Size(34, 13);
            this.lblProxyType.TabIndex = 10;
            this.lblProxyType.Text = "Type:";
            // 
            // lblProxyHost
            // 
            this.lblProxyHost.AutoSize = true;
            this.lblProxyHost.Location = new System.Drawing.Point(16, 80);
            this.lblProxyHost.Name = "lblProxyHost";
            this.lblProxyHost.Size = new System.Drawing.Size(32, 13);
            this.lblProxyHost.TabIndex = 6;
            this.lblProxyHost.Text = "Host:";
            // 
            // txtProxyHost
            // 
            this.txtProxyHost.Location = new System.Drawing.Point(120, 76);
            this.txtProxyHost.Name = "txtProxyHost";
            this.txtProxyHost.Size = new System.Drawing.Size(232, 20);
            this.txtProxyHost.TabIndex = 7;
            this.txtProxyHost.TextChanged += new System.EventHandler(this.txtProxyHost_TextChanged);
            // 
            // nudProxyPort
            // 
            this.nudProxyPort.Location = new System.Drawing.Point(392, 76);
            this.nudProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudProxyPort.Name = "nudProxyPort";
            this.nudProxyPort.Size = new System.Drawing.Size(64, 20);
            this.nudProxyPort.TabIndex = 9;
            this.nudProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProxyPort.ValueChanged += new System.EventHandler(this.nudProxyPort_ValueChanged);
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.AutoSize = true;
            this.lblProxyPort.Location = new System.Drawing.Point(360, 80);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProxyPort.Size = new System.Drawing.Size(26, 13);
            this.lblProxyPort.TabIndex = 8;
            this.lblProxyPort.Text = "Port";
            // 
            // lblProxyPassword
            // 
            this.lblProxyPassword.AutoSize = true;
            this.lblProxyPassword.Location = new System.Drawing.Point(16, 144);
            this.lblProxyPassword.Name = "lblProxyPassword";
            this.lblProxyPassword.Size = new System.Drawing.Size(56, 13);
            this.lblProxyPassword.TabIndex = 4;
            this.lblProxyPassword.Text = "Password:";
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(120, 140);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.PasswordChar = '●';
            this.txtProxyPassword.Size = new System.Drawing.Size(232, 20);
            this.txtProxyPassword.TabIndex = 5;
            this.txtProxyPassword.TextChanged += new System.EventHandler(this.txtProxyPassword_TextChanged);
            // 
            // lblProxyUsername
            // 
            this.lblProxyUsername.AutoSize = true;
            this.lblProxyUsername.Location = new System.Drawing.Point(16, 112);
            this.lblProxyUsername.Name = "lblProxyUsername";
            this.lblProxyUsername.Size = new System.Drawing.Size(58, 13);
            this.lblProxyUsername.TabIndex = 2;
            this.lblProxyUsername.Text = "Username:";
            // 
            // txtProxyUsername
            // 
            this.txtProxyUsername.Location = new System.Drawing.Point(120, 108);
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.Size = new System.Drawing.Size(232, 20);
            this.txtProxyUsername.TabIndex = 3;
            this.txtProxyUsername.TextChanged += new System.EventHandler(this.txtProxyUsername_TextChanged);
            // 
            // tpUpload
            // 
            this.tpUpload.Controls.Add(this.gbBandwidth);
            this.tpUpload.Controls.Add(this.gbClipboardFormats);
            this.tpUpload.Controls.Add(this.cbIfUploadFailRetryOnce);
            this.tpUpload.Location = new System.Drawing.Point(4, 22);
            this.tpUpload.Name = "tpUpload";
            this.tpUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpload.Size = new System.Drawing.Size(522, 308);
            this.tpUpload.TabIndex = 3;
            this.tpUpload.Text = "Upload";
            this.tpUpload.UseVisualStyleBackColor = true;
            // 
            // gbBandwidth
            // 
            this.gbBandwidth.Controls.Add(this.lblUploadLimit);
            this.gbBandwidth.Controls.Add(this.nudUploadLimit);
            this.gbBandwidth.Controls.Add(this.lblUploadLimitHint);
            this.gbBandwidth.Controls.Add(this.lblBufferSize);
            this.gbBandwidth.Controls.Add(this.cbBufferSize);
            this.gbBandwidth.Location = new System.Drawing.Point(16, 40);
            this.gbBandwidth.Name = "gbBandwidth";
            this.gbBandwidth.Size = new System.Drawing.Size(488, 88);
            this.gbBandwidth.TabIndex = 1;
            this.gbBandwidth.TabStop = false;
            this.gbBandwidth.Text = "Bandwidth";
            // 
            // lblUploadLimit
            // 
            this.lblUploadLimit.AutoSize = true;
            this.lblUploadLimit.Location = new System.Drawing.Point(16, 24);
            this.lblUploadLimit.Name = "lblUploadLimit";
            this.lblUploadLimit.Size = new System.Drawing.Size(128, 13);
            this.lblUploadLimit.TabIndex = 0;
            this.lblUploadLimit.Text = "Simultaneous upload limit:";
            // 
            // nudUploadLimit
            // 
            this.nudUploadLimit.Location = new System.Drawing.Point(148, 20);
            this.nudUploadLimit.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudUploadLimit.Name = "nudUploadLimit";
            this.nudUploadLimit.Size = new System.Drawing.Size(56, 20);
            this.nudUploadLimit.TabIndex = 1;
            this.nudUploadLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUploadLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUploadLimit.ValueChanged += new System.EventHandler(this.nudUploadLimit_ValueChanged);
            // 
            // lblUploadLimitHint
            // 
            this.lblUploadLimitHint.AutoSize = true;
            this.lblUploadLimitHint.Location = new System.Drawing.Point(212, 24);
            this.lblUploadLimitHint.Name = "lblUploadLimitHint";
            this.lblUploadLimitHint.Size = new System.Drawing.Size(90, 13);
            this.lblUploadLimitHint.TabIndex = 2;
            this.lblUploadLimitHint.Text = "0 - 25 (0 disables)";
            // 
            // lblBufferSize
            // 
            this.lblBufferSize.AutoSize = true;
            this.lblBufferSize.Location = new System.Drawing.Point(16, 56);
            this.lblBufferSize.Name = "lblBufferSize";
            this.lblBufferSize.Size = new System.Drawing.Size(59, 13);
            this.lblBufferSize.TabIndex = 3;
            this.lblBufferSize.Text = "Buffer size:";
            // 
            // cbBufferSize
            // 
            this.cbBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBufferSize.FormattingEnabled = true;
            this.cbBufferSize.Location = new System.Drawing.Point(76, 52);
            this.cbBufferSize.Name = "cbBufferSize";
            this.cbBufferSize.Size = new System.Drawing.Size(76, 21);
            this.cbBufferSize.TabIndex = 4;
            this.cbBufferSize.SelectedIndexChanged += new System.EventHandler(this.cbBufferSize_SelectedIndexChanged);
            // 
            // gbClipboardFormats
            // 
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatEdit);
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatRemove);
            this.gbClipboardFormats.Controls.Add(this.btnClipboardFormatAdd);
            this.gbClipboardFormats.Controls.Add(this.lvClipboardFormats);
            this.gbClipboardFormats.Location = new System.Drawing.Point(16, 136);
            this.gbClipboardFormats.Name = "gbClipboardFormats";
            this.gbClipboardFormats.Size = new System.Drawing.Size(488, 160);
            this.gbClipboardFormats.TabIndex = 2;
            this.gbClipboardFormats.TabStop = false;
            this.gbClipboardFormats.Text = "Clipboard Formats";
            // 
            // btnClipboardFormatEdit
            // 
            this.btnClipboardFormatEdit.Location = new System.Drawing.Point(88, 16);
            this.btnClipboardFormatEdit.Name = "btnClipboardFormatEdit";
            this.btnClipboardFormatEdit.Size = new System.Drawing.Size(72, 23);
            this.btnClipboardFormatEdit.TabIndex = 1;
            this.btnClipboardFormatEdit.Text = "Edit...";
            this.btnClipboardFormatEdit.UseVisualStyleBackColor = true;
            this.btnClipboardFormatEdit.Click += new System.EventHandler(this.btnClipboardFormatEdit_Click);
            // 
            // btnClipboardFormatRemove
            // 
            this.btnClipboardFormatRemove.Location = new System.Drawing.Point(168, 16);
            this.btnClipboardFormatRemove.Name = "btnClipboardFormatRemove";
            this.btnClipboardFormatRemove.Size = new System.Drawing.Size(72, 23);
            this.btnClipboardFormatRemove.TabIndex = 2;
            this.btnClipboardFormatRemove.Text = "Remove";
            this.btnClipboardFormatRemove.UseVisualStyleBackColor = true;
            this.btnClipboardFormatRemove.Click += new System.EventHandler(this.btnClipboardFormatRemove_Click);
            // 
            // btnClipboardFormatAdd
            // 
            this.btnClipboardFormatAdd.Location = new System.Drawing.Point(8, 16);
            this.btnClipboardFormatAdd.Name = "btnClipboardFormatAdd";
            this.btnClipboardFormatAdd.Size = new System.Drawing.Size(72, 23);
            this.btnClipboardFormatAdd.TabIndex = 0;
            this.btnClipboardFormatAdd.Text = "Add...";
            this.btnClipboardFormatAdd.UseVisualStyleBackColor = true;
            this.btnClipboardFormatAdd.Click += new System.EventHandler(this.btnAddClipboardFormat_Click);
            // 
            // lvClipboardFormats
            // 
            this.lvClipboardFormats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDescription,
            this.chFormat});
            this.lvClipboardFormats.FullRowSelect = true;
            this.lvClipboardFormats.Location = new System.Drawing.Point(8, 48);
            this.lvClipboardFormats.Name = "lvClipboardFormats";
            this.lvClipboardFormats.Size = new System.Drawing.Size(472, 104);
            this.lvClipboardFormats.TabIndex = 3;
            this.lvClipboardFormats.UseCompatibleStateImageBehavior = false;
            this.lvClipboardFormats.View = System.Windows.Forms.View.Details;
            this.lvClipboardFormats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvClipboardFormats_MouseDoubleClick);
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 135;
            // 
            // chFormat
            // 
            this.chFormat.Text = "Format";
            this.chFormat.Width = 320;
            // 
            // cbIfUploadFailRetryOnce
            // 
            this.cbIfUploadFailRetryOnce.AutoSize = true;
            this.cbIfUploadFailRetryOnce.Location = new System.Drawing.Point(16, 16);
            this.cbIfUploadFailRetryOnce.Name = "cbIfUploadFailRetryOnce";
            this.cbIfUploadFailRetryOnce.Size = new System.Drawing.Size(223, 17);
            this.cbIfUploadFailRetryOnce.TabIndex = 0;
            this.cbIfUploadFailRetryOnce.Text = "If upload fails then retry upload once more";
            this.cbIfUploadFailRetryOnce.UseVisualStyleBackColor = true;
            this.cbIfUploadFailRetryOnce.CheckedChanged += new System.EventHandler(this.cbIfUploadFailRetryOnce_CheckedChanged);
            // 
            // tpPrint
            // 
            this.tpPrint.Controls.Add(this.cbDontShowPrintSettingDialog);
            this.tpPrint.Controls.Add(this.btnShowImagePrintSettings);
            this.tpPrint.Location = new System.Drawing.Point(4, 22);
            this.tpPrint.Name = "tpPrint";
            this.tpPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrint.Size = new System.Drawing.Size(522, 308);
            this.tpPrint.TabIndex = 4;
            this.tpPrint.Text = "Print";
            this.tpPrint.UseVisualStyleBackColor = true;
            // 
            // cbDontShowPrintSettingDialog
            // 
            this.cbDontShowPrintSettingDialog.AutoSize = true;
            this.cbDontShowPrintSettingDialog.Location = new System.Drawing.Point(16, 16);
            this.cbDontShowPrintSettingDialog.Name = "cbDontShowPrintSettingDialog";
            this.cbDontShowPrintSettingDialog.Size = new System.Drawing.Size(172, 17);
            this.cbDontShowPrintSettingDialog.TabIndex = 0;
            this.cbDontShowPrintSettingDialog.Text = "Don\'t show print settings dialog";
            this.cbDontShowPrintSettingDialog.UseVisualStyleBackColor = true;
            this.cbDontShowPrintSettingDialog.CheckedChanged += new System.EventHandler(this.cbDontShowPrintSettingDialog_CheckedChanged);
            // 
            // btnShowImagePrintSettings
            // 
            this.btnShowImagePrintSettings.Location = new System.Drawing.Point(16, 40);
            this.btnShowImagePrintSettings.Name = "btnShowImagePrintSettings";
            this.btnShowImagePrintSettings.Size = new System.Drawing.Size(168, 23);
            this.btnShowImagePrintSettings.TabIndex = 1;
            this.btnShowImagePrintSettings.Text = "Show image print settings...";
            this.btnShowImagePrintSettings.UseVisualStyleBackColor = true;
            this.btnShowImagePrintSettings.Click += new System.EventHandler(this.btnShowImagePrintSettings_Click);
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.pgSettings);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(522, 308);
            this.tpAdvanced.TabIndex = 5;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // pgSettings
            // 
            this.pgSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgSettings.Location = new System.Drawing.Point(3, 3);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.Size = new System.Drawing.Size(516, 302);
            this.pgSettings.TabIndex = 0;
            // 
            // cbSilentRun
            // 
            this.cbSilentRun.AutoSize = true;
            this.cbSilentRun.Location = new System.Drawing.Point(16, 40);
            this.cbSilentRun.Name = "cbSilentRun";
            this.cbSilentRun.Size = new System.Drawing.Size(137, 17);
            this.cbSilentRun.TabIndex = 8;
            this.cbSilentRun.Text = "On start minimize to tray";
            this.cbSilentRun.UseVisualStyleBackColor = true;
            this.cbSilentRun.CheckedChanged += new System.EventHandler(this.cbSilentRun_CheckedChanged);
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 340);
            this.Controls.Add(this.tcSettings);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(552, 300);
            this.Name = "ApplicationSettingsForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareX - Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.tcSettings.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpPaths.ResumeLayout(false);
            this.tpPaths.PerformLayout();
            this.tpProxy.ResumeLayout(false);
            this.tpProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProxyPort)).EndInit();
            this.tpUpload.ResumeLayout(false);
            this.tpUpload.PerformLayout();
            this.gbBandwidth.ResumeLayout(false);
            this.gbBandwidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUploadLimit)).EndInit();
            this.gbClipboardFormats.ResumeLayout(false);
            this.tpPrint.ResumeLayout(false);
            this.tpPrint.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpProxy;
        private System.Windows.Forms.CheckBox cbSendToMenu;
        private System.Windows.Forms.Button btnOpenPersonalFolderPath;
        private System.Windows.Forms.CheckBox cbShowTray;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.Label lblSaveImageSubFolderPatternPreview;
        private System.Windows.Forms.TextBox txtSaveImageSubFolderPattern;
        private System.Windows.Forms.Label lblSaveImageSubFolderPattern;
        private System.Windows.Forms.CheckBox cbCheckUpdates;
        private System.Windows.Forms.CheckBox cbUseCustomScreenshotsPath;
        private System.Windows.Forms.TabPage tpPaths;
        private System.Windows.Forms.Button btnBrowseCustomScreenshotsPath;
        private System.Windows.Forms.TextBox txtCustomScreenshotsPath;
        private System.Windows.Forms.Label lblProxyHost;
        private System.Windows.Forms.TextBox txtProxyHost;
        private System.Windows.Forms.NumericUpDown nudProxyPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.Label lblProxyPassword;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label lblProxyUsername;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.ComboBox cbProxyType;
        private System.Windows.Forms.Label lblProxyType;
        private System.Windows.Forms.CheckBox cbShellContextMenu;
        private System.Windows.Forms.ComboBox cbProxyMethod;
        private System.Windows.Forms.Label lblProxyMethod;
        private System.Windows.Forms.Label lblProxyNote;
        private System.Windows.Forms.TabPage tpUpload;
        private System.Windows.Forms.CheckBox cbIfUploadFailRetryOnce;
        private System.Windows.Forms.Label lblUploadLimit;
        private System.Windows.Forms.ComboBox cbBufferSize;
        private System.Windows.Forms.Label lblUploadLimitHint;
        private System.Windows.Forms.Label lblBufferSize;
        private System.Windows.Forms.NumericUpDown nudUploadLimit;
        private System.Windows.Forms.GroupBox gbBandwidth;
        private System.Windows.Forms.GroupBox gbClipboardFormats;
        private System.Windows.Forms.Button btnClipboardFormatRemove;
        private System.Windows.Forms.Button btnClipboardFormatAdd;
        private HelpersLib.MyListView lvClipboardFormats;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chFormat;
        private System.Windows.Forms.Button btnClipboardFormatEdit;
        private System.Windows.Forms.TabPage tpPrint;
        private System.Windows.Forms.CheckBox cbDontShowPrintSettingDialog;
        private System.Windows.Forms.Button btnShowImagePrintSettings;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.PropertyGrid pgSettings;
        private System.Windows.Forms.CheckBox cbTaskbarProgressEnabled;
        private System.Windows.Forms.CheckBox cbTrayIconProgressEnabled;
        private System.Windows.Forms.CheckBox cbRememberMainFormSize;
        private System.Windows.Forms.Label lblPreviewPersonalFolderPath;
        private System.Windows.Forms.Button btnBrowsePersonalFolderPath;
        private System.Windows.Forms.Label lblPersonalFolderPath;
        private System.Windows.Forms.TextBox txtPersonalFolderPath;
        private System.Windows.Forms.Button btnOpenScreenshotsFolder;
        private System.Windows.Forms.Label lblNotePersonalFolderPath;
        private System.Windows.Forms.CheckBox cbSilentRun;
    }
}