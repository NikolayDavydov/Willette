using Microsoft.VisualBasic;
using System;

namespace Willett_405
{
    public static class Misc
    {
         
        public static string[] GetRow(string str)
        {
            /*
                         0120 0278 0000 002 14 00 00 Prf 455    OOO "Zavod  Imperiya" /        OOO "Almaz" 4ClimaGuard N-14-6M1;SPO 4I-14-6M1 GOST 24866-99 0417                                                                  000 0 00 0278 0000 0000 0000 0000 0000 0000 0000 0000 0000 0 0000 0 0000 040 0                               
            */
            string[] res = new string[9];
            res[0] = "0";
            if (SubString(str, 1, 1) == "*") { res[0] = "1"; }//Готовность
            res[1] = GetIntToString(SubString(str, 26));//Номер
            res[2] = GetIntToString(SubString(str, 31));//Ширина
            res[3] = GetIntToString(SubString(str, 36));//высота
            res[4] = GetIntToString(SubString(str, 45, 2));//Рамка
            res[5] = SubString(str, 54, 10);//Портфель
            res[6] = SubString(str, 65, 31);//Заказчик
            res[7] = SubString(str, 108, 118);//Формула
            res[8] = SubString(str, 96, 11);//Поставщик
            return res;
        }
        static string SubString(string str, int start, int len = 4)
        {
            string res = Strings.Mid(str, start, len);
            return res;
            //return Strings.Replace(res, "\"", "\"\"");
        }
        static string GetIntToString(string str)
        {
            Int32.TryParse(str, out int x);
            return x.ToString();
        }
        public static byte[] GetBytes(int mess, int len = -1, bool zeroPadding = false)
        {
            byte[] res = new byte[len];
            string str = string.Empty;
            if (len != -1 && zeroPadding)
            {
                str = System.Convert.ToString(mess).PadLeft(len, '0');
            }
            else
            {
                str = System.Convert.ToString(mess);
            }
            int lenstr = Strings.Len(str);
            for (int i = 1; i < lenstr + 1; i++)
            {
                res[i] = (byte)System.Convert.ToChar(Strings.Mid(str, i, 1));
            }
            return res;
        }
        public static byte[] GetBytes(string mess)
        {
            byte[] res = new byte[mess.Length];
            for (int i = 0; i < mess.Length; i++)
            {
                res[i] = (byte)System.Convert.ToChar(Strings.Mid(mess, i, 1));
            }
            return res;
        }
        public static byte ConstructByteFromBits(int[] bits)
        {
            byte b = (byte)((bits[0] << 7) | (bits[1] << 6) | (bits[2] << 5) | (bits[3] << 4) | (bits[4] << 3) | (bits[5] << 2) | (bits[6] << 1) | (bits[7] << 0));
            return b;
        }
        public static byte[] GetMessageData(string MessageText, int FontNum, int Horc, int Verc, int Attrib)
        {
            /*Делаем тестовое сообщение
             * В дальнейшем будем брать из распарсеной строки задания
             The FONT NUM field consists of exactly 2 characters (ASCII „0' to „9') which 
             represent a decimal value between 1 and 99. It describes the font number to be 
             used for the following text. The font number follows the order in which the fonts 
             appear when using the editor, i.e. font 0 is always 7hi, but the rest will be 
             dynamically allocated according to the fonts fitted. 
             (00 = 7hi, 01 = 9hi, 02 = 12hi, 03 = 16hi, 04 = 24hi, 05 = 34hi, 06 = 5hi).
             */
            byte[] FontNumByte = GetBytes(FontNum, 2, true);// new byte[2] {0x00, 0x00};
            /*The HORC field consists of exactly 4 characters (ASCII „0' to „9') which represent 
             * a decimal value between 0 and 9999, it describes the relative horizontal position 
             * at which the text fragment should be placed within the message. Note: This position 
             * is relative, and subject to left justification. It should considered as a fragment 
             * ordering control rather than a means of placing the text fragment in an exact 
             * location; i.e., the text fragment with a HORC of 1 will always be to the left of 
             * another text fragment with a HORC of greater than 1 and more. The numeric data 
             * within the packet field is right justified and zero-padded.*/
            byte[] HorcByte = GetBytes(Horc, 4, true);//new byte[4] {0x00, 0x00, 0x00, 0x01};
            /*The VERC field consists of exactly 3 characters (ASCII „0' to „9') which represent 
             * a decimal value between 0 and 999. It describes the vertical position at which 
             * the text field should be placed within the message.
             *      Note: The whole message is subject to upward justification. 
             *  If blank lines 
             *  are required at the top of a message, a dummy fragment containing a single 
             *  space character in an appropriate font must be sent. The numeric data within 
             *  the packet field is right justified and zero-padded. The algorithm of field 
             *  positioning on the basis of HORC and VERC is as follows:
             *   1. Select all fields with minimal value of HORC.
             *   2. Place them to the message image in a left aligned column from top to bottom
             *   in the order of VERC values with 1 pixel gap.
             *   3. Select all fields with second minimal value of HORC and place them in same
             *   column to the right of the fields with minimal HORC.
             *   4. Shift each fields of the second column horizontally to the left until there is a
             *   minimal gap of 1 pixel with any of the fields of the first column or it comes to
             *   the left boundary of the message image.
             *   5. Continue selecting fields with next value of HORC, piling them in a column
             *   and shifting left where possible, until all the fields take their place.*/
            byte[] VercByte = GetBytes(Verc, 3, true);//new byte[3] {0x00, 0x03, 0x04};
                                                      //byte[] AttribByte = Misc.GetBytes(Attrib, 6);
            int[] Attribute1bits = new int[8] {0,0,0,0,
                0,  //Double Dots On
                0,  //CLOCK_CODE
                0,  //REVERSE
                0   //INVERT
            };
            byte Attribute1 = ConstructByteFromBits(Attribute1bits);
            int[] Attribute2bits = new int[8] {0,0,0,0,
                0,  //BARCODE_HR_ON
                0,  //PROMPTED_USER_FIELD
                0,  //TOWER_PRINTING
                0   //Triple Dots On
            };
            byte Attribute2 = ConstructByteFromBits(Attribute2bits);
            int[] Attribute3bits = new int[8] {0,0,0,0,
                0,  //Not Used
                0,  //BARCODE_CHECKSUM_ON
                0,  //Inverse Video
                0   //USe Custom Font
            };
            byte Attribute3 = ConstructByteFromBits(Attribute3bits);
            byte[] Attribute4_5 = new byte[2] { 0, 0 };
            byte[] AttribByte = new byte[6]
            {
                Attribute1,
                Attribute2,
                Attribute3,
                Attribute4_5[0],
                Attribute4_5[1],
                (byte)'0'
            };
            char[] chars = MessageText.ToCharArray();
            byte[] message = new byte[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                message[i] = (byte)chars[i];
            }
            byte[] result = new byte[15 + message.Length];
            FontNumByte.CopyTo(result, 0);
            HorcByte.CopyTo(result, 2);
            VercByte.CopyTo(result, 6);
            AttribByte.CopyTo(result, 9);
            message.CopyTo(result, 15);
            return result;
        }
    }
}
