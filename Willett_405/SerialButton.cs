//using System;
//using System.Collections.Generic;
//using System.IO.Ports;
//using System.Threading;

//namespace Willett_405
//{
//    //  Наследуем наш клас от SerialPort для более красивого кода
//    public class MySerialPort : RSPort
//    {
//        private const int DataSize = 54;    //  я так и не понял, какой размер данных нужен. Укажите правильное число в байтах
//        private readonly byte[] _bufer = new byte[DataSize];
//        private int _stepIndex;
//        private bool _startRead;

//        public MySerialPort(string port)
//            : base()
//        {
//            //  все папаметры вы должны указать в соответствии с вашим устройством
//            //base.PortName = COM1;
//            BaudRate = 115200;
//            DataBits = 8;
//            StopBits = StopBits.Two;
//            Parity = Parity.None;
//            ReadTimeout = 1000;

//            //  тут подписываемся на событие прихода данных в порт
//            //  для вашей задачи это должно подойт идеально
//            DataReceived += SerialPort_DataReceived;
//        }

//        //  открываем порт передав туда имя
//        public void Open(string portName)
//        {
//            if (IsOpen)
//            {
//                Close();
//            }
//            PortName = portName;
//            Open();
//        }

//        //  эта функция вызвется каждый раз, когда в порт чтото будет передано от вашего устройства
//        void SerialPort_PinChanged(object sender,SerialPinChangedEventArgs e)
//        {
//            var port = (RSPort)sender;
//            if (port.DsrHolding == true)
//            {

//            }
//        }
//        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
//        {
//            var port = (RSPort)sender;
//            try
//            {
//                //  узнаем сколько байт пришло
//                int buferSize = port.BytesToRead;
//                for (int i = 0; i < buferSize; ++i)
//                {
//                    //  читаем по одному байту
//                    byte bt = (byte)port.ReadByte();
//                    //  если встретили начало кадра (0xFF) - начинаем запись в _bufer
//                    if (0xFF == bt)
//                    {
//                        _stepIndex = 0;
//                        _startRead = true;
//                        //  раскоментировать если надо сохранять этот байт
//                        //_bufer[_stepIndex] = bt;
//                        //++_stepIndex;
//                    }
//                    //  дописываем в буфер все остальное
//                    if (_startRead)
//                    {
//                        _bufer[_stepIndex] = bt;
//                        ++_stepIndex;
//                    }
//                    //  когда буфер наполнлся данными
//                    if (_stepIndex == DataSize && _startRead)
//                    {
//                        //  по идее тут должны быть все ваши данные.

//                        //  .. что то делаем ...
//                        //  var item = _bufer[7];

//                        _startRead = false;
//                    }
//                }
//            }
//            catch { }
//        }
//    }
//}

