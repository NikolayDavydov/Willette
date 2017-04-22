//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.IO;
//using System.IO.Ports;
//using System.Threading;
//using System.Diagnostics;
//using System.Windows.Forms;

//namespace Willett_405
//{
   
//    public class Serial
//    {
//        public bool StopPressed;
//        public bool isConnected { get; set; }
//        public RSPort Rs_port { get; set; }
//        //поток для чтения
//        protected Thread tdRead = null;

//        /// <summary>
//        /// Событие на запуск устройства
//        /// </summary>
//        public event SomeVoidDo OnStart;

//        /// <summary>
//        /// Событие при ошибке запуска устройства
//        /// </summary>
//        public event SomeExceptionDo OnFail;

        

//        public int NextPressed = -1;
//        public void InitRs(string PortName = "COM1", int Bitrate = 9600, Parity par = Parity.None,
//            int PackSize = 8, StopBits stopBit = StopBits.One)  //  Инициализация работы COM-порта для связи с нуклероном
//        {
//            Rs_port = new RSPort(PortName, Bitrate, par, PackSize, stopBit);
//            if (Rs_port.IsOpen == true) { Rs_port.Close(); };
//            Rs_port.Open();
//        }
//        public void Open()
//        {
//            try
//            {
//                //устанавливаем состояние подключенности в истину
//                isConnected = true;

//                //открываем порт
//                Rs_port.Open();
//                //создаем новый поток чтения
//                //tdRead = new Thread(Read);
//                //запускаем коток
//                //tdRead.Start();

//                //если определен метод для свойства старта..
//                //выполнить этот метод
//                OnStart?.Invoke(this);
//            }
//            //для любой ошибки
//            catch (Exception)
//            {
//                //вызов метода с указанием точного текста ошибки
//                OnFail?.Invoke(this, new Exception("Fail start device"));
//            }
//        }

//        public int Send(Packet mess)
//        {
//            byte[] blk = mess.pack.blk;
//            Rs_port.Write(blk, 0, blk.Length);
//            Thread.Sleep(100);
//            RecvBtn();
//            //if (rs_port.BytesToRead > 0)
//            //{
//            //    byte[] answer = new byte[rs_port.BytesToRead];     //  Читаем буфер для аналаза ответа на команду Z (управление)
//            //    rs_port.Read(answer, 0, rs_port.BytesToRead);
//            //    if (answer[0] == 0x24)
//            //    {
//            //        return 0;
//            //    }
//            //}
//            return -1;       //  Если не пришло вообще никакого ответа, возвращаем отрицательное значение
//        }
//        public int Send(byte[] pack)
//        {
//            Rs_port.Write(pack, 0, pack.Length);
//            Thread.Sleep(100);
//                        //if (rs_port.BytesToRead > 0)
//            //{
//            //    byte[] answer = new byte[rs_port.BytesToRead];     //  Читаем буфер для аналаза ответа на команду Z (управление)
//            //    rs_port.Read(answer, 0, rs_port.BytesToRead);
//            //    if (answer[0] == 0x24)
//            //    {
//            //        return 0;
//            //    }
//            //}
//            return -1;       //  Если не пришло вообще никакого ответа, возвращаем отрицательное значение
//        }
//        public int RecvBtn()
//        {

//            Rs_port.DtrEnable = true;
//            Queue cmd = new Queue();       //  Очерерь команд, туда из разных потоков можно подкидывать команды 
//            Object stoper = new object();           //  Блокировка на время добавления значений в очередь сообщений
//            Thread com_connection = new Thread(delegate ()           //  В этом потоке достаем команды из очереди если они там есть, инчае запрашиваем сосотяние дискретных входов
//            {
//                while (true)
//                { 
//                    if (StopPressed == true)
//                    {
//                        //Выход из цикла
//                        StopPressed = false;
//                        NextPressed = 0;
//                        break;
//                    }
//                    else
//                    {
//                        if (Rs_port.DsrHolding == true)
//                        {
//                            NextPressed = 1;
//                            break;
//                        }
//                        Thread.Sleep(100);// Задержка для опроса 10 раз в секунду
//                    }
//                }
//            });
//            com_connection.Start();
//            Rs_port.RtsEnable = true;
//            bool cts = Rs_port.CtsHolding;
//            Rs_port.DtrEnable = true;
//            return NextPressed;
//        }

//    }
//}
