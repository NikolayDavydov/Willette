using System;
using Microsoft.VisualBasic;

namespace Willett_405
{
    public class Packet
    {
        public byte STX = 0x02; // Старт сообщения
        public Char Type = new Char(); // Тип сообщения
        public byte ETX = 0x03; // Конец сообщения
        public Block pack;
        public class MessageData
        {
            public Block blk;
            public MessageData(Block blk)
            {
                this.blk = blk;
            }
            public MessageData(string str, int Font = 0, int Hrc = 0, int Vrc = 24, int Attr = 1000)
            {
                int LenghtMessage = str.Length + 15;
                blk = new Block(Font, 2);
                blk += new Block(Hrc, 4);
                blk += new Block(Vrc, 3);
                blk += new Block(Attr, 6);
                blk += new Block(str, str.Length);
            }
            public static MessageData operator +(MessageData op1, MessageData op2)
            {
                byte SEP = 0x0A;
                byte[] arr1 = op1.blk.blk;
                byte[] arr2 = op2.blk.blk;
                int len1 = arr1.Length;
                int len2 = arr2.Length;
                arr1[len1 + 1] = SEP;
                Array.Resize(ref arr1, len1 + 1 + len2);
                arr2.CopyTo(arr1, len1 + 2);
                return new MessageData(new Block(arr1));
            }

        }
    }

    public class Block
    {
        public byte[] blk;
        public Block(string dat, int len = -1)
        {
            blk = new byte[dat.Length];
            for (int i = 0; i < dat.Length; i++)
            {
                blk[i] = (byte)System.Convert.ToChar(Strings.Mid(dat, i + 1, 1));
            }
        }
        public Block(int dat, int len)
        {
            int LenDat = dat.ToString().Length;
            blk = new byte[len];
            int diff = len - LenDat;
            string str = dat.ToString();
            for (int i = 0; i < len; i++)
            {
                if (i < diff)
                {
                    blk[i] = 0x30;
                }
                else
                {
                    blk[i] = (byte)System.Convert.ToChar(Strings.Mid(str, i - diff + 1, 1));
                }
            }
        }
        public Block(byte dat)
        {
            blk = new byte[1] { dat };
        }
        public Block(byte[] dat)
        {
            blk = dat;
        }
        public static Block operator +(Block op1, Block op2)
        {
            byte[] arr1 = op1.blk;
            byte[] arr2 = op2.blk;
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            Array.Resize(ref arr1, len1 + len2);
            arr2.CopyTo(arr1, len1);
            return new Block(arr1);
        }
        public byte[] GetMessage()
        {
            return Convert.GetCode(blk);
        }
    }
    public class UpdateMessageText : Packet
    {
        public UpdateMessageText(string str, int Font = 0, int Hrc = 0, int Vrc = 24, int Attr = 1000)
        {
            pack = new Block(STX);
            Type = 'T';
            pack += new Block((byte)Type);
            MessageData mess = new MessageData(str, Font, Hrc, Vrc, Attr);
            pack += mess.blk;
            pack += new Block(ETX);

        }
        
    }
}
//public class MessageSelect:Packet
//{
//    public MessageSelect(string MessName)
//    {
//        Type = 'M';
//        mess[0] = STX;
//        mess[1] = (byte)Type;
//        int MessLen = Math.Max(Strings.Len(MessName), 30);
//        for (int i = 0; i <= MessLen; i++)
//        {
//            mess[i + 2] = (byte)Convert.ToChar(Strings.Mid(MessName, i, 1));
//        }
//        mess[MessLen + 3] = ETX;
//    }
//}
//public class ClearUserFieldData : Packet
//{
//    public ClearUserFieldData(string UserFieldName)
//    {
//        int len = 3 + UserFieldName.Length;
//        mess[0] = STX;
//        Misc.GetBytes(UserFieldName).CopyTo(mess, 1);
//        mess[mess.GetLength(1) + 1] = ETX;
//    }
//}


