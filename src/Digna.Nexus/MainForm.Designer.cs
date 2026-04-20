namespace SmartHomeSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblBaseWatt = new System.Windows.Forms.Label();
            this.numBaseWatt = new System.Windows.Forms.NumericUpDown();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.grpLight = new System.Windows.Forms.GroupBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.btnRemoveLight = new System.Windows.Forms.Button();
            this.grpAC = new System.Windows.Forms.GroupBox();
            this.rbCool = new System.Windows.Forms.RadioButton();
            this.rbHeat = new System.Windows.Forms.RadioButton();
            this.lblTargetTemp = new System.Windows.Forms.Label();
            this.numTargetTemp = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveAC = new System.Windows.Forms.Button();
            this.grpCamera = new System.Windows.Forms.GroupBox();
            this.chkNightVision = new System.Windows.Forms.CheckBox();
            this.chkRecording = new System.Windows.Forms.CheckBox();
            this.btnRemoveCamera = new System.Windows.Forms.Button();
            this.grpSpeaker = new System.Windows.Forms.GroupBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.btnRemoveSpeaker = new System.Windows.Forms.Button();
            this.btnTogglePower = new System.Windows.Forms.Button();
            this.rtbReports = new System.Windows.Forms.RichTextBox();
            this.lblTotalConsumption = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseWatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.grpLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.grpAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetTemp)).BeginInit();
            this.grpCamera.SuspendLayout();
            this.grpSpeaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.menuStrip.ForeColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip.TabIndex = 10;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.menuSeparator,
            this.menuExit});
            this.menuFile.ForeColor = System.Drawing.Color.White;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(116, 22);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(113, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(116, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblAddTitle);
            this.pnlSidebar.Controls.Add(this.lblDeviceName);
            this.pnlSidebar.Controls.Add(this.txtDeviceName);
            this.pnlSidebar.Controls.Add(this.lblBaseWatt);
            this.pnlSidebar.Controls.Add(this.numBaseWatt);
            this.pnlSidebar.Controls.Add(this.lblDeviceType);
            this.pnlSidebar.Controls.Add(this.cmbDeviceType);
            this.pnlSidebar.Controls.Add(this.lblLocation);
            this.pnlSidebar.Controls.Add(this.txtLocation);
            this.pnlSidebar.Controls.Add(this.btnAddDevice);
            this.pnlSidebar.Location = new System.Drawing.Point(12, 36);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 450);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.Location = new System.Drawing.Point(10, 10);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(200, 30);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "DEVICE REGISTRATION";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Location = new System.Drawing.Point(10, 50);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(200, 20);
            this.lblDeviceName.TabIndex = 1;
            this.lblDeviceName.Text = "Device Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(13, 70);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(190, 23);
            this.txtDeviceName.TabIndex = 2;
            // 
            // lblBaseWatt
            // 
            this.lblBaseWatt.Location = new System.Drawing.Point(10, 110);
            this.lblBaseWatt.Name = "lblBaseWatt";
            this.lblBaseWatt.Size = new System.Drawing.Size(200, 20);
            this.lblBaseWatt.TabIndex = 3;
            this.lblBaseWatt.Text = "Base Power (W):";
            // 
            // numBaseWatt
            // 
            this.numBaseWatt.Location = new System.Drawing.Point(13, 130);
            this.numBaseWatt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBaseWatt.Name = "numBaseWatt";
            this.numBaseWatt.Size = new System.Drawing.Size(190, 23);
            this.numBaseWatt.TabIndex = 4;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.Location = new System.Drawing.Point(10, 170);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(200, 20);
            this.lblDeviceType.TabIndex = 5;
            this.lblDeviceType.Text = "Device Category:";
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.Items.AddRange(new object[] {
            "Smart Light",
            "Air Conditioner",
            "Security Camera",
            "Smart Speaker"});
            this.cmbDeviceType.Location = new System.Drawing.Point(13, 190);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(190, 23);
            this.cmbDeviceType.TabIndex = 6;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(10, 230);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(200, 20);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location (Room):";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(13, 250);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(190, 23);
            this.txtLocation.TabIndex = 8;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Location = new System.Drawing.Point(13, 380);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(190, 45);
            this.btnAddDevice.TabIndex = 9;
            this.btnAddDevice.Text = "ADD DEVICE";
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // dgvDevices
            // 
            this.dgvDevices.AllowUserToAddRows = false;
            this.dgvDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgvDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevices.Location = new System.Drawing.Point(245, 36);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.ReadOnly = true;
            this.dgvDevices.RowHeadersVisible = false;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.Size = new System.Drawing.Size(550, 450);
            this.dgvDevices.TabIndex = 1;
            this.dgvDevices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevices_CellValueChanged);
            this.dgvDevices.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDevices_CurrentCellDirtyStateChanged);
            this.dgvDevices.SelectionChanged += new System.EventHandler(this.dgvDevices_SelectionChanged);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.lblSettingsTitle);
            this.pnlSettings.Controls.Add(this.grpLight);
            this.pnlSettings.Controls.Add(this.grpAC);
            this.pnlSettings.Controls.Add(this.grpCamera);
            this.pnlSettings.Controls.Add(this.grpSpeaker);
            this.pnlSettings.Controls.Add(this.btnTogglePower);
            this.pnlSettings.Location = new System.Drawing.Point(810, 36);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(270, 450);
            this.pnlSettings.TabIndex = 2;
            // 
            // lblSettingsTitle
            // 
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSettingsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(250, 30);
            this.lblSettingsTitle.TabIndex = 0;
            this.lblSettingsTitle.Text = "DEVICE SETTINGS";
            // 
            // grpLight
            // 
            this.grpLight.Controls.Add(this.lblBrightness);
            this.grpLight.Controls.Add(this.trkBrightness);
            this.grpLight.Controls.Add(this.btnRemoveLight);
            this.grpLight.ForeColor = System.Drawing.Color.White;
            this.grpLight.Location = new System.Drawing.Point(10, 50);
            this.grpLight.Name = "grpLight";
            this.grpLight.Size = new System.Drawing.Size(248, 130);
            this.grpLight.TabIndex = 1;
            this.grpLight.TabStop = false;
            this.grpLight.Text = "Smart Light Settings";
            this.grpLight.Visible = false;
            // 
            // lblBrightness
            // 
            this.lblBrightness.Location = new System.Drawing.Point(8, 20);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(130, 20);
            this.lblBrightness.TabIndex = 0;
            this.lblBrightness.Text = "Brightness:";
            // 
            // trkBrightness
            // 
            this.trkBrightness.Location = new System.Drawing.Point(8, 40);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(230, 45);
            this.trkBrightness.TabIndex = 1;
            this.trkBrightness.Scroll += new System.EventHandler(this.trkBrightness_Scroll);
            // 
            // btnRemoveLight
            // 
            this.btnRemoveLight.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLight.ForeColor = System.Drawing.Color.White;
            this.btnRemoveLight.Location = new System.Drawing.Point(8, 95);
            this.btnRemoveLight.Name = "btnRemoveLight";
            this.btnRemoveLight.Size = new System.Drawing.Size(230, 28);
            this.btnRemoveLight.TabIndex = 2;
            this.btnRemoveLight.Text = "Remove Device";
            this.btnRemoveLight.UseVisualStyleBackColor = false;
            this.btnRemoveLight.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // grpAC
            // 
            this.grpAC.Controls.Add(this.rbCool);
            this.grpAC.Controls.Add(this.rbHeat);
            this.grpAC.Controls.Add(this.lblTargetTemp);
            this.grpAC.Controls.Add(this.numTargetTemp);
            this.grpAC.Controls.Add(this.btnRemoveAC);
            this.grpAC.ForeColor = System.Drawing.Color.White;
            this.grpAC.Location = new System.Drawing.Point(10, 50);
            this.grpAC.Name = "grpAC";
            this.grpAC.Size = new System.Drawing.Size(248, 150);
            this.grpAC.TabIndex = 2;
            this.grpAC.TabStop = false;
            this.grpAC.Text = "Air Conditioner Settings";
            this.grpAC.Visible = false;
            // 
            // rbCool
            // 
            this.rbCool.Checked = true;
            this.rbCool.Location = new System.Drawing.Point(8, 22);
            this.rbCool.Name = "rbCool";
            this.rbCool.Size = new System.Drawing.Size(110, 24);
            this.rbCool.TabIndex = 0;
            this.rbCool.TabStop = true;
            this.rbCool.Text = "Cooling Mode";
            this.rbCool.CheckedChanged += new System.EventHandler(this.rbCool_CheckedChanged);
            // 
            // rbHeat
            // 
            this.rbHeat.Location = new System.Drawing.Point(128, 22);
            this.rbHeat.Name = "rbHeat";
            this.rbHeat.Size = new System.Drawing.Size(110, 24);
            this.rbHeat.TabIndex = 1;
            this.rbHeat.Text = "Heating Mode";
            this.rbHeat.CheckedChanged += new System.EventHandler(this.rbHeat_CheckedChanged);
            // 
            // lblTargetTemp
            // 
            this.lblTargetTemp.Location = new System.Drawing.Point(8, 55);
            this.lblTargetTemp.Name = "lblTargetTemp";
            this.lblTargetTemp.Size = new System.Drawing.Size(130, 20);
            this.lblTargetTemp.TabIndex = 2;
            this.lblTargetTemp.Text = "Target Temp (°C):";
            // 
            // numTargetTemp
            // 
            this.numTargetTemp.Location = new System.Drawing.Point(160, 53);
            this.numTargetTemp.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTargetTemp.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numTargetTemp.Name = "numTargetTemp";
            this.numTargetTemp.Size = new System.Drawing.Size(55, 23);
            this.numTargetTemp.TabIndex = 3;
            this.numTargetTemp.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numTargetTemp.ValueChanged += new System.EventHandler(this.numTargetTemp_ValueChanged);
            // 
            // btnRemoveAC
            // 
            this.btnRemoveAC.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAC.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAC.Location = new System.Drawing.Point(8, 88);
            this.btnRemoveAC.Name = "btnRemoveAC";
            this.btnRemoveAC.Size = new System.Drawing.Size(230, 28);
            this.btnRemoveAC.TabIndex = 4;
            this.btnRemoveAC.Text = "Remove Device";
            this.btnRemoveAC.UseVisualStyleBackColor = false;
            this.btnRemoveAC.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // grpCamera
            // 
            this.grpCamera.Controls.Add(this.chkNightVision);
            this.grpCamera.Controls.Add(this.chkRecording);
            this.grpCamera.Controls.Add(this.btnRemoveCamera);
            this.grpCamera.ForeColor = System.Drawing.Color.White;
            this.grpCamera.Location = new System.Drawing.Point(10, 50);
            this.grpCamera.Name = "grpCamera";
            this.grpCamera.Size = new System.Drawing.Size(248, 120);
            this.grpCamera.TabIndex = 3;
            this.grpCamera.TabStop = false;
            this.grpCamera.Text = "Security Camera Settings";
            this.grpCamera.Visible = false;
            // 
            // chkNightVision
            // 
            this.chkNightVision.Location = new System.Drawing.Point(8, 22);
            this.chkNightVision.Name = "chkNightVision";
            this.chkNightVision.Size = new System.Drawing.Size(150, 24);
            this.chkNightVision.TabIndex = 0;
            this.chkNightVision.Text = "Night Vision";
            this.chkNightVision.CheckedChanged += new System.EventHandler(this.chkNightVision_CheckedChanged);
            // 
            // chkRecording
            // 
            this.chkRecording.Location = new System.Drawing.Point(8, 50);
            this.chkRecording.Name = "chkRecording";
            this.chkRecording.Size = new System.Drawing.Size(150, 24);
            this.chkRecording.TabIndex = 1;
            this.chkRecording.Text = "Start Recording";
            this.chkRecording.CheckedChanged += new System.EventHandler(this.chkRecording_CheckedChanged);
            // 
            // btnRemoveCamera
            // 
            this.btnRemoveCamera.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCamera.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCamera.Location = new System.Drawing.Point(8, 82);
            this.btnRemoveCamera.Name = "btnRemoveCamera";
            this.btnRemoveCamera.Size = new System.Drawing.Size(230, 28);
            this.btnRemoveCamera.TabIndex = 2;
            this.btnRemoveCamera.Text = "Remove Device";
            this.btnRemoveCamera.UseVisualStyleBackColor = false;
            this.btnRemoveCamera.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // grpSpeaker
            // 
            this.grpSpeaker.Controls.Add(this.lblVolume);
            this.grpSpeaker.Controls.Add(this.trkVolume);
            this.grpSpeaker.Controls.Add(this.btnRemoveSpeaker);
            this.grpSpeaker.ForeColor = System.Drawing.Color.White;
            this.grpSpeaker.Location = new System.Drawing.Point(10, 50);
            this.grpSpeaker.Name = "grpSpeaker";
            this.grpSpeaker.Size = new System.Drawing.Size(248, 130);
            this.grpSpeaker.TabIndex = 4;
            this.grpSpeaker.TabStop = false;
            this.grpSpeaker.Text = "Smart Speaker Settings";
            this.grpSpeaker.Visible = false;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(8, 20);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(130, 20);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume:";
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(8, 40);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(230, 45);
            this.trkVolume.TabIndex = 1;
            this.trkVolume.Scroll += new System.EventHandler(this.trkVolume_Scroll);
            // 
            // btnRemoveSpeaker
            // 
            this.btnRemoveSpeaker.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpeaker.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSpeaker.Location = new System.Drawing.Point(8, 95);
            this.btnRemoveSpeaker.Name = "btnRemoveSpeaker";
            this.btnRemoveSpeaker.Size = new System.Drawing.Size(230, 28);
            this.btnRemoveSpeaker.TabIndex = 2;
            this.btnRemoveSpeaker.Text = "Remove Device";
            this.btnRemoveSpeaker.UseVisualStyleBackColor = false;
            this.btnRemoveSpeaker.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnTogglePower
            // 
            this.btnTogglePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTogglePower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTogglePower.Location = new System.Drawing.Point(10, 380);
            this.btnTogglePower.Name = "btnTogglePower";
            this.btnTogglePower.Size = new System.Drawing.Size(250, 45);
            this.btnTogglePower.TabIndex = 9;
            this.btnTogglePower.Text = "TURN ON";
            this.btnTogglePower.UseVisualStyleBackColor = false;
            this.btnTogglePower.Click += new System.EventHandler(this.btnTogglePower_Click);
            // 
            // rtbReports
            // 
            this.rtbReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.rtbReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReports.ForeColor = System.Drawing.Color.Lime;
            this.rtbReports.Location = new System.Drawing.Point(12, 499);
            this.rtbReports.Name = "rtbReports";
            this.rtbReports.ReadOnly = true;
            this.rtbReports.Size = new System.Drawing.Size(550, 150);
            this.rtbReports.TabIndex = 3;
            this.rtbReports.Text = "";
            // 
            // lblTotalConsumption
            // 
            this.lblTotalConsumption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalConsumption.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalConsumption.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalConsumption.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalConsumption.Location = new System.Drawing.Point(580, 499);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(500, 150);
            this.lblTotalConsumption.TabIndex = 4;
            this.lblTotalConsumption.Text = "0.00 W";
            this.lblTotalConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.BackgroundImage = global::SmartHomeSystem.Properties.Resources.blueprint1;
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.rtbReports);
            this.Controls.Add(this.lblTotalConsumption);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "MainForm";
            this.Text = "Digna.Nexus - Smart Home Management";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseWatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.grpLight.ResumeLayout(false);
            this.grpLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.grpAC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTargetTemp)).EndInit();
            this.grpCamera.ResumeLayout(false);
            this.grpSpeaker.ResumeLayout(false);
            this.grpSpeaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblBaseWatt;
        private System.Windows.Forms.NumericUpDown numBaseWatt;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.GroupBox grpLight;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Button btnRemoveLight;
        private System.Windows.Forms.GroupBox grpAC;
        private System.Windows.Forms.RadioButton rbCool;
        private System.Windows.Forms.RadioButton rbHeat;
        private System.Windows.Forms.Label lblTargetTemp;
        private System.Windows.Forms.NumericUpDown numTargetTemp;
        private System.Windows.Forms.Button btnRemoveAC;
        private System.Windows.Forms.GroupBox grpCamera;
        private System.Windows.Forms.CheckBox chkNightVision;
        private System.Windows.Forms.CheckBox chkRecording;
        private System.Windows.Forms.Button btnRemoveCamera;
        private System.Windows.Forms.GroupBox grpSpeaker;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Button btnRemoveSpeaker;
        private System.Windows.Forms.Button btnTogglePower;
        private System.Windows.Forms.RichTextBox rtbReports;
        private System.Windows.Forms.Label lblTotalConsumption;
    }
}