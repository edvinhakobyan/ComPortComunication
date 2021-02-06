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
using System.Threading;
using System.Management;
using System.Diagnostics;

namespace COM_ports
{
    public partial class Form1 : Form
    {

        public int X { get; set; }
        public int Y { get; set; }

        public int Xof { get; set; }
        public int Yof { get; set; }

        string resive = "";


        public Form1()
        {
            InitializeComponent();
            Xof = Dpanel.Width / 2;
            Yof = Dpanel.Height / 2;
        }


        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Form1_Load(this.button_Refresh, new EventArgs());
        }


        string defaultBaudRate = "9600";
        string defaultDataBits = "8";
        private void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            comboB_COMPort.Items.Clear();
            comboB_COMPort.Items.AddRange(ports);

            var stopBitsValues = ((StopBits[])Enum.GetValues(typeof(StopBits))).Select(t => t.ToString()).ToArray();
            comboB_StopBits.Items.Clear();
            comboB_StopBits.Items.AddRange(stopBitsValues);

            var parityBitsValues = ((Parity[])Enum.GetValues(typeof(Parity))).Select(t => t.ToString()).ToArray();
            comboB_ParityBits.Items.Clear();
            comboB_ParityBits.Items.AddRange(parityBitsValues);

            comboB_COMPort.SelectedItem = AutodetectArduinoPort();
            comboB_BaudRate.SelectedItem = defaultBaudRate;
            comboB_DataBits.SelectedItem = defaultDataBits;
            comboB_StopBits.SelectedItem = stopBitsValues[2];
            comboB_ParityBits.SelectedItem = parityBitsValues[0];

            //Button_OPEN_Click(this, new EventArgs()); //???
        }

        private void Button_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = comboB_COMPort.Text;
                serialPort.BaudRate = Convert.ToInt32(comboB_BaudRate.Text);
                serialPort.DataBits = Convert.ToInt32(comboB_DataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboB_StopBits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboB_ParityBits.Text);
                serialPort.Open();
                button_OPEN.Enabled = false;
                progressBar.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button_CLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                progressBar.Value = 0;
            }
            button_OPEN.Enabled = true;
        }

        private string AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_PnPEntity");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string name = item["Name"]?.ToString();
                    //string description = item["Description"]?.ToString();
                    //string deviceId = item["DeviceID"]?.ToString();
                    //string caption = item["Caption"]?.ToString();

                    if (name != null && name.Contains("CH340"))
                    {
                        return name.GetPort();
                    }
                }
            }
            catch
            {
                /* Do Nothing */
            }
            return null;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Button_CLOSE_Click(this, null);
        }

        Pen pen = new Pen(Brushes.Black, 1);
        private void Dpanel_Paint(object sender, PaintEventArgs e)
        {
            using (var graphics = e.Graphics)
            {
                graphics.DrawLine(pen, Xof, 0, Xof, 2 * Yof);
                graphics.DrawLine(pen, 0, Yof, 2 * Xof, Yof);

                graphics.FillEllipse(Brushes.Red, X + Xof - 5, -(Y - Yof) - 5, 10, 10);
            }
        }

        int GetInt(int i)
        {
            try
            {
                return int.Parse(resive.Split(' ')[i]);
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            resive = serialPort.ReadLine();

            try
            {
                X = GetInt(0);
                Y = GetInt(1);

                Invoke(new Action(() =>
                {
                    label6.Text = $"Receive X = {X};Y = {Y}";
                    label7.Text = resive;
                    Dpanel.Refresh();
                }));

                serialPort.Write(resive);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
