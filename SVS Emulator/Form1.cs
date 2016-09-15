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
using tcpServer;
using System.Net.Sockets;
using System.IO;

namespace SVS_Emulator
{
    
    public partial class Form1 : Form
    {
        #region Private Members

        private enum EthStatus : byte
        {
            ETH_WAIT_ID_MESSAGE_1 = 0x00,
            ETH_WAIT_ID_MESSAGE_2,
            ETH_WAIT_ID_MESSAGE_3,
            ETH_WAIT_ID_MESSAGE_4,
            ETH_WAIT_LENGTH_1,
            ETH_WAIT_LENGTH_2,
            ETH_WAIT_LENGTH_3,
            ETH_WAIT_LENGTH_4,
            ETH_WAIT_MESSAGE_COUNTER_1,
            ETH_WAIT_MESSAGE_COUNTER_2,
            ETH_WAIT_MESSAGE_COUNTER_3,
            ETH_WAIT_MESSAGE_COUNTER_4,
            ETH_WAIT_CRANK_STATUS,
            ETH_WAIT_BATTERY_STATUS,
            ETH_WAIT_DOORS_STATUS,
            ETH_WAIT_HATCH_STATUS,
            ETH_WAIT_RISERVETTA_DX_HE,
            ETH_WAIT_RISERVETTA_DX_MP,
            ETH_WAIT_RISERVETTA_DX_AP,
            ETH_WAIT_RISERVETTA_SX_HE,
            ETH_WAIT_RISERVETTA_SX_MP,
            ETH_WAIT_RISERVETTA_SX_AP,
            ETH_WAIT_SPARE_1,
            ETH_WAIT_SPARE_2,

            ETH_WAIT_MAX
        }

        private SVSTcpClient                _tcpClient;
        private Boolean                     _Connected = false;
        private Boolean                     _CruscottoConnected = false;
        private const UInt16                KA_Timeout = 100;
        private System.Windows.Forms.Timer  kaTimer;
        private Mutex                       cmdMutex;
        private TcpServer                   _tcpServer;
        private EthStatus                   status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
        private byte[]                      svsPayload;
        private int cruscottoTxEnable = 0;

        #endregion

        public delegate void invokeDelegate();

        public Form1()
        {
            InitializeComponent();

            _tcpClient = new SVSTcpClient();
            _tcpClient.OnConnected += OnConnected;
            _tcpClient.OnDisconnected += OnDisconnected;
            _tcpClient.OnRxData += OnRxData;

            _tcpServer = new TcpServer();
            _tcpServer.Port = 2100;
            _tcpServer.Open();
            _tcpServer.OnDataAvailable += _tcpServer_OnDataAvailable;
            _tcpServer.OnConnect += _tcpServer_OnConnect;
            _tcpServer.OnError += _tcpServer_OnError;
            svsPayload = new byte[11]; 

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

        private void _tcpServer_OnError(TcpServer server, Exception e)
        {
            _CruscottoConnected = false; 
        }

        private void _tcpServer_OnConnect(TcpServerConnection connection)
        {
            _CruscottoConnected = true;
        }

        private void _tcpServer_OnDataAvailable(TcpServerConnection connection)
        {
            byte[] data = readStream(connection.Socket);

            if (data != null)
            {
                //string dataStr = Encoding.ASCII.GetString(data);
                try
                {
                    invokeDelegate del = () =>
                    {
                        ParseSvsData(data);
                    };
                    Invoke(del);
                    data = null;
                }
                catch { }
            }
        }

        private void ParseSvsData(byte[] data)
        {
            int length = data.Length;
            int index = 0;

            while (length>0)
            {
             
                switch (status)
                {
                    case EthStatus.ETH_WAIT_ID_MESSAGE_1:
                        if(data[index] == 0x07)
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_2;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }
                    break;

                    case EthStatus.ETH_WAIT_ID_MESSAGE_2:
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_3;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }
                    break;

                    case EthStatus.ETH_WAIT_ID_MESSAGE_3:
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_4;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }
                    break;

                    case EthStatus.ETH_WAIT_ID_MESSAGE_4:
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_LENGTH_1;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }
                    break;

                    case EthStatus.ETH_WAIT_LENGTH_1:
                    {
                        if (data[index] == 0x0C)
                        {
                            status = EthStatus.ETH_WAIT_LENGTH_2;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }

                    }
                    break;

                    case EthStatus.ETH_WAIT_LENGTH_2:
                    {
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_LENGTH_3;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }

                    }
                    break;

                    case EthStatus.ETH_WAIT_LENGTH_3:
                    {
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_LENGTH_4;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }

                    }
                    break;

                    case EthStatus.ETH_WAIT_LENGTH_4:
                    {
                        if (data[index] == 0x00)
                        {
                            status = EthStatus.ETH_WAIT_MESSAGE_COUNTER_1;
                        }
                        else
                        {
                            status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        }

                    }
                    break;

                    case EthStatus.ETH_WAIT_MESSAGE_COUNTER_1:
                    {
                        svsPayload[0] = data[index];
                        status = EthStatus.ETH_WAIT_MESSAGE_COUNTER_2;
                    }
                    break;

                    case EthStatus.ETH_WAIT_MESSAGE_COUNTER_2:
                    {
                        status = EthStatus.ETH_WAIT_MESSAGE_COUNTER_3;
                    }
                    break;

                    case EthStatus.ETH_WAIT_MESSAGE_COUNTER_3:
                    {
                        status = EthStatus.ETH_WAIT_MESSAGE_COUNTER_4;
                    }
                    break;

                    case EthStatus.ETH_WAIT_MESSAGE_COUNTER_4:
                    {
                        status = EthStatus.ETH_WAIT_CRANK_STATUS;
                    }
                    break;

                    case EthStatus.ETH_WAIT_CRANK_STATUS:
                        svsPayload[1] = data[index];
                        status = EthStatus.ETH_WAIT_BATTERY_STATUS;
                    break;

                    case EthStatus.ETH_WAIT_BATTERY_STATUS:
                        svsPayload[2] = data[index];
                        status = EthStatus.ETH_WAIT_DOORS_STATUS;
                    break;

                    case EthStatus.ETH_WAIT_DOORS_STATUS:
                        svsPayload[3] = data[index];
                        status = EthStatus.ETH_WAIT_HATCH_STATUS;
                    break;

                    case EthStatus.ETH_WAIT_HATCH_STATUS:
                        svsPayload[4] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_DX_HE;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_DX_HE:
                        svsPayload[5] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_DX_MP;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_DX_MP:
                        svsPayload[6] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_DX_AP;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_DX_AP:
                        svsPayload[7] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_SX_HE;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_SX_HE:
                        svsPayload[8] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_SX_MP;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_SX_MP:
                        svsPayload[9] = data[index];
                        status = EthStatus.ETH_WAIT_RISERVETTA_SX_AP;
                    break;

                    case EthStatus.ETH_WAIT_RISERVETTA_SX_AP:
                        svsPayload[10] = data[index];
                        status = EthStatus.ETH_WAIT_SPARE_1;
                    break;

                    case EthStatus.ETH_WAIT_SPARE_1:
                        status = EthStatus.ETH_WAIT_SPARE_2;
                    break;

                    case EthStatus.ETH_WAIT_SPARE_2:
                        status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                        // TODO: update form controls
                        message_counter.Text = svsPayload[0].ToString();
                        CrankStatus.Text = svsPayload[1].ToString();
                        BatteryStatus.Text = svsPayload[2].ToString();
                        DoorsStatus.Text = svsPayload[3].ToString();
                        HatchStatus.Text = svsPayload[4].ToString();
                        DX_HE.Text = svsPayload[5].ToString();
                        DX_MP.Text = svsPayload[6].ToString();
                        DX_AP.Text = svsPayload[7].ToString();
                        SX_HE.Text = svsPayload[8].ToString();
                        SX_MP.Text = svsPayload[9].ToString();
                        SX_AP.Text = svsPayload[10].ToString();

                        //buttonSendType6_Click(null, null);

                        cruscottoTxEnable++;
                        break;

                    default:
                        status = EthStatus.ETH_WAIT_ID_MESSAGE_1;
                    break;
                }

                index++;
                length--;
            };
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

        private void OnConnectedCruscotto(object sender, EventArgs e)
        {
            
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
            if (_CruscottoConnected == true)
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
       
                //if (cmdMutex.WaitOne(500))
                //{
                    //_tcpClient.SendMessage(message);
                    //_tcpServer.Send();
                    foreach(TcpServerConnection client in _tcpServer.Connections)
                    {
                        NetworkStream stream = client.Socket.GetStream();
                        stream.Write(message, 0, 16);
                    }
                    string sentText = ByteArrayToHexStringViaBitConverter(message);
                    textLog.AppendText("TX:     " + sentText + "\r\n");
                 //   cmdMutex.ReleaseMutex();
                //}
            } 
        }

        protected byte[] readStream(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            if (stream.DataAvailable)
            {
                byte[] data = new byte[client.Available];

                int bytesRead = 0;
                try
                {
                    bytesRead = stream.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                }

                if (bytesRead < data.Length)
                {
                    byte[] lastData = data;
                    data = new byte[bytesRead];
                    Array.ConstrainedCopy(lastData, 0, data, 0, bytesRead);
                }
                return data;
            }
            return null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _tcpServer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_CruscottoConnected == true)
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
