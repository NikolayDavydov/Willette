using System;
using System.IO.Ports;
using System.Threading;

namespace Willett_405
{
    public class RSPort
    {
        public int button = -1; 
        public SerialPort rs_port { get; set; }
        public bool isConnected { get; set; }
        protected Thread tdRead = null;
        public void InitRs(string PortName = "COM1", int Bitrate = 9600, Parity par = Parity.None, int PackSize = 8, StopBits stopBit = StopBits.One)  //  Инициализация работы COM-порта
        {
            rs_port = new SerialPort(PortName, Bitrate, par, PackSize, stopBit);
            if (rs_port.IsOpen == true) { rs_port.Close(); };
            rs_port.Open();
        }
    }
}
