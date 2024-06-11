using Modbus.Device;
using System;
using System.IO.Ports;
using System.Net.Sockets;
using System.Windows.Forms;

namespace modbusuygulama
{
    public partial class Form1 : Form
    {
        private IModbusMaster master;
        private TcpClient tcpClient;
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            lblconnection.Text = "Disconnected";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combochannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblipaddress_Click(object sender, EventArgs e)
        {

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ipaddress = txtipaddress.Text;
                lblipaddress.Text = ipaddress;
                int port = 502;
                tcpClient = new TcpClient(ipaddress, port);
                master = ModbusIpMaster.CreateIp(tcpClient);


                lblconnection.Text = "Connected";
                MessageBox.Show("Connected successfully");
            }
            catch (Exception ex)
            {

                lblconnection.Text = "Not Connected";
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;

                }
                byte slaveId = 1;
                ushort startAddress = 0;
                ushort numberofpoints = 1;
                ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numberofpoints);
                txtdata.Text = string.Join(", ", registers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
