using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.ArduinoControllers
{
    public class SerialPortConnector
    {
        private readonly int BaudRate = 9600;
        private readonly string PortName = "Com4";

        public void Send(string command)
        {
            using(var serialPort = new SerialPort(PortName, BaudRate))
            {
                serialPort.Open();
                serialPort.Write(command);
            }
        }

    }
}
