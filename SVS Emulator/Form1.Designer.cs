namespace SVS_Emulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PegasoTeConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectLed = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.PegasoTeConnectPortLabel = new System.Windows.Forms.Label();
            this.IpPort = new System.Windows.Forms.TextBox();
            this.PegasoTeConnectIpAddrLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Address = new IPAddressControlLib.IPAddressControl();
            this.ARTLogPictureBox = new System.Windows.Forms.PictureBox();
            this.selectedCamera = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.disableKA = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboCommand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboParameters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSendType6 = new System.Windows.Forms.Button();
            this.comboBattleShort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboHatches = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTurretAngle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SX_AP_label = new System.Windows.Forms.Label();
            this.SX_AP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SX_MP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SX_HE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DX_AP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DX_MP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DX_HE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HatchStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DoorsStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CrankStatus = new System.Windows.Forms.TextBox();
            this.message_counter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PegasoTeConnectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTLogPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PegasoTeConnectGroupBox
            // 
            this.PegasoTeConnectGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PegasoTeConnectGroupBox.Controls.Add(this.ConnectLed);
            this.PegasoTeConnectGroupBox.Controls.Add(this.PegasoTeConnectPortLabel);
            this.PegasoTeConnectGroupBox.Controls.Add(this.IpPort);
            this.PegasoTeConnectGroupBox.Controls.Add(this.PegasoTeConnectIpAddrLabel);
            this.PegasoTeConnectGroupBox.Controls.Add(this.ConnectButton);
            this.PegasoTeConnectGroupBox.Controls.Add(this.Address);
            this.PegasoTeConnectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PegasoTeConnectGroupBox.Location = new System.Drawing.Point(20, 28);
            this.PegasoTeConnectGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PegasoTeConnectGroupBox.Name = "PegasoTeConnectGroupBox";
            this.PegasoTeConnectGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PegasoTeConnectGroupBox.Size = new System.Drawing.Size(530, 262);
            this.PegasoTeConnectGroupBox.TabIndex = 26;
            this.PegasoTeConnectGroupBox.TabStop = false;
            this.PegasoTeConnectGroupBox.Text = "CONNECTION";
            // 
            // ConnectLed
            // 
            this.ConnectLed.BackColor = System.Drawing.Color.Transparent;
            this.ConnectLed.BlinkInterval = 500;
            this.ConnectLed.Label = "";
            this.ConnectLed.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.ConnectLed.LedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectLed.LedSize = new System.Drawing.SizeF(30F, 30F);
            this.ConnectLed.Location = new System.Drawing.Point(38, 55);
            this.ConnectLed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConnectLed.Name = "ConnectLed";
            this.ConnectLed.Renderer = null;
            this.ConnectLed.Size = new System.Drawing.Size(69, 49);
            this.ConnectLed.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.ConnectLed.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.ConnectLed.TabIndex = 29;
            // 
            // PegasoTeConnectPortLabel
            // 
            this.PegasoTeConnectPortLabel.AutoSize = true;
            this.PegasoTeConnectPortLabel.Location = new System.Drawing.Point(33, 208);
            this.PegasoTeConnectPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PegasoTeConnectPortLabel.Name = "PegasoTeConnectPortLabel";
            this.PegasoTeConnectPortLabel.Size = new System.Drawing.Size(71, 20);
            this.PegasoTeConnectPortLabel.TabIndex = 28;
            this.PegasoTeConnectPortLabel.Text = "PORT :";
            // 
            // IpPort
            // 
            this.IpPort.Location = new System.Drawing.Point(183, 203);
            this.IpPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IpPort.Name = "IpPort";
            this.IpPort.Size = new System.Drawing.Size(100, 26);
            this.IpPort.TabIndex = 27;
            // 
            // PegasoTeConnectIpAddrLabel
            // 
            this.PegasoTeConnectIpAddrLabel.AutoSize = true;
            this.PegasoTeConnectIpAddrLabel.Location = new System.Drawing.Point(33, 146);
            this.PegasoTeConnectIpAddrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PegasoTeConnectIpAddrLabel.Name = "PegasoTeConnectIpAddrLabel";
            this.PegasoTeConnectIpAddrLabel.Size = new System.Drawing.Size(133, 20);
            this.PegasoTeConnectIpAddrLabel.TabIndex = 26;
            this.PegasoTeConnectIpAddrLabel.Text = "IP ADDRESS :";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(183, 55);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(192, 49);
            this.ConnectButton.TabIndex = 25;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Address
            // 
            this.Address.AllowInternalTab = false;
            this.Address.AutoHeight = true;
            this.Address.BackColor = System.Drawing.SystemColors.Window;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Location = new System.Drawing.Point(183, 140);
            this.Address.Margin = new System.Windows.Forms.Padding(6);
            this.Address.MinimumSize = new System.Drawing.Size(138, 26);
            this.Address.Name = "Address";
            this.Address.ReadOnly = false;
            this.Address.Size = new System.Drawing.Size(184, 26);
            this.Address.TabIndex = 0;
            this.Address.Text = "...";
            // 
            // ARTLogPictureBox
            // 
            this.ARTLogPictureBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.ARTLogPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ARTLogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ARTLogPictureBox.Image")));
            this.ARTLogPictureBox.Location = new System.Drawing.Point(1009, 22);
            this.ARTLogPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ARTLogPictureBox.Name = "ARTLogPictureBox";
            this.ARTLogPictureBox.Size = new System.Drawing.Size(258, 132);
            this.ARTLogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ARTLogPictureBox.TabIndex = 27;
            this.ARTLogPictureBox.TabStop = false;
            // 
            // selectedCamera
            // 
            this.selectedCamera.Location = new System.Drawing.Point(44, 106);
            this.selectedCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectedCamera.Name = "selectedCamera";
            this.selectedCamera.Size = new System.Drawing.Size(96, 26);
            this.selectedCamera.TabIndex = 29;
            this.selectedCamera.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(328, 112);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(247, 20);
            this.label.TabIndex = 30;
            this.label.Text = "SELECTED CAMERA (HEX)";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(483, 291);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(190, 35);
            this.sendButton.TabIndex = 31;
            this.sendButton.Text = "SEND COMMAND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "MESSAGE TYPE";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "KEEP ALIVE",
            "IMMAGINE SINGOLA",
            "IMMAGINE ELABORATA",
            "RUN SCORRIMENTO",
            "RESET TV CAMERE",
            "CONFIGURAZIONE TV CAMERA",
            "STATUS TV CAMERA"});
            this.comboType.Location = new System.Drawing.Point(45, 45);
            this.comboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(259, 28);
            this.comboType.TabIndex = 34;
            // 
            // textLog
            // 
            this.textLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(20, 605);
            this.textLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(529, 304);
            this.textLog.TabIndex = 35;
            // 
            // disableKA
            // 
            this.disableKA.AutoSize = true;
            this.disableKA.Location = new System.Drawing.Point(571, 42);
            this.disableKA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disableKA.Name = "disableKA";
            this.disableKA.Size = new System.Drawing.Size(163, 24);
            this.disableKA.TabIndex = 36;
            this.disableKA.Text = "disable Keep Alive";
            this.disableKA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 874);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboCommand
            // 
            this.comboCommand.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboCommand.FormattingEnabled = true;
            this.comboCommand.Items.AddRange(new object[] {
            "NULL",
            "POLARITY CHANGE",
            "ROI SELECTION",
            "DAY/NIGHT"});
            this.comboCommand.Location = new System.Drawing.Point(45, 171);
            this.comboCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCommand.Name = "comboCommand";
            this.comboCommand.Size = new System.Drawing.Size(202, 28);
            this.comboCommand.TabIndex = 39;
            this.comboCommand.SelectedIndexChanged += new System.EventHandler(this.comboCommand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "COMMAND";
            // 
            // comboParameters
            // 
            this.comboParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboParameters.FormattingEnabled = true;
            this.comboParameters.Items.AddRange(new object[] {
            "NULL"});
            this.comboParameters.Location = new System.Drawing.Point(45, 237);
            this.comboParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboParameters.Name = "comboParameters";
            this.comboParameters.Size = new System.Drawing.Size(168, 28);
            this.comboParameters.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "PARAMETERS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboParameters);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboCommand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.selectedCamera);
            this.groupBox1.Location = new System.Drawing.Point(571, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(696, 343);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TYPE 4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSendType6);
            this.groupBox2.Controls.Add(this.comboBattleShort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboHatches);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textTurretAngle);
            this.groupBox2.Location = new System.Drawing.Point(20, 300);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(530, 285);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TYPE 6 - sent by Cruscotto";
            // 
            // buttonSendType6
            // 
            this.buttonSendType6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendType6.Location = new System.Drawing.Point(318, 226);
            this.buttonSendType6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSendType6.Name = "buttonSendType6";
            this.buttonSendType6.Size = new System.Drawing.Size(190, 35);
            this.buttonSendType6.TabIndex = 42;
            this.buttonSendType6.Text = "SEND COMMAND";
            this.buttonSendType6.UseVisualStyleBackColor = true;
            this.buttonSendType6.Click += new System.EventHandler(this.buttonSendType6_Click);
            // 
            // comboBattleShort
            // 
            this.comboBattleShort.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBattleShort.FormattingEnabled = true;
            this.comboBattleShort.Items.AddRange(new object[] {
            "BATTLE SHORT NOT REQUIRED",
            "BATTLE SHORT REQUIRED"});
            this.comboBattleShort.Location = new System.Drawing.Point(45, 160);
            this.comboBattleShort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBattleShort.Name = "comboBattleShort";
            this.comboBattleShort.Size = new System.Drawing.Size(222, 28);
            this.comboBattleShort.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "BATTLE SHORT STATUS";
            // 
            // comboHatches
            // 
            this.comboHatches.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboHatches.FormattingEnabled = true;
            this.comboHatches.Items.AddRange(new object[] {
            "HATCHES CLOSED",
            "LEFT CLOSED - RIGHT OPENED",
            "LEFT OPENED - RIGHT CLOSED",
            "HATCHES OPENED"});
            this.comboHatches.Location = new System.Drawing.Point(45, 100);
            this.comboHatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboHatches.Name = "comboHatches";
            this.comboHatches.Size = new System.Drawing.Size(236, 28);
            this.comboHatches.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "HATCHES STATUS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "TURRET ANGLE (HEX)";
            // 
            // textTurretAngle
            // 
            this.textTurretAngle.Location = new System.Drawing.Point(45, 45);
            this.textTurretAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTurretAngle.Name = "textTurretAngle";
            this.textTurretAngle.Size = new System.Drawing.Size(96, 26);
            this.textTurretAngle.TabIndex = 29;
            this.textTurretAngle.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SX_AP_label);
            this.groupBox3.Controls.Add(this.SX_AP);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.SX_MP);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.SX_HE);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.DX_AP);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.DX_MP);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DX_HE);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.HatchStatus);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.DoorsStatus);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BatteryStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.CrankStatus);
            this.groupBox3.Location = new System.Drawing.Point(571, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 340);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CRUSCOTTO RX";
            // 
            // SX_AP_label
            // 
            this.SX_AP_label.AutoSize = true;
            this.SX_AP_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.SX_AP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SX_AP_label.Location = new System.Drawing.Point(526, 289);
            this.SX_AP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SX_AP_label.Name = "SX_AP_label";
            this.SX_AP_label.Size = new System.Drawing.Size(156, 20);
            this.SX_AP_label.TabIndex = 57;
            this.SX_AP_label.Text = "Riservetta SX-AP";
            // 
            // SX_AP
            // 
            this.SX_AP.Location = new System.Drawing.Point(386, 286);
            this.SX_AP.Name = "SX_AP";
            this.SX_AP.Size = new System.Drawing.Size(135, 26);
            this.SX_AP.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(524, 231);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Riservetta SX-MP";
            // 
            // SX_MP
            // 
            this.SX_MP.Location = new System.Drawing.Point(384, 228);
            this.SX_MP.Name = "SX_MP";
            this.SX_MP.Size = new System.Drawing.Size(135, 26);
            this.SX_MP.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 169);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Riservetta SX-HE";
            // 
            // SX_HE
            // 
            this.SX_HE.Location = new System.Drawing.Point(384, 166);
            this.SX_HE.Name = "SX_HE";
            this.SX_HE.Size = new System.Drawing.Size(135, 26);
            this.SX_HE.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(524, 110);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 20);
            this.label15.TabIndex = 51;
            this.label15.Text = "Riservetta DX-AP";
            // 
            // DX_AP
            // 
            this.DX_AP.Location = new System.Drawing.Point(384, 107);
            this.DX_AP.Name = "DX_AP";
            this.DX_AP.Size = new System.Drawing.Size(135, 26);
            this.DX_AP.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(524, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 20);
            this.label16.TabIndex = 49;
            this.label16.Text = "Riservetta DX-MP";
            // 
            // DX_MP
            // 
            this.DX_MP.Location = new System.Drawing.Point(384, 51);
            this.DX_MP.Name = "DX_MP";
            this.DX_MP.Size = new System.Drawing.Size(135, 26);
            this.DX_MP.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Riservetta DX-HE";
            // 
            // DX_HE
            // 
            this.DX_HE.Location = new System.Drawing.Point(21, 286);
            this.DX_HE.Name = "DX_HE";
            this.DX_HE.Size = new System.Drawing.Size(135, 26);
            this.DX_HE.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(159, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Hatch Status";
            // 
            // HatchStatus
            // 
            this.HatchStatus.Location = new System.Drawing.Point(19, 228);
            this.HatchStatus.Name = "HatchStatus";
            this.HatchStatus.Size = new System.Drawing.Size(135, 26);
            this.HatchStatus.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Doors Status";
            // 
            // DoorsStatus
            // 
            this.DoorsStatus.Location = new System.Drawing.Point(19, 166);
            this.DoorsStatus.Name = "DoorsStatus";
            this.DoorsStatus.Size = new System.Drawing.Size(135, 26);
            this.DoorsStatus.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Battery Status";
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.Location = new System.Drawing.Point(19, 107);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(135, 26);
            this.BatteryStatus.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Crank Status";
            // 
            // CrankStatus
            // 
            this.CrankStatus.Location = new System.Drawing.Point(19, 51);
            this.CrankStatus.Name = "CrankStatus";
            this.CrankStatus.Size = new System.Drawing.Size(135, 26);
            this.CrankStatus.TabIndex = 0;
            // 
            // message_counter
            // 
            this.message_counter.Location = new System.Drawing.Point(957, 878);
            this.message_counter.Name = "message_counter";
            this.message_counter.Size = new System.Drawing.Size(135, 26);
            this.message_counter.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1110, 884);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Message Counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 930);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.message_counter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disableKA);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.ARTLogPictureBox);
            this.Controls.Add(this.PegasoTeConnectGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SVS Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.PegasoTeConnectGroupBox.ResumeLayout(false);
            this.PegasoTeConnectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTLogPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PegasoTeConnectGroupBox;
        private System.Windows.Forms.Label PegasoTeConnectPortLabel;
        private System.Windows.Forms.TextBox IpPort;
        private System.Windows.Forms.Label PegasoTeConnectIpAddrLabel;
        private System.Windows.Forms.Button ConnectButton;
        private IPAddressControlLib.IPAddressControl Address;
        private System.Windows.Forms.PictureBox ARTLogPictureBox;
        private LBSoft.IndustrialCtrls.Leds.LBLed ConnectLed;
        private System.Windows.Forms.TextBox selectedCamera;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.CheckBox disableKA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSendType6;
        private System.Windows.Forms.ComboBox comboBattleShort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboHatches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTurretAngle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SX_AP_label;
        private System.Windows.Forms.TextBox SX_AP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SX_MP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SX_HE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DX_AP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DX_MP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DX_HE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HatchStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DoorsStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BatteryStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CrankStatus;
        private System.Windows.Forms.TextBox message_counter;
        private System.Windows.Forms.Label label12;
    }
}

