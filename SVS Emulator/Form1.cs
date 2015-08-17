using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using LBSoft.IndustrialCtrls.Leds;
using System.Threading;


namespace SVS_Emulator
{
    
    public partial class Form1 : Form
    {
        #region Private Members

        // PEGASO-TE client
        private SVSTcpClient                _tcpClient;
        private Boolean                     _Connected = false;
        private const UInt16                KA_Timeout = 1000;
        private System.Windows.Forms.Timer  kaTimer;
        private Mutex                       cmdMutex;
       

        #endregion

        public Form1()
        {
            InitializeComponent();

            _tcpClient = new SVSTcpClient();
            _tcpClient.OnConnected += OnConnected;
            _tcpClient.OnDisconnected += OnDisconnected;
            _tcpClient.OnRxData += OnRxData;

            ConnectLed.State = LBLed.LedState.Off;
            ConnectLed.Show();

            Address.SetAddressBytes(new byte[]{192,168,1,113});
            IpPort.Text = "80";
            comboType.SelectedIndex = 0;
            comboCommand.SelectedIndex = 0;
            comboParameters.SelectedIndex = 0;
            selectedCamera.Text = "0";
            cmdMutex = new Mutex();

            textTurretAngle.Text = "0";
            comboHatches.SelectedIndex = 0;
            comboBattleShort.SelectedIndex = 0;
        }

        private delegate void TextUpdateDelegate(object sender, string args);
        private void OnTextUpdate(object sender, string e)
        {
            ConnectButton.Text = e;
        }

        private delegate void LogUpdateDelegate(object sender, string args);
        private void OnLogUpdate(object sender, string e)
        {
            textLog.AppendText(e);
        }

        private void OnConnected(object sender, EventArgs e)
        {
            ConnectLed.State = LBLed.LedState.On;
            _Connected = true;
            ConnectButton.Text = "Disconnect";

            //start the timeout timer
            kaTimer = new System.Windows.Forms.Timer();
            kaTimer.Interval = KA_Timeout;
            kaTimer.Tick += kaTimer_Tick;
            kaTimer.Start();
        }

        private void OnRxData(object sender, EventArgs e)
        {
            string msg = ByteArrayToHexStringViaBitConverter((byte[])sender);

            if(InvokeRequired)
            {
                BeginInvoke(new LogUpdateDelegate(OnLogUpdate), new object[] { this, "RX:     " + msg + "\r\n\r\n" });
            }
            else
            {
                textLog.AppendText("RX:     " + msg + "\r\n\r\n");
            }
        }

        private void kaTimer_Tick(object sender, EventArgs e)
        {
           
            if(_Connected == true && disableKA.Checked == false)
            {
                byte value;
                if(byte.TryParse(selectedCamera.Text, out value))
                {
                    CmdMessage msg = new CmdMessage(MessageType.KEEP_ALIVE,
                                                    value,
                                                    0,
                                                    0);
                    if(cmdMutex.WaitOne(500))
                    {
                        byte[] payload = new byte[CmdMessage.FRAME_LENGTH];
                        Array.Copy(msg.GetFrame(), payload, CmdMessage.FRAME_LENGTH);
                        _tcpClient.SendMessage(payload);
                        string sentText = ByteArrayToHexStringViaBitConverter(payload);
                        textLog.AppendText("TX:     "+sentText+"\r\n");
                        cmdMutex.ReleaseMutex();
                    }
                }
            }
        }

        private string ByteArrayToHexStringViaBitConverter(byte[] bytes)
        {
            string hex = BitConverter.ToString(bytes);
            return (hex);
        }

        private void OnDisconnected(object sender, EventArgs e)
        {
            ConnectLed.State = LBLed.LedState.Off;
            _Connected = false;
            if(InvokeRequired)
            {
                BeginInvoke(new TextUpdateDelegate(OnTextUpdate), new object[] { this, "Connect" });
            }
            else
            {
                ConnectButton.Text = "Connect";
            }
           
            kaTimer.Stop();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Int32 port;
            String text;
            byte[] IpAddress;


            if (String.Compare(ConnectButton.Text, "Connect", true) == 0)
            {
                // Save server IP address
                IpAddress = Address.GetAddressBytes();

                // Verify that port control is a numeric string and get connection port
                if (int.TryParse(IpPort.Text, out port) == false)
                {
                    text = "Invalid port value.";
                    MessageBox.Show(text, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Connect to remote server
                text = String.Format("{0}.{1}.{2}.{3}", 
                                     IpAddress[0], 
                                     IpAddress[1], 
                                     IpAddress[2], 
                                     IpAddress[3]);

                _tcpClient.Connect(IPAddress.Parse(text), port, 3);
            }
            else
            {
                // Disconnect client
                _tcpClient.Disconnect();
            }

            return;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            byte val;
            TextBox text = (TextBox)sender;

            if (byte.TryParse(text.Text, System.Globalization.NumberStyles.HexNumber, null, out val) == true)
            {
                if (val <= 0xFF)
                {
                    text.ForeColor = Color.Black;
                    sendButton.Enabled = true;
                    buttonSendType6.Enabled = true;
                }
                else
                {
                    text.ForeColor = Color.Red;
                    sendButton.Enabled = false;
                    buttonSendType6.Enabled = false;
                }

            }
            else
            {
                text.ForeColor = Color.Red;
                sendButton.Enabled = false;
                buttonSendType6.Enabled = false;
            }
        }

        private byte GetParameter()
        {
            byte parameter=0;

            switch (comboParameters.SelectedItem.ToString())
            {
                case "NULL":
                    parameter = 0;
                break;

                case "WHITE HOT":
                case "FULL SCREEN":
                case "DAY":
                    parameter = 1;
                break;

                case "BLACK HOT":
                case "BOTTOM HALF":
                case "NIGHT":
                    parameter = 2;
                break;

                case "CENTRE BLOCK":
                    parameter = 4;
                break;

                case "TOP HALF":
                    parameter = 8;
                break;

                default:
                break;
            }

            return parameter;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MessageType type= MessageType.NONE;

            if (_Connected == true)
            {
                byte selCamera;
                CmdMessage msg;
               
                if (byte.TryParse(selectedCamera.Text, System.Globalization.NumberStyles.HexNumber, null, out selCamera))
                {
                    Command command = (Command)comboCommand.SelectedIndex;
                    byte parameters = GetParameter(); 
                   
                    switch(comboType.SelectedIndex)
                    {
                        case 0:
                            type = MessageType.KEEP_ALIVE;
                        break;

                        case 1:
                            type = MessageType.SINGLE_IMG;
                        break;

                        case 2:
                            type = MessageType.ELAB_IMG;
                        break;

                        case 3:
                            type = MessageType.RUN_SCORR;
                        break;

                        case 4:
                            type = MessageType.RST_TV;
                        break;

                        case 5:
                            type = MessageType.CFG_TV;
                        break;

                        case 6:
                            type = MessageType.STATUS_TV;
                        break;
                    }

                    msg = new CmdMessage(type, selCamera, command, parameters);

                
                    if (cmdMutex.WaitOne(500))
                    {
                        byte[] payload = new byte[CmdMessage.FRAME_LENGTH];
                        Array.Copy(msg.GetFrame(), payload, CmdMessage.FRAME_LENGTH);
                        _tcpClient.SendMessage(payload);
                        string sentText = ByteArrayToHexStringViaBitConverter(payload);
                        textLog.AppendText("TX:     " + sentText + "\r\n");
                        cmdMutex.ReleaseMutex();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textLog.Clear();
        }

        private void comboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboParameters.Items.Clear();

            switch(comboCommand.SelectedIndex)
            {
                case 0:
                    comboParameters.Items.Add("NULL");
                break;

                case 1:
                    comboParameters.Items.Add("WHITE HOT");
                    comboParameters.Items.Add("BLACK HOT");
                break;

                case 2:
                    comboParameters.Items.Add("FULL SCREEN");
                    comboParameters.Items.Add("BOTTOM HALF");
                    comboParameters.Items.Add("CENTRE BLOCK");
                    comboParameters.Items.Add("TOP HALF");
                break;

                case 3:
                comboParameters.Items.Add("DAY");
                comboParameters.Items.Add("NIGHT");
                break;
            }

            comboParameters.SelectedIndex = 0;
        }

        private void buttonSendType6_Click(object sender, EventArgs e)
        {
            if (_Connected == true)
            {
                byte[] message = new byte[16];
                message[0] = 0x6;
                message[1] = 0x0;
                message[2] = 0x0;
                message[3] = 0x0;

                message[4] = 0x4;
                message[5] = 0x0;
                message[6] = 0x0;
                message[7] = 0x0;

                message[8] = 0x0;
                message[9] = 0x0;
                message[10] = 0x0;
                message[11] = 0x0;

                byte.TryParse(textTurretAngle.Text, System.Globalization.NumberStyles.HexNumber, null, out message[12]);

                message[13] = (byte)comboHatches.SelectedIndex;
                message[14] = (byte)comboBattleShort.SelectedIndex;
                message[15] = 0x0;
       
                if (cmdMutex.WaitOne(500))
                {
                    _tcpClient.SendMessage(message);
                    string sentText = ByteArrayToHexStringViaBitConverter(message);
                    textLog.AppendText("TX:     " + sentText + "\r\n");
                    cmdMutex.ReleaseMutex();
                }
            } 
        }

    }
}
