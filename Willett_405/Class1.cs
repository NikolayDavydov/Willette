//using System;
//using System.Collections;
//using System.Windows.Forms;
//using System.Drawing;
//using System.Threading;
//using System.Text;


//namespace WM_CSharp
//{
//    public class RsExchange
//    {
//        //public SState global_state;           // Глобальная структура, в которой храняться данные
//        System.IO.Ports.SerialPort rs_port;

//        public void InitRs()                            //  Инициализация работы COM-порта для связи с нуклероном
//        {
//            rs_port = new System.IO.Ports.SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

//            if (rs_port.IsOpen == true)
//                rs_port.Close();

//            rs_port.Open();
//        }

//        public byte crc8(byte[] mas, int mas_size)      //  Алгоритм расчет CRC
//        {
//            byte crc = mas[0];

//            for (int i = 1; i < mas_size; i++)
//                crc ^= mas[i];

//            return crc;
//        }

//        public int SetCmd(int num)                     //  Отправка команды управления (выставление дискретных выходов)
//        {
//            byte[] data = new byte[4];

//            data[0] = 64;       // '@'
//            data[1] = 90;
//            data[2] = (byte)num;
//            data[3] = crc8(data, 3);
//            rs_port.Write(data, 0, 4);                  //  Отправляем запрос, ждем 100 мс и смотрим что пришло в ответ

//            System.Threading.Thread.Sleep(100);

//            if (rs_port.BytesToRead > 0)
//            {
//                byte[] answer = new byte[(int)rs_port.BytesToRead];     //  Читаем буфер для аналаза ответа на команду Z (управление)
//                rs_port.Read(answer, 0, rs_port.BytesToRead);
//                return 0;
//            }

//            return -1;       //  Если не пришло вообще никакого ответа, возвращаем отрицательное значение
//        }

//    }


//    static class Program
//    {
//        /// <summary>
//        /// The main entry point for the application.
//        /// </summary>
//        [MTAThread]
//        static void Main()
//        {
//            //Form1 visual = new Form1();             //  Графический интерфейс
//            Queue cmd = new Queue();       //  Очерерь команд, туда из разных потоков можно подкидывать команды 
//            Object stoper = new object();           //  Блокировка на время добавления значений в очередь сообщений
//            RsExchange rs_exchange = new RsExchange();      // Класс обемна инфорцаией

//            Thread com_connection = new Thread(delegate ()           //  В этом потоке достаем команды из очереди если они там есть, инчае запрашиваем сосотяние дискретных входов
//            {
//                rs_exchange.InitRs();                       //  Инициализируем RS-232 

//                while (true)
//                {
//                    int cmdd = -1;     // По дефолту считаем что нет новых команд с очереди

//                    lock (stoper)
//                        if (cmd.Count != 0)
//                            cmdd = (int)cmd.Dequeue();


//                    rs_exchange.SetCmd(cmdd);

//                    Thread.Sleep(50);
//                }

//            });
//            com_connection.Start();

//        }
//    }
//}