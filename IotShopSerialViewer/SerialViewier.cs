using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IotShopSerialViewer
{
    public partial class SerialViewier : Form
    {

        private string RecivedData;
        private int counter;
  

        public SerialViewier()
        {
            InitializeComponent();
            FetchPorts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FetchPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void COMPortsButton_Click(object sender, EventArgs e)
        {
            SerialPort = new SerialPort();
            SerialPort.BaudRate = 9600;
            SerialPort.PortName = comboBox1.Text;
            SerialPort.Parity = Parity.None;
            SerialPort.DataBits = 8;
            SerialPort.StopBits = StopBits.One;
            SerialPort.ReadBufferSize = 2000000000;
            SerialPort.DataReceived += SerialPort_DataReceived;

            try
            {
                SerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RecivedData = SerialPort.ReadLine();
            this.Invoke(new Action(ProcessingData));
        }

        private void ProcessingData()
        {
            try
            {
                ReciveDataTextBox.Text = RecivedData.ToString(); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            counter++; 
        }

        private void ReciveDataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileSavingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
