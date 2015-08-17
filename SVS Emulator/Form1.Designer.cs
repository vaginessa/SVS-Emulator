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
            this.PegasoTeConnectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTLogPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PegasoTeConnectGroupBox
            // 
            this.PegasoTeConnectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PegasoTeConnectGroupBox.Controls.Add(this.ConnectLed);
            this.PegasoTeConnectGroupBox.Controls.Add(this.PegasoTeConnectPortLabel);
            this.PegasoTeConnectGroupBox.Controls.Add(this.IpPort);
            this.PegasoTeConnectGroupBox.Controls.Add(this.PegasoTeConnectIpAddrLabel);
            this.PegasoTeConnectGroupBox.Controls.Add(this.ConnectButton);
            this.PegasoTeConnectGroupBox.Controls.Add(this.Address);
            this.PegasoTeConnectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PegasoTeConnectGroupBox.Location = new System.Drawing.Point(12, 19);
            this.PegasoTeConnectGroupBox.Name = "PegasoTeConnectGroupBox";
            this.PegasoTeConnectGroupBox.Size = new System.Drawing.Size(354, 170);
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
            this.ConnectLed.Location = new System.Drawing.Point(25, 36);
            this.ConnectLed.Name = "ConnectLed";
            this.ConnectLed.Renderer = null;
            this.ConnectLed.Size = new System.Drawing.Size(46, 32);
            this.ConnectLed.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.ConnectLed.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.ConnectLed.TabIndex = 29;
            // 
            // PegasoTeConnectPortLabel
            // 
            this.PegasoTeConnectPortLabel.AutoSize = true;
            this.PegasoTeConnectPortLabel.Location = new System.Drawing.Point(22, 135);
            this.PegasoTeConnectPortLabel.Name = "PegasoTeConnectPortLabel";
            this.PegasoTeConnectPortLabel.Size = new System.Drawing.Size(49, 13);
            this.PegasoTeConnectPortLabel.TabIndex = 28;
            this.PegasoTeConnectPortLabel.Text = "PORT :";
            // 
            // IpPort
            // 
            this.IpPort.Location = new System.Drawing.Point(122, 132);
            this.IpPort.Name = "IpPort";
            this.IpPort.Size = new System.Drawing.Size(68, 20);
            this.IpPort.TabIndex = 27;
            // 
            // PegasoTeConnectIpAddrLabel
            // 
            this.PegasoTeConnectIpAddrLabel.AutoSize = true;
            this.PegasoTeConnectIpAddrLabel.Location = new System.Drawing.Point(22, 95);
            this.PegasoTeConnectIpAddrLabel.Name = "PegasoTeConnectIpAddrLabel";
            this.PegasoTeConnectIpAddrLabel.Size = new System.Drawing.Size(90, 13);
            this.PegasoTeConnectIpAddrLabel.TabIndex = 26;
            this.PegasoTeConnectIpAddrLabel.Text = "IP ADDRESS :";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(122, 36);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(128, 32);
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
            this.Address.Location = new System.Drawing.Point(122, 91);
            this.Address.MinimumSize = new System.Drawing.Size(87, 20);
            this.Address.Name = "Address";
            this.Address.ReadOnly = false;
            this.Address.Size = new System.Drawing.Size(184, 20);
            this.Address.TabIndex = 0;
            this.Address.Text = "...";
            // 
            // ARTLogPictureBox
            // 
            this.ARTLogPictureBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.ARTLogPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ARTLogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ARTLogPictureBox.Image")));
            this.ARTLogPictureBox.Location = new System.Drawing.Point(567, 19);
            this.ARTLogPictureBox.Name = "ARTLogPictureBox";
            this.ARTLogPictureBox.Size = new System.Drawing.Size(205, 60);
            this.ARTLogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ARTLogPictureBox.TabIndex = 27;
            this.ARTLogPictureBox.TabStop = false;
            // 
            // selectedCamera
            // 
            this.selectedCamera.Location = new System.Drawing.Point(29, 69);
            this.selectedCamera.Name = "selectedCamera";
            this.selectedCamera.Size = new System.Drawing.Size(65, 20);
            this.selectedCamera.TabIndex = 29;
            this.selectedCamera.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(183, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(163, 13);
            this.label.TabIndex = 30;
            this.label.Text = "SELECTED CAMERA (HEX)";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(249, 193);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 23);
            this.sendButton.TabIndex = 31;
            this.sendButton.Text = "SEND COMMAND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
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
            this.comboType.Location = new System.Drawing.Point(30, 29);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(174, 21);
            this.comboType.TabIndex = 34;
            // 
            // textLog
            // 
            this.textLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLog.Location = new System.Drawing.Point(13, 398);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(759, 280);
            this.textLog.TabIndex = 35;
            // 
            // disableKA
            // 
            this.disableKA.AutoSize = true;
            this.disableKA.Location = new System.Drawing.Point(393, 41);
            this.disableKA.Name = "disableKA";
            this.disableKA.Size = new System.Drawing.Size(113, 17);
            this.disableKA.TabIndex = 36;
            this.disableKA.Text = "disable Keep Alive";
            this.disableKA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.comboCommand.Location = new System.Drawing.Point(30, 111);
            this.comboCommand.Name = "comboCommand";
            this.comboCommand.Size = new System.Drawing.Size(136, 21);
            this.comboCommand.TabIndex = 39;
            this.comboCommand.SelectedIndexChanged += new System.EventHandler(this.comboCommand_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "COMMAND";
            // 
            // comboParameters
            // 
            this.comboParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboParameters.FormattingEnabled = true;
            this.comboParameters.Items.AddRange(new object[] {
            "NULL"});
            this.comboParameters.Location = new System.Drawing.Point(30, 154);
            this.comboParameters.Name = "comboParameters";
            this.comboParameters.Size = new System.Drawing.Size(113, 21);
            this.comboParameters.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(380, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 233);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 185);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TYPE 6";
            // 
            // buttonSendType6
            // 
            this.buttonSendType6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendType6.Location = new System.Drawing.Point(212, 147);
            this.buttonSendType6.Name = "buttonSendType6";
            this.buttonSendType6.Size = new System.Drawing.Size(127, 23);
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
            this.comboBattleShort.Location = new System.Drawing.Point(30, 104);
            this.comboBattleShort.Name = "comboBattleShort";
            this.comboBattleShort.Size = new System.Drawing.Size(149, 21);
            this.comboBattleShort.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
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
            this.comboHatches.Location = new System.Drawing.Point(30, 65);
            this.comboHatches.Name = "comboHatches";
            this.comboHatches.Size = new System.Drawing.Size(159, 21);
            this.comboHatches.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "HATCHES STATUS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "TURRET ANGLE (HEX)";
            // 
            // textTurretAngle
            // 
            this.textTurretAngle.Location = new System.Drawing.Point(30, 29);
            this.textTurretAngle.Name = "textTurretAngle";
            this.textTurretAngle.Size = new System.Drawing.Size(65, 20);
            this.textTurretAngle.TabIndex = 29;
            this.textTurretAngle.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disableKA);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.ARTLogPictureBox);
            this.Controls.Add(this.PegasoTeConnectGroupBox);
            this.Name = "Form1";
            this.Text = "SVS Emulator";
            this.PegasoTeConnectGroupBox.ResumeLayout(false);
            this.PegasoTeConnectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARTLogPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

