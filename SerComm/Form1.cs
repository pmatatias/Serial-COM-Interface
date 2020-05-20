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

namespace SerComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePort();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void updatePort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portName.Items.Add(port);
            }
        }

        private SerialPort comport = new SerialPort();
        private void connect()
        {
            bool err = false;

            if (portName.SelectedIndex != -1 & bauderate_.SelectedIndex != -1)
            {
                comport.PortName = portName.Text;
                comport.BaudRate = int.Parse(bauderate_.Text);
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), parity_.Text);
                comport.DataBits = int.Parse(databits_.Text);
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbits_.Text);

                try
                {
                    comport.Open();
                    comport.DataReceived += Comport_DataReceived;
                }
                catch (UnauthorizedAccessException) { err = true; }
                catch (System.IO.IOException) { err = true; }
                catch (ArgumentException) { err = true; }

                if (err)
                {

                    MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            else
            {
                MessageBox.Show(this, "Please select all the COM Serial Port Settings", "Serial Port Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
                
                if (comport.IsOpen)
                {
                    connectbtn.Text = "Disconnect";
                    sendbtn.Enabled = true;
                    groupBox1.Enabled = false;
                }
        }

        private void disconnect()
        {
            comport.Close();
            connectbtn.Text = "Connect";
            sendbtn.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void Comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            SetText(data);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen) disconnect();
            else connect();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Readbox.Clear();
            sendbox.Clear();
        }
        private void sendData()
        {
            comport.Write(sendbox.Text);
            Readbox.ForeColor = Color.Green;
            sendbox.Clear();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void FormClosing (Object sender , FormClosedEventArgs e)
        {
            if (comport.IsOpen) comport.Close();
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (Readbox.InvokeRequired)
            {
                Readbox.ForeColor = Color.Green;
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });

            }
            else this.Readbox.AppendText(text);
        }

        //private void SerialDataReceived (object sender, SerialDataReceivedEventArgs e)
        //{
        //    var serialPort = (SerialPort)sender;
        //    var data = serialPort.ReadExisting();
        //    SetText(data);
        //}

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            updatePort();
        }
    }
}
