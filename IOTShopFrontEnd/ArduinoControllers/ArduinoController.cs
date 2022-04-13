using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOTShopFrontEnd.ArduinoControllers
{
    public class ArduinoController : Controller
    {
        private SerialPortConnector SerialPort;

        public ArduinoController()
        {
            SerialPort = new SerialPortConnector();
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Send(string command, string data)
        {
            try
            {
                SerialPort.Send(command + data);
                return Ok("Success");
            }
            catch (Exception)
            {
                return BadRequest("Failed"); 
            }
        }
    }
}
