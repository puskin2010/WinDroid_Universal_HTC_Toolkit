namespace WinDroid
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.aboutTabPage = new MetroFramework.Controls.MetroTabPage();
            this.choosePhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.changePhoneComboBox = new MetroFramework.Controls.MetroComboBox();
            this.contactGroupBox = new System.Windows.Forms.GroupBox();
            this.xdaButton = new MetroFramework.Controls.MetroButton();
            this.twitterButton = new MetroFramework.Controls.MetroButton();
            this.emailButton = new MetroFramework.Controls.MetroButton();
            this.winDroidLabel = new MetroFramework.Controls.MetroLabel();
            this.donateTile = new MetroFramework.Controls.MetroTile();
            this.helpTile = new MetroFramework.Controls.MetroTile();
            this.requestsTile = new MetroFramework.Controls.MetroTile();
            this.fastbootTabPage = new MetroFramework.Controls.MetroTabPage();
            this.permanentFlashGroupBox = new System.Windows.Forms.GroupBox();
            this.permanentRecoveryButton = new MetroFramework.Controls.MetroButton();
            this.bootloaderGroupBox = new System.Windows.Forms.GroupBox();
            this.relockBootloaderButton = new MetroFramework.Controls.MetroButton();
            this.fastbootInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.getMIDButton = new MetroFramework.Controls.MetroButton();
            this.getIMEIButton = new MetroFramework.Controls.MetroButton();
            this.getSerialNumberButton = new MetroFramework.Controls.MetroButton();
            this.getCIDButton = new MetroFramework.Controls.MetroButton();
            this.fastbootInformationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.temporaryFastbootGroupBox = new System.Windows.Forms.GroupBox();
            this.temporaryKernelButton = new MetroFramework.Controls.MetroButton();
            this.temporaryRecoveryButton = new MetroFramework.Controls.MetroButton();
            this.rebootFastbootGroupBox = new System.Windows.Forms.GroupBox();
            this.rebootFromBootloaderButton = new MetroFramework.Controls.MetroButton();
            this.rebootToBootloaderButton = new MetroFramework.Controls.MetroButton();
            this.adbTabPage = new MetroFramework.Controls.MetroTabPage();
            this.logsGroupBox = new System.Windows.Forms.GroupBox();
            this.dmesgButton = new MetroFramework.Controls.MetroButton();
            this.logcatButton = new MetroFramework.Controls.MetroButton();
            this.backupsGroupBox = new System.Windows.Forms.GroupBox();
            this.restoreButton = new MetroFramework.Controls.MetroButton();
            this.backupButton = new MetroFramework.Controls.MetroButton();
            this.appsGroupBox = new System.Windows.Forms.GroupBox();
            this.uninstallAppButton = new MetroFramework.Controls.MetroButton();
            this.installAppButton = new MetroFramework.Controls.MetroButton();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.pullFilesButton = new MetroFramework.Controls.MetroButton();
            this.pushFilesButton = new MetroFramework.Controls.MetroButton();
            this.sideloadROMGroupBox = new System.Windows.Forms.GroupBox();
            this.sideloadROMButton = new MetroFramework.Controls.MetroButton();
            this.rebootADBGroupBox = new System.Windows.Forms.GroupBox();
            this.rebootBootloaderButton = new MetroFramework.Controls.MetroButton();
            this.rebootRecoveryButton = new MetroFramework.Controls.MetroButton();
            this.rebootButton = new MetroFramework.Controls.MetroButton();
            this.setupTabPage = new MetroFramework.Controls.MetroTabPage();
            this.otherGroupBox = new System.Windows.Forms.GroupBox();
            this.helpButton = new MetroFramework.Controls.MetroButton();
            this.donateButton = new MetroFramework.Controls.MetroButton();
            this.flashGroupBox = new System.Windows.Forms.GroupBox();
            this.flashKernelButton = new MetroFramework.Controls.MetroButton();
            this.flashROMButton = new MetroFramework.Controls.MetroButton();
            this.gainRootGroupBox = new System.Windows.Forms.GroupBox();
            this.flashSuperSUButton = new MetroFramework.Controls.MetroButton();
            this.flashRecoveryGroupBox = new System.Windows.Forms.GroupBox();
            this.secondRecoveriesGroupBox = new System.Windows.Forms.GroupBox();
            this.secondTWRPButton = new MetroFramework.Controls.MetroButton();
            this.thirdTWRPButton = new MetroFramework.Controls.MetroButton();
            this.firstRecoveriesGroupBox = new System.Windows.Forms.GroupBox();
            this.firstTWRPButton = new MetroFramework.Controls.MetroButton();
            this.unlockBootloaderGroupBox = new System.Windows.Forms.GroupBox();
            this.gainSuperCIDButton = new MetroFramework.Controls.MetroButton();
            this.unlockBootloaderButton = new MetroFramework.Controls.MetroButton();
            this.getTokenIDButton = new MetroFramework.Controls.MetroButton();
            this.mainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.refreshSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.statusProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.deviceProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.reloadButton = new MetroFramework.Controls.MetroButton();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.deviceLabel = new MetroFramework.Controls.MetroLabel();
            this.loadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.deviceRecognition = new System.ComponentModel.BackgroundWorker();
            this.noReturnADBCommand = new System.ComponentModel.BackgroundWorker();
            this.noReturnFastbootCommand = new System.ComponentModel.BackgroundWorker();
            this.adbCommand = new System.ComponentModel.BackgroundWorker();
            this.pushFile = new System.ComponentModel.BackgroundWorker();
            this.installApp = new System.ComponentModel.BackgroundWorker();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tokenID = new System.ComponentModel.BackgroundWorker();
            this.getLogcat = new System.ComponentModel.BackgroundWorker();
            this.getDmesg = new System.ComponentModel.BackgroundWorker();
            this.getFastbootInfo = new System.ComponentModel.BackgroundWorker();
            this.aboutTabPage.SuspendLayout();
            this.choosePhoneGroupBox.SuspendLayout();
            this.contactGroupBox.SuspendLayout();
            this.fastbootTabPage.SuspendLayout();
            this.permanentFlashGroupBox.SuspendLayout();
            this.bootloaderGroupBox.SuspendLayout();
            this.fastbootInformationGroupBox.SuspendLayout();
            this.temporaryFastbootGroupBox.SuspendLayout();
            this.rebootFastbootGroupBox.SuspendLayout();
            this.adbTabPage.SuspendLayout();
            this.logsGroupBox.SuspendLayout();
            this.backupsGroupBox.SuspendLayout();
            this.appsGroupBox.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.sideloadROMGroupBox.SuspendLayout();
            this.rebootADBGroupBox.SuspendLayout();
            this.setupTabPage.SuspendLayout();
            this.otherGroupBox.SuspendLayout();
            this.flashGroupBox.SuspendLayout();
            this.gainRootGroupBox.SuspendLayout();
            this.flashRecoveryGroupBox.SuspendLayout();
            this.secondRecoveriesGroupBox.SuspendLayout();
            this.firstRecoveriesGroupBox.SuspendLayout();
            this.unlockBootloaderGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.choosePhoneGroupBox);
            this.aboutTabPage.Controls.Add(this.contactGroupBox);
            this.aboutTabPage.Controls.Add(this.winDroidLabel);
            this.aboutTabPage.Controls.Add(this.donateTile);
            this.aboutTabPage.Controls.Add(this.helpTile);
            this.aboutTabPage.Controls.Add(this.requestsTile);
            this.aboutTabPage.HorizontalScrollbarBarColor = true;
            this.aboutTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.aboutTabPage.HorizontalScrollbarSize = 10;
            this.aboutTabPage.Location = new System.Drawing.Point(4, 38);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Size = new System.Drawing.Size(347, 165);
            this.aboutTabPage.TabIndex = 1;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.VerticalScrollbarBarColor = true;
            this.aboutTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.aboutTabPage.VerticalScrollbarSize = 10;
            // 
            // choosePhoneGroupBox
            // 
            this.choosePhoneGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.choosePhoneGroupBox.Controls.Add(this.changePhoneComboBox);
            this.choosePhoneGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.choosePhoneGroupBox.Location = new System.Drawing.Point(166, 111);
            this.choosePhoneGroupBox.Name = "choosePhoneGroupBox";
            this.choosePhoneGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.choosePhoneGroupBox.Size = new System.Drawing.Size(181, 54);
            this.choosePhoneGroupBox.TabIndex = 79;
            this.choosePhoneGroupBox.TabStop = false;
            this.choosePhoneGroupBox.Text = "Choose Your Phone";
            // 
            // changePhoneComboBox
            // 
            this.changePhoneComboBox.FormattingEnabled = true;
            this.changePhoneComboBox.ItemHeight = 23;
            this.changePhoneComboBox.Items.AddRange(new object[] {
            "Amaze",
            "Desire HD",
            "Desire X",
            "Droid DNA",
            "EVO 4G LTE",
            "One (M7)",
            "One (M8)",
            "One S",
            "One V",
            "One X",
            "One X+",
            "Other"});
            this.changePhoneComboBox.Location = new System.Drawing.Point(6, 19);
            this.changePhoneComboBox.Name = "changePhoneComboBox";
            this.changePhoneComboBox.Size = new System.Drawing.Size(169, 29);
            this.changePhoneComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.changePhoneComboBox.TabIndex = 75;
            this.changePhoneComboBox.UseSelectable = true;
            this.changePhoneComboBox.SelectionChangeCommitted += new System.EventHandler(this.changePhoneComboBox_SelectionChangeCommitted);
            // 
            // contactGroupBox
            // 
            this.contactGroupBox.BackColor = System.Drawing.Color.White;
            this.contactGroupBox.Controls.Add(this.xdaButton);
            this.contactGroupBox.Controls.Add(this.twitterButton);
            this.contactGroupBox.Controls.Add(this.emailButton);
            this.contactGroupBox.Location = new System.Drawing.Point(166, 30);
            this.contactGroupBox.Name = "contactGroupBox";
            this.contactGroupBox.Size = new System.Drawing.Size(181, 75);
            this.contactGroupBox.TabIndex = 78;
            this.contactGroupBox.TabStop = false;
            this.contactGroupBox.Text = "Contact";
            // 
            // xdaButton
            // 
            this.xdaButton.Location = new System.Drawing.Point(6, 46);
            this.xdaButton.Name = "xdaButton";
            this.xdaButton.Size = new System.Drawing.Size(169, 23);
            this.xdaButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.xdaButton.TabIndex = 34;
            this.xdaButton.Text = "Private Message on XDA";
            this.xdaButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.xdaButton.UseSelectable = true;
            this.xdaButton.Click += new System.EventHandler(this.xdaButton_Click);
            // 
            // twitterButton
            // 
            this.twitterButton.Location = new System.Drawing.Point(6, 19);
            this.twitterButton.Name = "twitterButton";
            this.twitterButton.Size = new System.Drawing.Size(81, 23);
            this.twitterButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.twitterButton.TabIndex = 33;
            this.twitterButton.Text = "Twitter";
            this.twitterButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.twitterButton.UseSelectable = true;
            this.twitterButton.Click += new System.EventHandler(this.twitterButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(93, 19);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(82, 23);
            this.emailButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailButton.TabIndex = 28;
            this.emailButton.Text = "Email";
            this.emailButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailButton.UseSelectable = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // winDroidLabel
            // 
            this.winDroidLabel.AutoSize = true;
            this.winDroidLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.winDroidLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.winDroidLabel.Location = new System.Drawing.Point(5, 3);
            this.winDroidLabel.Margin = new System.Windows.Forms.Padding(3);
            this.winDroidLabel.Name = "winDroidLabel";
            this.winDroidLabel.Size = new System.Drawing.Size(336, 25);
            this.winDroidLabel.TabIndex = 69;
            this.winDroidLabel.Text = "Universal HTC Toolkit by WindyCityRockr";
            this.winDroidLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.winDroidLabel.UseStyleColors = true;
            // 
            // donateTile
            // 
            this.donateTile.ActiveControl = null;
            this.donateTile.Location = new System.Drawing.Point(0, 36);
            this.donateTile.Name = "donateTile";
            this.donateTile.Size = new System.Drawing.Size(160, 39);
            this.donateTile.TabIndex = 73;
            this.donateTile.Text = "Donate";
            this.donateTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.donateTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.donateTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.donateTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.donateTile.UseSelectable = true;
            this.donateTile.Click += new System.EventHandler(this.donateTile_Click);
            // 
            // helpTile
            // 
            this.helpTile.ActiveControl = null;
            this.helpTile.Location = new System.Drawing.Point(0, 126);
            this.helpTile.Name = "helpTile";
            this.helpTile.Size = new System.Drawing.Size(160, 39);
            this.helpTile.TabIndex = 72;
            this.helpTile.Text = "Help";
            this.helpTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.helpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.helpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.helpTile.UseSelectable = true;
            this.helpTile.Click += new System.EventHandler(this.helpTile_Click);
            // 
            // requestsTile
            // 
            this.requestsTile.ActiveControl = null;
            this.requestsTile.Location = new System.Drawing.Point(0, 81);
            this.requestsTile.Name = "requestsTile";
            this.requestsTile.Size = new System.Drawing.Size(160, 39);
            this.requestsTile.TabIndex = 71;
            this.requestsTile.Text = "Requests";
            this.requestsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requestsTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.requestsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.requestsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.requestsTile.UseSelectable = true;
            this.requestsTile.Click += new System.EventHandler(this.requestsTile_Click);
            // 
            // fastbootTabPage
            // 
            this.fastbootTabPage.Controls.Add(this.permanentFlashGroupBox);
            this.fastbootTabPage.Controls.Add(this.bootloaderGroupBox);
            this.fastbootTabPage.Controls.Add(this.fastbootInformationGroupBox);
            this.fastbootTabPage.Controls.Add(this.temporaryFastbootGroupBox);
            this.fastbootTabPage.Controls.Add(this.rebootFastbootGroupBox);
            this.fastbootTabPage.HorizontalScrollbarBarColor = true;
            this.fastbootTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.fastbootTabPage.HorizontalScrollbarSize = 10;
            this.fastbootTabPage.Location = new System.Drawing.Point(4, 38);
            this.fastbootTabPage.Name = "fastbootTabPage";
            this.fastbootTabPage.Size = new System.Drawing.Size(347, 165);
            this.fastbootTabPage.TabIndex = 0;
            this.fastbootTabPage.Text = "Fastboot Commands";
            this.fastbootTabPage.VerticalScrollbarBarColor = true;
            this.fastbootTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.fastbootTabPage.VerticalScrollbarSize = 10;
            // 
            // permanentFlashGroupBox
            // 
            this.permanentFlashGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.permanentFlashGroupBox.Controls.Add(this.permanentRecoveryButton);
            this.permanentFlashGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.permanentFlashGroupBox.Location = new System.Drawing.Point(127, 117);
            this.permanentFlashGroupBox.Name = "permanentFlashGroupBox";
            this.permanentFlashGroupBox.Size = new System.Drawing.Size(107, 48);
            this.permanentFlashGroupBox.TabIndex = 77;
            this.permanentFlashGroupBox.TabStop = false;
            this.permanentFlashGroupBox.Text = "Permanent Flash";
            // 
            // permanentRecoveryButton
            // 
            this.permanentRecoveryButton.Location = new System.Drawing.Point(6, 19);
            this.permanentRecoveryButton.Name = "permanentRecoveryButton";
            this.permanentRecoveryButton.Size = new System.Drawing.Size(95, 23);
            this.permanentRecoveryButton.TabIndex = 74;
            this.permanentRecoveryButton.Text = "Recovery";
            this.permanentRecoveryButton.UseSelectable = true;
            this.permanentRecoveryButton.Click += new System.EventHandler(this.permanentRecoveryButton_Click);
            // 
            // bootloaderGroupBox
            // 
            this.bootloaderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bootloaderGroupBox.Controls.Add(this.relockBootloaderButton);
            this.bootloaderGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bootloaderGroupBox.Location = new System.Drawing.Point(240, 117);
            this.bootloaderGroupBox.Name = "bootloaderGroupBox";
            this.bootloaderGroupBox.Size = new System.Drawing.Size(107, 48);
            this.bootloaderGroupBox.TabIndex = 76;
            this.bootloaderGroupBox.TabStop = false;
            this.bootloaderGroupBox.Text = "Bootloader";
            // 
            // relockBootloaderButton
            // 
            this.relockBootloaderButton.Location = new System.Drawing.Point(6, 19);
            this.relockBootloaderButton.Name = "relockBootloaderButton";
            this.relockBootloaderButton.Size = new System.Drawing.Size(95, 23);
            this.relockBootloaderButton.TabIndex = 74;
            this.relockBootloaderButton.Text = "Relock";
            this.relockBootloaderButton.UseSelectable = true;
            this.relockBootloaderButton.Click += new System.EventHandler(this.relockBootloaderButton_Click);
            // 
            // fastbootInformationGroupBox
            // 
            this.fastbootInformationGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastbootInformationGroupBox.Controls.Add(this.getMIDButton);
            this.fastbootInformationGroupBox.Controls.Add(this.getIMEIButton);
            this.fastbootInformationGroupBox.Controls.Add(this.getSerialNumberButton);
            this.fastbootInformationGroupBox.Controls.Add(this.getCIDButton);
            this.fastbootInformationGroupBox.Controls.Add(this.fastbootInformationTextBox);
            this.fastbootInformationGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastbootInformationGroupBox.Location = new System.Drawing.Point(127, 5);
            this.fastbootInformationGroupBox.Name = "fastbootInformationGroupBox";
            this.fastbootInformationGroupBox.Size = new System.Drawing.Size(220, 106);
            this.fastbootInformationGroupBox.TabIndex = 75;
            this.fastbootInformationGroupBox.TabStop = false;
            this.fastbootInformationGroupBox.Text = "Information";
            // 
            // getMIDButton
            // 
            this.getMIDButton.Location = new System.Drawing.Point(113, 48);
            this.getMIDButton.Name = "getMIDButton";
            this.getMIDButton.Size = new System.Drawing.Size(101, 23);
            this.getMIDButton.TabIndex = 77;
            this.getMIDButton.Text = "Get MID";
            this.getMIDButton.UseSelectable = true;
            this.getMIDButton.Click += new System.EventHandler(this.getMIDButton_Click);
            // 
            // getIMEIButton
            // 
            this.getIMEIButton.Location = new System.Drawing.Point(113, 19);
            this.getIMEIButton.Name = "getIMEIButton";
            this.getIMEIButton.Size = new System.Drawing.Size(101, 23);
            this.getIMEIButton.TabIndex = 76;
            this.getIMEIButton.Text = "Get IMEI";
            this.getIMEIButton.UseSelectable = true;
            this.getIMEIButton.Click += new System.EventHandler(this.getIMEIButton_Click);
            // 
            // getSerialNumberButton
            // 
            this.getSerialNumberButton.Location = new System.Drawing.Point(6, 19);
            this.getSerialNumberButton.Name = "getSerialNumberButton";
            this.getSerialNumberButton.Size = new System.Drawing.Size(101, 23);
            this.getSerialNumberButton.TabIndex = 75;
            this.getSerialNumberButton.Text = "Get Serial #";
            this.getSerialNumberButton.UseSelectable = true;
            this.getSerialNumberButton.Click += new System.EventHandler(this.getSerialNumberButton_Click);
            // 
            // getCIDButton
            // 
            this.getCIDButton.Location = new System.Drawing.Point(6, 48);
            this.getCIDButton.Name = "getCIDButton";
            this.getCIDButton.Size = new System.Drawing.Size(101, 23);
            this.getCIDButton.TabIndex = 74;
            this.getCIDButton.Text = "Get CID";
            this.getCIDButton.UseSelectable = true;
            this.getCIDButton.Click += new System.EventHandler(this.getCIDButton_Click);
            // 
            // fastbootInformationTextBox
            // 
            this.fastbootInformationTextBox.Lines = new string[0];
            this.fastbootInformationTextBox.Location = new System.Drawing.Point(6, 77);
            this.fastbootInformationTextBox.MaxLength = 32767;
            this.fastbootInformationTextBox.Multiline = true;
            this.fastbootInformationTextBox.Name = "fastbootInformationTextBox";
            this.fastbootInformationTextBox.PasswordChar = '\0';
            this.fastbootInformationTextBox.ReadOnly = true;
            this.fastbootInformationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fastbootInformationTextBox.SelectedText = "";
            this.fastbootInformationTextBox.Size = new System.Drawing.Size(208, 23);
            this.fastbootInformationTextBox.TabIndex = 73;
            this.fastbootInformationTextBox.UseSelectable = true;
            this.fastbootInformationTextBox.UseStyleColors = true;
            // 
            // temporaryFastbootGroupBox
            // 
            this.temporaryFastbootGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.temporaryFastbootGroupBox.Controls.Add(this.temporaryKernelButton);
            this.temporaryFastbootGroupBox.Controls.Add(this.temporaryRecoveryButton);
            this.temporaryFastbootGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.temporaryFastbootGroupBox.Location = new System.Drawing.Point(0, 88);
            this.temporaryFastbootGroupBox.Name = "temporaryFastbootGroupBox";
            this.temporaryFastbootGroupBox.Size = new System.Drawing.Size(121, 77);
            this.temporaryFastbootGroupBox.TabIndex = 74;
            this.temporaryFastbootGroupBox.TabStop = false;
            this.temporaryFastbootGroupBox.Text = "Temporary Flash";
            // 
            // temporaryKernelButton
            // 
            this.temporaryKernelButton.Location = new System.Drawing.Point(6, 48);
            this.temporaryKernelButton.Name = "temporaryKernelButton";
            this.temporaryKernelButton.Size = new System.Drawing.Size(109, 23);
            this.temporaryKernelButton.TabIndex = 8;
            this.temporaryKernelButton.Text = "Kernel";
            this.temporaryKernelButton.UseSelectable = true;
            this.temporaryKernelButton.Click += new System.EventHandler(this.temporaryKernelButton_Click);
            // 
            // temporaryRecoveryButton
            // 
            this.temporaryRecoveryButton.Location = new System.Drawing.Point(6, 19);
            this.temporaryRecoveryButton.Name = "temporaryRecoveryButton";
            this.temporaryRecoveryButton.Size = new System.Drawing.Size(109, 23);
            this.temporaryRecoveryButton.TabIndex = 6;
            this.temporaryRecoveryButton.Text = "Recovery";
            this.temporaryRecoveryButton.UseSelectable = true;
            this.temporaryRecoveryButton.Click += new System.EventHandler(this.temporaryRecoveryButton_Click);
            // 
            // rebootFastbootGroupBox
            // 
            this.rebootFastbootGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rebootFastbootGroupBox.Controls.Add(this.rebootFromBootloaderButton);
            this.rebootFastbootGroupBox.Controls.Add(this.rebootToBootloaderButton);
            this.rebootFastbootGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rebootFastbootGroupBox.Location = new System.Drawing.Point(0, 5);
            this.rebootFastbootGroupBox.Name = "rebootFastbootGroupBox";
            this.rebootFastbootGroupBox.Size = new System.Drawing.Size(121, 77);
            this.rebootFastbootGroupBox.TabIndex = 67;
            this.rebootFastbootGroupBox.TabStop = false;
            this.rebootFastbootGroupBox.Text = "Reboot";
            // 
            // rebootFromBootloaderButton
            // 
            this.rebootFromBootloaderButton.Location = new System.Drawing.Point(6, 48);
            this.rebootFromBootloaderButton.Name = "rebootFromBootloaderButton";
            this.rebootFromBootloaderButton.Size = new System.Drawing.Size(109, 23);
            this.rebootFromBootloaderButton.TabIndex = 6;
            this.rebootFromBootloaderButton.Text = "From Bootloader";
            this.rebootFromBootloaderButton.UseSelectable = true;
            this.rebootFromBootloaderButton.Click += new System.EventHandler(this.rebootFromBootloaderButton_Click);
            // 
            // rebootToBootloaderButton
            // 
            this.rebootToBootloaderButton.Location = new System.Drawing.Point(6, 19);
            this.rebootToBootloaderButton.Name = "rebootToBootloaderButton";
            this.rebootToBootloaderButton.Size = new System.Drawing.Size(109, 23);
            this.rebootToBootloaderButton.TabIndex = 5;
            this.rebootToBootloaderButton.Text = "To Bootloader";
            this.rebootToBootloaderButton.UseSelectable = true;
            this.rebootToBootloaderButton.Click += new System.EventHandler(this.rebootToBootloaderButton_Click);
            // 
            // adbTabPage
            // 
            this.adbTabPage.Controls.Add(this.logsGroupBox);
            this.adbTabPage.Controls.Add(this.backupsGroupBox);
            this.adbTabPage.Controls.Add(this.appsGroupBox);
            this.adbTabPage.Controls.Add(this.filesGroupBox);
            this.adbTabPage.Controls.Add(this.sideloadROMGroupBox);
            this.adbTabPage.Controls.Add(this.rebootADBGroupBox);
            this.adbTabPage.HorizontalScrollbarBarColor = true;
            this.adbTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.adbTabPage.HorizontalScrollbarSize = 10;
            this.adbTabPage.Location = new System.Drawing.Point(4, 38);
            this.adbTabPage.Name = "adbTabPage";
            this.adbTabPage.Size = new System.Drawing.Size(347, 165);
            this.adbTabPage.TabIndex = 0;
            this.adbTabPage.Text = "ADB Commands";
            this.adbTabPage.VerticalScrollbarBarColor = true;
            this.adbTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.adbTabPage.VerticalScrollbarSize = 10;
            // 
            // logsGroupBox
            // 
            this.logsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logsGroupBox.Controls.Add(this.dmesgButton);
            this.logsGroupBox.Controls.Add(this.logcatButton);
            this.logsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logsGroupBox.Location = new System.Drawing.Point(236, 88);
            this.logsGroupBox.Name = "logsGroupBox";
            this.logsGroupBox.Size = new System.Drawing.Size(111, 77);
            this.logsGroupBox.TabIndex = 72;
            this.logsGroupBox.TabStop = false;
            this.logsGroupBox.Text = "Logs";
            // 
            // dmesgButton
            // 
            this.dmesgButton.Location = new System.Drawing.Point(6, 48);
            this.dmesgButton.Name = "dmesgButton";
            this.dmesgButton.Size = new System.Drawing.Size(99, 23);
            this.dmesgButton.TabIndex = 8;
            this.dmesgButton.Text = "Dmesg";
            this.dmesgButton.UseSelectable = true;
            this.dmesgButton.Click += new System.EventHandler(this.dmesgButton_Click);
            // 
            // logcatButton
            // 
            this.logcatButton.Location = new System.Drawing.Point(6, 19);
            this.logcatButton.Name = "logcatButton";
            this.logcatButton.Size = new System.Drawing.Size(99, 23);
            this.logcatButton.TabIndex = 7;
            this.logcatButton.Text = "Logcat";
            this.logcatButton.UseSelectable = true;
            this.logcatButton.Click += new System.EventHandler(this.logcatButton_Click);
            // 
            // backupsGroupBox
            // 
            this.backupsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backupsGroupBox.Controls.Add(this.restoreButton);
            this.backupsGroupBox.Controls.Add(this.backupButton);
            this.backupsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backupsGroupBox.Location = new System.Drawing.Point(118, 88);
            this.backupsGroupBox.Name = "backupsGroupBox";
            this.backupsGroupBox.Size = new System.Drawing.Size(112, 77);
            this.backupsGroupBox.TabIndex = 71;
            this.backupsGroupBox.TabStop = false;
            this.backupsGroupBox.Text = "Backups";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(6, 48);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(100, 23);
            this.restoreButton.TabIndex = 8;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseSelectable = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(6, 19);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(100, 23);
            this.backupButton.TabIndex = 7;
            this.backupButton.Text = "Backup";
            this.backupButton.UseSelectable = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // appsGroupBox
            // 
            this.appsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.appsGroupBox.Controls.Add(this.uninstallAppButton);
            this.appsGroupBox.Controls.Add(this.installAppButton);
            this.appsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.appsGroupBox.Location = new System.Drawing.Point(236, 5);
            this.appsGroupBox.Name = "appsGroupBox";
            this.appsGroupBox.Size = new System.Drawing.Size(111, 77);
            this.appsGroupBox.TabIndex = 70;
            this.appsGroupBox.TabStop = false;
            this.appsGroupBox.Text = "Apps";
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.Location = new System.Drawing.Point(6, 48);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Size = new System.Drawing.Size(99, 23);
            this.uninstallAppButton.TabIndex = 8;
            this.uninstallAppButton.Text = "Uninstall";
            this.uninstallAppButton.UseSelectable = true;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // installAppButton
            // 
            this.installAppButton.Location = new System.Drawing.Point(6, 19);
            this.installAppButton.Name = "installAppButton";
            this.installAppButton.Size = new System.Drawing.Size(99, 23);
            this.installAppButton.TabIndex = 7;
            this.installAppButton.Text = "Install";
            this.installAppButton.UseSelectable = true;
            this.installAppButton.Click += new System.EventHandler(this.installAppButton_Click);
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filesGroupBox.Controls.Add(this.pullFilesButton);
            this.filesGroupBox.Controls.Add(this.pushFilesButton);
            this.filesGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filesGroupBox.Location = new System.Drawing.Point(118, 5);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(112, 77);
            this.filesGroupBox.TabIndex = 69;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files";
            // 
            // pullFilesButton
            // 
            this.pullFilesButton.Location = new System.Drawing.Point(6, 48);
            this.pullFilesButton.Name = "pullFilesButton";
            this.pullFilesButton.Size = new System.Drawing.Size(100, 23);
            this.pullFilesButton.TabIndex = 8;
            this.pullFilesButton.Text = "Pull";
            this.pullFilesButton.UseSelectable = true;
            this.pullFilesButton.Click += new System.EventHandler(this.pullFilesButton_Click);
            // 
            // pushFilesButton
            // 
            this.pushFilesButton.Location = new System.Drawing.Point(6, 19);
            this.pushFilesButton.Name = "pushFilesButton";
            this.pushFilesButton.Size = new System.Drawing.Size(100, 23);
            this.pushFilesButton.TabIndex = 7;
            this.pushFilesButton.Text = "Push";
            this.pushFilesButton.UseSelectable = true;
            this.pushFilesButton.Click += new System.EventHandler(this.pushFilesButton_Click);
            // 
            // sideloadROMGroupBox
            // 
            this.sideloadROMGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sideloadROMGroupBox.Controls.Add(this.sideloadROMButton);
            this.sideloadROMGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideloadROMGroupBox.Location = new System.Drawing.Point(0, 117);
            this.sideloadROMGroupBox.Name = "sideloadROMGroupBox";
            this.sideloadROMGroupBox.Size = new System.Drawing.Size(112, 48);
            this.sideloadROMGroupBox.TabIndex = 68;
            this.sideloadROMGroupBox.TabStop = false;
            this.sideloadROMGroupBox.Text = "Sideload";
            // 
            // sideloadROMButton
            // 
            this.sideloadROMButton.Location = new System.Drawing.Point(6, 19);
            this.sideloadROMButton.Name = "sideloadROMButton";
            this.sideloadROMButton.Size = new System.Drawing.Size(100, 23);
            this.sideloadROMButton.TabIndex = 5;
            this.sideloadROMButton.Text = "Sideload ROM";
            this.sideloadROMButton.UseSelectable = true;
            this.sideloadROMButton.Click += new System.EventHandler(this.sideloadROMButton_Click);
            // 
            // rebootADBGroupBox
            // 
            this.rebootADBGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rebootADBGroupBox.Controls.Add(this.rebootBootloaderButton);
            this.rebootADBGroupBox.Controls.Add(this.rebootRecoveryButton);
            this.rebootADBGroupBox.Controls.Add(this.rebootButton);
            this.rebootADBGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rebootADBGroupBox.Location = new System.Drawing.Point(0, 5);
            this.rebootADBGroupBox.Name = "rebootADBGroupBox";
            this.rebootADBGroupBox.Size = new System.Drawing.Size(112, 106);
            this.rebootADBGroupBox.TabIndex = 67;
            this.rebootADBGroupBox.TabStop = false;
            this.rebootADBGroupBox.Text = "Reboot";
            // 
            // rebootBootloaderButton
            // 
            this.rebootBootloaderButton.Location = new System.Drawing.Point(6, 77);
            this.rebootBootloaderButton.Name = "rebootBootloaderButton";
            this.rebootBootloaderButton.Size = new System.Drawing.Size(100, 23);
            this.rebootBootloaderButton.TabIndex = 6;
            this.rebootBootloaderButton.Text = "Bootloader";
            this.rebootBootloaderButton.UseSelectable = true;
            this.rebootBootloaderButton.Click += new System.EventHandler(this.rebootBootloaderButton_Click);
            // 
            // rebootRecoveryButton
            // 
            this.rebootRecoveryButton.Location = new System.Drawing.Point(6, 48);
            this.rebootRecoveryButton.Name = "rebootRecoveryButton";
            this.rebootRecoveryButton.Size = new System.Drawing.Size(100, 23);
            this.rebootRecoveryButton.TabIndex = 5;
            this.rebootRecoveryButton.Text = "Recovery";
            this.rebootRecoveryButton.UseSelectable = true;
            this.rebootRecoveryButton.Click += new System.EventHandler(this.rebootRecoveryButton_Click);
            // 
            // rebootButton
            // 
            this.rebootButton.Location = new System.Drawing.Point(6, 19);
            this.rebootButton.Name = "rebootButton";
            this.rebootButton.Size = new System.Drawing.Size(100, 23);
            this.rebootButton.TabIndex = 4;
            this.rebootButton.Text = "Reboot";
            this.rebootButton.UseSelectable = true;
            this.rebootButton.Click += new System.EventHandler(this.rebootButton_Click);
            // 
            // setupTabPage
            // 
            this.setupTabPage.Controls.Add(this.otherGroupBox);
            this.setupTabPage.Controls.Add(this.flashGroupBox);
            this.setupTabPage.Controls.Add(this.gainRootGroupBox);
            this.setupTabPage.Controls.Add(this.flashRecoveryGroupBox);
            this.setupTabPage.Controls.Add(this.unlockBootloaderGroupBox);
            this.setupTabPage.HorizontalScrollbarBarColor = true;
            this.setupTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.setupTabPage.HorizontalScrollbarSize = 10;
            this.setupTabPage.Location = new System.Drawing.Point(4, 38);
            this.setupTabPage.Name = "setupTabPage";
            this.setupTabPage.Size = new System.Drawing.Size(347, 165);
            this.setupTabPage.TabIndex = 0;
            this.setupTabPage.Text = "Setup";
            this.setupTabPage.VerticalScrollbarBarColor = true;
            this.setupTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.setupTabPage.VerticalScrollbarSize = 10;
            // 
            // otherGroupBox
            // 
            this.otherGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otherGroupBox.Controls.Add(this.helpButton);
            this.otherGroupBox.Controls.Add(this.donateButton);
            this.otherGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.otherGroupBox.Location = new System.Drawing.Point(248, 88);
            this.otherGroupBox.Name = "otherGroupBox";
            this.otherGroupBox.Size = new System.Drawing.Size(99, 77);
            this.otherGroupBox.TabIndex = 63;
            this.otherGroupBox.TabStop = false;
            this.otherGroupBox.Text = "Other";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(6, 19);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(87, 23);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseSelectable = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // donateButton
            // 
            this.donateButton.Location = new System.Drawing.Point(6, 48);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(87, 23);
            this.donateButton.TabIndex = 4;
            this.donateButton.Text = "Donate";
            this.donateButton.UseSelectable = true;
            this.donateButton.UseStyleColors = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // flashGroupBox
            // 
            this.flashGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flashGroupBox.Controls.Add(this.flashKernelButton);
            this.flashGroupBox.Controls.Add(this.flashROMButton);
            this.flashGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flashGroupBox.Location = new System.Drawing.Point(248, 5);
            this.flashGroupBox.Name = "flashGroupBox";
            this.flashGroupBox.Size = new System.Drawing.Size(99, 77);
            this.flashGroupBox.TabIndex = 6;
            this.flashGroupBox.TabStop = false;
            this.flashGroupBox.Text = "Flash";
            // 
            // flashKernelButton
            // 
            this.flashKernelButton.Location = new System.Drawing.Point(6, 48);
            this.flashKernelButton.Name = "flashKernelButton";
            this.flashKernelButton.Size = new System.Drawing.Size(87, 23);
            this.flashKernelButton.TabIndex = 4;
            this.flashKernelButton.Text = "Flash Kernel";
            this.flashKernelButton.UseSelectable = true;
            this.flashKernelButton.Click += new System.EventHandler(this.flashKernelButton_Click);
            // 
            // flashROMButton
            // 
            this.flashROMButton.Location = new System.Drawing.Point(6, 19);
            this.flashROMButton.Name = "flashROMButton";
            this.flashROMButton.Size = new System.Drawing.Size(87, 23);
            this.flashROMButton.TabIndex = 3;
            this.flashROMButton.Text = "Flash ROM";
            this.flashROMButton.UseSelectable = true;
            this.flashROMButton.Click += new System.EventHandler(this.flashROMButton_Click);
            // 
            // gainRootGroupBox
            // 
            this.gainRootGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gainRootGroupBox.Controls.Add(this.flashSuperSUButton);
            this.gainRootGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gainRootGroupBox.Location = new System.Drawing.Point(0, 117);
            this.gainRootGroupBox.Name = "gainRootGroupBox";
            this.gainRootGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gainRootGroupBox.Size = new System.Drawing.Size(121, 48);
            this.gainRootGroupBox.TabIndex = 5;
            this.gainRootGroupBox.TabStop = false;
            this.gainRootGroupBox.Text = "3. Gain Root";
            // 
            // flashSuperSUButton
            // 
            this.flashSuperSUButton.Location = new System.Drawing.Point(6, 19);
            this.flashSuperSUButton.Name = "flashSuperSUButton";
            this.flashSuperSUButton.Size = new System.Drawing.Size(109, 23);
            this.flashSuperSUButton.TabIndex = 5;
            this.flashSuperSUButton.Text = "Flash SuperSU";
            this.flashSuperSUButton.UseSelectable = true;
            this.flashSuperSUButton.Click += new System.EventHandler(this.flashSuperSUButton_Click);
            // 
            // flashRecoveryGroupBox
            // 
            this.flashRecoveryGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flashRecoveryGroupBox.Controls.Add(this.secondRecoveriesGroupBox);
            this.flashRecoveryGroupBox.Controls.Add(this.firstRecoveriesGroupBox);
            this.flashRecoveryGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flashRecoveryGroupBox.Location = new System.Drawing.Point(127, 5);
            this.flashRecoveryGroupBox.Name = "flashRecoveryGroupBox";
            this.flashRecoveryGroupBox.Size = new System.Drawing.Size(115, 160);
            this.flashRecoveryGroupBox.TabIndex = 4;
            this.flashRecoveryGroupBox.TabStop = false;
            this.flashRecoveryGroupBox.Text = "2. Flash Recovery";
            // 
            // secondRecoveriesGroupBox
            // 
            this.secondRecoveriesGroupBox.Controls.Add(this.secondTWRPButton);
            this.secondRecoveriesGroupBox.Controls.Add(this.thirdTWRPButton);
            this.secondRecoveriesGroupBox.Location = new System.Drawing.Point(6, 73);
            this.secondRecoveriesGroupBox.Name = "secondRecoveriesGroupBox";
            this.secondRecoveriesGroupBox.Size = new System.Drawing.Size(103, 77);
            this.secondRecoveriesGroupBox.TabIndex = 6;
            this.secondRecoveriesGroupBox.TabStop = false;
            this.secondRecoveriesGroupBox.Text = "Other";
            // 
            // secondTWRPButton
            // 
            this.secondTWRPButton.Enabled = false;
            this.secondTWRPButton.Location = new System.Drawing.Point(6, 19);
            this.secondTWRPButton.Name = "secondTWRPButton";
            this.secondTWRPButton.Size = new System.Drawing.Size(91, 23);
            this.secondTWRPButton.TabIndex = 4;
            this.secondTWRPButton.Text = "TWRP";
            this.secondTWRPButton.UseSelectable = true;
            this.secondTWRPButton.Click += new System.EventHandler(this.secondTWRPButton_Click);
            // 
            // thirdTWRPButton
            // 
            this.thirdTWRPButton.Enabled = false;
            this.thirdTWRPButton.Location = new System.Drawing.Point(6, 48);
            this.thirdTWRPButton.Name = "thirdTWRPButton";
            this.thirdTWRPButton.Size = new System.Drawing.Size(91, 23);
            this.thirdTWRPButton.TabIndex = 5;
            this.thirdTWRPButton.Text = "CWM";
            this.thirdTWRPButton.UseSelectable = true;
            this.thirdTWRPButton.Click += new System.EventHandler(this.thirdTWRPButton_Click);
            // 
            // firstRecoveriesGroupBox
            // 
            this.firstRecoveriesGroupBox.Controls.Add(this.firstTWRPButton);
            this.firstRecoveriesGroupBox.Location = new System.Drawing.Point(6, 19);
            this.firstRecoveriesGroupBox.Name = "firstRecoveriesGroupBox";
            this.firstRecoveriesGroupBox.Size = new System.Drawing.Size(103, 48);
            this.firstRecoveriesGroupBox.TabIndex = 1;
            this.firstRecoveriesGroupBox.TabStop = false;
            this.firstRecoveriesGroupBox.Text = "Option One";
            // 
            // firstTWRPButton
            // 
            this.firstTWRPButton.Enabled = false;
            this.firstTWRPButton.Location = new System.Drawing.Point(6, 19);
            this.firstTWRPButton.Name = "firstTWRPButton";
            this.firstTWRPButton.Size = new System.Drawing.Size(91, 23);
            this.firstTWRPButton.TabIndex = 4;
            this.firstTWRPButton.Text = "TWRP";
            this.firstTWRPButton.UseSelectable = true;
            this.firstTWRPButton.Click += new System.EventHandler(this.firstTWRPButton_Click);
            // 
            // unlockBootloaderGroupBox
            // 
            this.unlockBootloaderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.unlockBootloaderGroupBox.Controls.Add(this.gainSuperCIDButton);
            this.unlockBootloaderGroupBox.Controls.Add(this.unlockBootloaderButton);
            this.unlockBootloaderGroupBox.Controls.Add(this.getTokenIDButton);
            this.unlockBootloaderGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unlockBootloaderGroupBox.Location = new System.Drawing.Point(0, 5);
            this.unlockBootloaderGroupBox.Name = "unlockBootloaderGroupBox";
            this.unlockBootloaderGroupBox.Size = new System.Drawing.Size(121, 106);
            this.unlockBootloaderGroupBox.TabIndex = 3;
            this.unlockBootloaderGroupBox.TabStop = false;
            this.unlockBootloaderGroupBox.Text = "1. Unlock Bootloader";
            // 
            // gainSuperCIDButton
            // 
            this.gainSuperCIDButton.Enabled = false;
            this.gainSuperCIDButton.Location = new System.Drawing.Point(6, 19);
            this.gainSuperCIDButton.Name = "gainSuperCIDButton";
            this.gainSuperCIDButton.Size = new System.Drawing.Size(109, 23);
            this.gainSuperCIDButton.TabIndex = 5;
            this.gainSuperCIDButton.Text = "Gain SuperCID";
            this.gainSuperCIDButton.UseSelectable = true;
            this.gainSuperCIDButton.Click += new System.EventHandler(this.gainSuperCIDButton_Click);
            // 
            // unlockBootloaderButton
            // 
            this.unlockBootloaderButton.Location = new System.Drawing.Point(6, 77);
            this.unlockBootloaderButton.Name = "unlockBootloaderButton";
            this.unlockBootloaderButton.Size = new System.Drawing.Size(109, 23);
            this.unlockBootloaderButton.TabIndex = 4;
            this.unlockBootloaderButton.Text = "Unlock Bootloader";
            this.unlockBootloaderButton.UseSelectable = true;
            this.unlockBootloaderButton.Click += new System.EventHandler(this.unlockBootloaderButton_Click);
            // 
            // getTokenIDButton
            // 
            this.getTokenIDButton.Location = new System.Drawing.Point(6, 48);
            this.getTokenIDButton.Name = "getTokenIDButton";
            this.getTokenIDButton.Size = new System.Drawing.Size(109, 23);
            this.getTokenIDButton.TabIndex = 3;
            this.getTokenIDButton.Text = "Get Token ID";
            this.getTokenIDButton.UseSelectable = true;
            this.getTokenIDButton.Click += new System.EventHandler(this.getTokenIDButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.setupTabPage);
            this.mainTabControl.Controls.Add(this.adbTabPage);
            this.mainTabControl.Controls.Add(this.fastbootTabPage);
            this.mainTabControl.Controls.Add(this.aboutTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(23, 63);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 3;
            this.mainTabControl.Size = new System.Drawing.Size(355, 207);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(27, 272);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(347, 3);
            this.metroTile1.TabIndex = 68;
            this.metroTile1.UseSelectable = true;
            // 
            // refreshSpinner
            // 
            this.refreshSpinner.Location = new System.Drawing.Point(306, 278);
            this.refreshSpinner.Maximum = 100;
            this.refreshSpinner.Name = "refreshSpinner";
            this.refreshSpinner.Size = new System.Drawing.Size(19, 19);
            this.refreshSpinner.TabIndex = 83;
            this.refreshSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refreshSpinner.UseSelectable = true;
            this.refreshSpinner.Value = 50;
            this.refreshSpinner.Visible = false;
            // 
            // statusProgressSpinner
            // 
            this.statusProgressSpinner.Location = new System.Drawing.Point(74, 283);
            this.statusProgressSpinner.Maximum = 100;
            this.statusProgressSpinner.Name = "statusProgressSpinner";
            this.statusProgressSpinner.Size = new System.Drawing.Size(12, 12);
            this.statusProgressSpinner.TabIndex = 82;
            this.statusProgressSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.statusProgressSpinner.UseSelectable = true;
            this.statusProgressSpinner.Value = 50;
            // 
            // deviceProgressSpinner
            // 
            this.deviceProgressSpinner.Location = new System.Drawing.Point(139, 283);
            this.deviceProgressSpinner.Maximum = 100;
            this.deviceProgressSpinner.Name = "deviceProgressSpinner";
            this.deviceProgressSpinner.Size = new System.Drawing.Size(12, 12);
            this.deviceProgressSpinner.TabIndex = 81;
            this.deviceProgressSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deviceProgressSpinner.UseSelectable = true;
            this.deviceProgressSpinner.Value = 50;
            // 
            // reloadButton
            // 
            this.reloadButton.Enabled = false;
            this.reloadButton.Location = new System.Drawing.Point(331, 278);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(43, 19);
            this.reloadButton.TabIndex = 80;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseSelectable = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.statusLabel.Location = new System.Drawing.Point(90, 278);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 19);
            this.statusLabel.TabIndex = 79;
            this.statusLabel.Text = "Status:";
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.deviceLabel.Location = new System.Drawing.Point(23, 278);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(52, 19);
            this.deviceLabel.TabIndex = 78;
            this.deviceLabel.Text = "Device:";
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Location = new System.Drawing.Point(17, 26);
            this.loadingSpinner.Maximum = 100;
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(24, 24);
            this.loadingSpinner.TabIndex = 84;
            this.loadingSpinner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loadingSpinner.UseSelectable = true;
            this.loadingSpinner.Value = 50;
            this.loadingSpinner.Visible = false;
            // 
            // deviceRecognition
            // 
            this.deviceRecognition.WorkerSupportsCancellation = true;
            this.deviceRecognition.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deviceRecognition_DoWork);
            // 
            // noReturnADBCommand
            // 
            this.noReturnADBCommand.WorkerSupportsCancellation = true;
            this.noReturnADBCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.noReturnADBCommand_DoWork);
            this.noReturnADBCommand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.noReturnADBCommand_RunWorkerCompleted);
            // 
            // noReturnFastbootCommand
            // 
            this.noReturnFastbootCommand.WorkerSupportsCancellation = true;
            this.noReturnFastbootCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.noReturnFastbootCommand_DoWork);
            this.noReturnFastbootCommand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.noReturnFastbootCommand_RunWorkerCompleted);
            // 
            // adbCommand
            // 
            this.adbCommand.WorkerSupportsCancellation = true;
            this.adbCommand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.adbCommand_DoWork);
            this.adbCommand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.adbCommand_RunWorkerCompleted);
            // 
            // pushFile
            // 
            this.pushFile.WorkerSupportsCancellation = true;
            this.pushFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pushFile_DoWork);
            // 
            // installApp
            // 
            this.installApp.WorkerSupportsCancellation = true;
            this.installApp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.installApp_DoWork);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tokenID
            // 
            this.tokenID.WorkerSupportsCancellation = true;
            this.tokenID.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tokenID_DoWork);
            // 
            // getLogcat
            // 
            this.getLogcat.WorkerSupportsCancellation = true;
            this.getLogcat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getLogcat_DoWork);
            // 
            // getDmesg
            // 
            this.getDmesg.WorkerSupportsCancellation = true;
            this.getDmesg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getDmesg_DoWork);
            // 
            // getFastbootInfo
            // 
            this.getFastbootInfo.WorkerSupportsCancellation = true;
            this.getFastbootInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getFastbootInfo_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 306);
            this.Controls.Add(this.loadingSpinner);
            this.Controls.Add(this.refreshSpinner);
            this.Controls.Add(this.statusProgressSpinner);
            this.Controls.Add(this.deviceProgressSpinner);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "WinDroid Universal HTC Toolkit";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            this.choosePhoneGroupBox.ResumeLayout(false);
            this.contactGroupBox.ResumeLayout(false);
            this.fastbootTabPage.ResumeLayout(false);
            this.permanentFlashGroupBox.ResumeLayout(false);
            this.bootloaderGroupBox.ResumeLayout(false);
            this.fastbootInformationGroupBox.ResumeLayout(false);
            this.temporaryFastbootGroupBox.ResumeLayout(false);
            this.rebootFastbootGroupBox.ResumeLayout(false);
            this.adbTabPage.ResumeLayout(false);
            this.logsGroupBox.ResumeLayout(false);
            this.backupsGroupBox.ResumeLayout(false);
            this.appsGroupBox.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.sideloadROMGroupBox.ResumeLayout(false);
            this.rebootADBGroupBox.ResumeLayout(false);
            this.setupTabPage.ResumeLayout(false);
            this.otherGroupBox.ResumeLayout(false);
            this.flashGroupBox.ResumeLayout(false);
            this.gainRootGroupBox.ResumeLayout(false);
            this.flashRecoveryGroupBox.ResumeLayout(false);
            this.secondRecoveriesGroupBox.ResumeLayout(false);
            this.firstRecoveriesGroupBox.ResumeLayout(false);
            this.unlockBootloaderGroupBox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage aboutTabPage;
        private System.Windows.Forms.GroupBox choosePhoneGroupBox;
        private MetroFramework.Controls.MetroTile donateTile;
        private MetroFramework.Controls.MetroTile helpTile;
        private MetroFramework.Controls.MetroTile requestsTile;
        private MetroFramework.Controls.MetroLabel winDroidLabel;
        private MetroFramework.Controls.MetroTabPage fastbootTabPage;
        private System.Windows.Forms.GroupBox bootloaderGroupBox;
        private MetroFramework.Controls.MetroButton relockBootloaderButton;
        private System.Windows.Forms.GroupBox fastbootInformationGroupBox;
        private MetroFramework.Controls.MetroButton getMIDButton;
        private MetroFramework.Controls.MetroButton getIMEIButton;
        private MetroFramework.Controls.MetroButton getSerialNumberButton;
        private MetroFramework.Controls.MetroButton getCIDButton;
        private MetroFramework.Controls.MetroTextBox fastbootInformationTextBox;
        private System.Windows.Forms.GroupBox temporaryFastbootGroupBox;
        private MetroFramework.Controls.MetroButton temporaryKernelButton;
        private MetroFramework.Controls.MetroButton temporaryRecoveryButton;
        private System.Windows.Forms.GroupBox rebootFastbootGroupBox;
        private MetroFramework.Controls.MetroButton rebootFromBootloaderButton;
        private MetroFramework.Controls.MetroButton rebootToBootloaderButton;
        private MetroFramework.Controls.MetroTabPage adbTabPage;
        private System.Windows.Forms.GroupBox logsGroupBox;
        private MetroFramework.Controls.MetroButton dmesgButton;
        private MetroFramework.Controls.MetroButton logcatButton;
        private System.Windows.Forms.GroupBox backupsGroupBox;
        private MetroFramework.Controls.MetroButton restoreButton;
        private MetroFramework.Controls.MetroButton backupButton;
        private System.Windows.Forms.GroupBox appsGroupBox;
        private MetroFramework.Controls.MetroButton uninstallAppButton;
        private MetroFramework.Controls.MetroButton installAppButton;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private MetroFramework.Controls.MetroButton pullFilesButton;
        private MetroFramework.Controls.MetroButton pushFilesButton;
        private System.Windows.Forms.GroupBox sideloadROMGroupBox;
        private MetroFramework.Controls.MetroButton sideloadROMButton;
        private System.Windows.Forms.GroupBox rebootADBGroupBox;
        private MetroFramework.Controls.MetroButton rebootBootloaderButton;
        private MetroFramework.Controls.MetroButton rebootRecoveryButton;
        private MetroFramework.Controls.MetroButton rebootButton;
        private MetroFramework.Controls.MetroTabPage setupTabPage;
        private System.Windows.Forms.GroupBox otherGroupBox;
        private MetroFramework.Controls.MetroButton helpButton;
        private MetroFramework.Controls.MetroButton donateButton;
        private System.Windows.Forms.GroupBox flashGroupBox;
        private MetroFramework.Controls.MetroButton flashKernelButton;
        private MetroFramework.Controls.MetroButton flashROMButton;
        private System.Windows.Forms.GroupBox gainRootGroupBox;
        private MetroFramework.Controls.MetroButton flashSuperSUButton;
        private System.Windows.Forms.GroupBox flashRecoveryGroupBox;
        private System.Windows.Forms.GroupBox secondRecoveriesGroupBox;
        public MetroFramework.Controls.MetroButton secondTWRPButton;
        private MetroFramework.Controls.MetroButton thirdTWRPButton;
        private System.Windows.Forms.GroupBox firstRecoveriesGroupBox;
        private System.Windows.Forms.GroupBox unlockBootloaderGroupBox;
        public MetroFramework.Controls.MetroButton gainSuperCIDButton;
        private MetroFramework.Controls.MetroButton unlockBootloaderButton;
        private MetroFramework.Controls.MetroButton getTokenIDButton;
        private MetroFramework.Controls.MetroTabControl mainTabControl;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroProgressSpinner refreshSpinner;
        private MetroFramework.Controls.MetroProgressSpinner statusProgressSpinner;
        private MetroFramework.Controls.MetroProgressSpinner deviceProgressSpinner;
        private MetroFramework.Controls.MetroButton reloadButton;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel deviceLabel;
        private MetroFramework.Controls.MetroProgressSpinner loadingSpinner;
        private System.ComponentModel.BackgroundWorker deviceRecognition;
        private System.ComponentModel.BackgroundWorker noReturnADBCommand;
        private System.ComponentModel.BackgroundWorker noReturnFastbootCommand;
        public System.ComponentModel.BackgroundWorker adbCommand;
        private System.ComponentModel.BackgroundWorker pushFile;
        private System.ComponentModel.BackgroundWorker installApp;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker tokenID;
        private System.ComponentModel.BackgroundWorker getLogcat;
        private System.ComponentModel.BackgroundWorker getDmesg;
        private System.ComponentModel.BackgroundWorker getFastbootInfo;
        public MetroFramework.Controls.MetroComboBox changePhoneComboBox;
        public MetroFramework.Controls.MetroButton firstTWRPButton;
        private System.Windows.Forms.GroupBox contactGroupBox;
        private MetroFramework.Controls.MetroButton xdaButton;
        private MetroFramework.Controls.MetroButton twitterButton;
        private MetroFramework.Controls.MetroButton emailButton;
        private System.Windows.Forms.GroupBox permanentFlashGroupBox;
        private MetroFramework.Controls.MetroButton permanentRecoveryButton;

    }
}

