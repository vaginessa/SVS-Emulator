using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace SVS_Emulator
{
    public enum MessageType : byte
    {
        NONE       = 0x00,
        KEEP_ALIVE = 0x01,
        SINGLE_IMG = 0x02,
        ELAB_IMG   = 0x04,
        RUN_SCORR  = 0x08,
        RST_TV     = 0x10,
        CFG_TV     = 0x20,
        STATUS_TV  = 0x40
    }

    public enum Command : byte
    {
        NULL = 0x00,
        POLARITY_CHANGE = 0x01,
        ROI_SEL = 0x02,
        DAY_NIGHT = 0x03
    }

    public class CmdMessage
    {
        private readonly UInt32         MSG_ID = 4;
        private readonly UInt32         MSG_LENGHT = 5+4;
        static public readonly byte     FRAME_LENGTH = 17+4;
        private SVS_CMD                 frame;

        static private uint MessageCounter = 0;
        static private MessageType LastImageCommand = MessageType.NONE;
        
        #region TURRET PACKET LAYOUT
        [StructLayout(LayoutKind.Explicit)]
        public struct SVS_CMD
        {
            [FieldOffset(0)]
            public UInt32 Id;

            [FieldOffset(4)]
            public UInt32 length;

            [FieldOffset(8)]
            public UInt32 MsgCounter;

            [FieldOffset(12)]
            public MessageType Type;

            [FieldOffset(13)]
            public MessageType LastMsgType;

            [FieldOffset(14)]
            public byte SelectCamera;

            [FieldOffset(15)]
            public Command Command;

            [FieldOffset(16)]
            public byte Parameters;

            [FieldOffset(17)]
            public byte TurretAngle;

            [FieldOffset(18)]
            public byte HatchesStatus;

            [FieldOffset(19)]
            public byte BattleShortStatus;

            [FieldOffset(20)]
            public byte Dummy;
        }
        #endregion

        private byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);
            byte[] arr = new byte[len];

            IntPtr ptr = Marshal.AllocHGlobal(len);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        public CmdMessage(MessageType type, byte SelectedCamera, Command Command, byte Parameters)
        {
            frame = new SVS_CMD();
            frame.Id = MSG_ID;
            frame.length = MSG_LENGHT;
            frame.MsgCounter = MessageCounter++;

            if(MessageCounter>0xFF)
            {
                MessageCounter = 0;
            }

            frame.Type = type;

            if (type == MessageType.KEEP_ALIVE)
            {
                frame.LastMsgType = LastImageCommand;
            }
            else
            {
                frame.LastMsgType = MessageType.NONE;
            }

            if(type == MessageType.SINGLE_IMG ||
               type == MessageType.ELAB_IMG  ||
               type == MessageType.CFG_TV ||
               type == MessageType.STATUS_TV)
            {
                frame.SelectCamera = SelectedCamera;
            }
            else if(type == MessageType.KEEP_ALIVE && 
                    ((frame.LastMsgType == MessageType.SINGLE_IMG) || (frame.LastMsgType == MessageType.ELAB_IMG))
                   )
            {
                frame.SelectCamera = SelectedCamera;
            }
            else
            {
                frame.SelectCamera = 0;
            }
            
            if(frame.Type == MessageType.CFG_TV)
            {
                frame.Command = Command;
                frame.Parameters = Parameters;
            }
            else
            {
                frame.Command = Command.NULL;
                frame.Parameters = 0;
            }
        }

        public byte[] GetFrame()
        {
            byte[] payload;

            payload = StructureToByteArray(frame);

            return (payload);
        }

    }
}
