using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ModbusTcpTerminal;
using ServerSuperIO.Modbus;
using CoolantPostureController.DataPoll;
using CoolantPostureController.Modules;

namespace CoolantPostureController
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static SerialPort GetSerialPort()
        {
            SerialPort port = new SerialPort("COM3");
            // configure serial port
            port.BaudRate = 115200;//9600;
            port.DataBits = 8;
            port.Parity = Parity.None;// .Even;
            port.StopBits = StopBits.One;
            port.Open();
            port.ReadTimeout = 5000;
            port.WriteTimeout = 1000;
            return port;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ModbusDeviceDataPoll DataPoll = new ModbusDeviceDataPoll();

            DataPoll.StreamRes = new SerialPortAdapter(GetSerialPort());
            DataPoll.ModbusMaster = ModbusMasterFactory.CreateRtu();

            DriverModule.GetInstance().DeviceDataPoll = DataPoll;

            IOModule.GetInstance().DeviceDataPoll = DataPoll;
            
            ViewMap();
        
        }

        private void ViewMap()
        {

            Terminal ter = new Terminal();
            ter.Dock = DockStyle.Fill;
            this.panel_body.Controls.Add(ter);

        
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}