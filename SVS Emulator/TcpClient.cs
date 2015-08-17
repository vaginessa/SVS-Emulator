using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using SVS_Emulator;


namespace SVS_Emulator
{
    public enum ParserEventType
    {
        MessageReceived,
        WrongHeader,
        WrongType,
        WrongLength,
        WrongPayload,
        WrongCrc    
    }

    public class SVSTcpClient
    {
        #region PRIVATE MEMBERS

        private TcpClient _Client;
        private Thread _TransmitThread;            // Transmission thread
        private Boolean _TransmitThreadEnd;         // Signal to force termination of thread
        private object _TransmitLocker;            // Synchronization lock
        private Queue<Byte[]> _TransmitQueue;             // Transmission queue

        #endregion

        #region EVENTS
        public event EventHandler OnConnected;
        public event EventHandler OnDisconnected;
        public event EventHandler OnRxData;
        #endregion


        #region CONSTRUCTOR

        public SVSTcpClient()
        {
            // Create transmission queue and locker
            _TransmitLocker = new object();
            _TransmitQueue = new Queue<Byte[]>();

            return;
        }

        #endregion


        #region PRIVATE METHODS

        // Management of data coming from Ethernet interface 
        private void OnDataReceivedHandler(IAsyncResult result)
        {
            Int32 numRecvByte;
            NetworkStream networkStream;

            try
            {
                networkStream = _Client.GetStream();
                numRecvByte = networkStream.EndRead(result);
            }
            catch
            {
                // An error has occured when reading
                return;
            }

            if (numRecvByte == 0)
            {
                // The connection has been closed.
                EventHandler handler = OnDisconnected;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }

                return;
            }

            // Get received bytes and parse them
            Byte[] recvData = result.AsyncState as Byte[];
            Byte[] data = new Byte[numRecvByte];
            Array.Copy(recvData, 0, data, 0, numRecvByte);

            // The connection has been closed.
            EventHandler RxHandler = OnRxData;
            if (RxHandler != null)
            {
                RxHandler(data, EventArgs.Empty);
            }

            // Start reading from the network again.
            networkStream.BeginRead(recvData, 0, recvData.Length, OnDataReceivedHandler, recvData);

            return;
        }

        // Message transmission thread
        private void TransmitThread()
        {
            // Get a client stream for reading and writing.
            NetworkStream networkStream = _Client.GetStream();

            while (true)
            {
                lock (_TransmitLocker)
                {
                    // Wait until there is any data in the queue or a "thread-end" request is detected
                    while (_TransmitThreadEnd == false && _TransmitQueue.Count == 0)
                    {
                        Monitor.Wait(_TransmitLocker);
                    }

                    // Close thread if a "thread-end" request is detected
                    if (_TransmitThreadEnd == true)
                    {
                        return;
                    }

                    // If there is any data into queue --> send it through ethernet interface
                    if (_TransmitQueue.Count > 0)
                    {
                        Byte[] txData = _TransmitQueue.Dequeue();

                        try
                        {
                            networkStream.Write(txData, 0, txData.Length);
                        }
                        catch
                        {
                            Disconnect();
                        }
                    }
                }
            }
        }

        #endregion

        #region Public Methods

      
        public Boolean Connect(IPAddress hostAddr, Int32 hostPort, Int32 timeout)
        {
            // Create new instance of TCP client
            _Client = new TcpClient();
            var result = _Client.BeginConnect(hostAddr, hostPort, null, null);

            _TransmitThread = null;

            result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(timeout));
            if (!_Client.Connected)
            {
                return false;
            }

            // We have connected
            _Client.EndConnect(result);
            EventHandler handler = OnConnected;
            if(handler != null)
            {
                handler(this, EventArgs.Empty);
            }

            // Now we are connected --> start async read operation.
            NetworkStream networkStream = _Client.GetStream();
            byte[] buffer = new byte[_Client.ReceiveBufferSize];
            networkStream.BeginRead(buffer, 0, buffer.Length, OnDataReceivedHandler, buffer);

            // Start thread to manage transmission of messages
            _TransmitThreadEnd = false;
            _TransmitThread = new Thread(TransmitThread);
            _TransmitThread.Start();

            return true;
        }

        // Called when PEGASO-TE "disconnect" button is pressed
        public void Disconnect()
        {
            _Client.Close();

            // Segnala ai threads la terminazione
            lock (_TransmitLocker)
            {
                _TransmitThreadEnd = true;
                Monitor.Pulse(_TransmitLocker);
            }

            // Attende che tutti i worker threads abbiano finito
            if (_TransmitThread != null)
            {
                _TransmitThread.Join();
            }

            EventHandler handler = OnDisconnected;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }

            return;
        }

        // Add a message to the transmission queue and wake-up transmit thread
        public bool SendMessage(byte[] msg)
        {

            lock (_TransmitLocker)
            {
                // Copy frame to transmit queue
                _TransmitQueue.Enqueue(msg);

                // Wake-up transmit thread
                Monitor.Pulse(_TransmitLocker);
            }

            return true;
        }

        #endregion
    }

}
