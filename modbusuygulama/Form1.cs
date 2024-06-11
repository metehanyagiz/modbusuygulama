using Modbus.Device;
using System;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Windows.Forms;

namespace modbusuygulama
{
    
    public partial class Form1 : Form
    {
        private IModbusMaster master;
        private TcpClient tcpClient;
       
        public Form1()
        {
            InitializeComponent();
            lblconnection.Text = "Disconnected";
            this.FormClosing += new FormClosingEventHandler(Form1_Load);
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtipaddress.Text = Properties.Settings.Default.ipadresi;
            txtport.Text = Properties.Settings.Default.portdeger;
            txtregister.Text = Properties.Settings.Default.registervalue;
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
                int port = int.Parse(txtport.Text);
                tcpClient = new TcpClient(ipaddress, port);
                master = ModbusIpMaster.CreateIp(tcpClient);
                Logger.Log("Connected to Modbus device at "+ ipaddress+":"+ port );

                lblconnection.Text = "Connected";
                MessageBox.Show("Connected successfully");
            }
            catch (Exception ex)
            {

                lblconnection.Text = "Not Connected";
                MessageBox.Show($"Error: {ex.Message}");
                Logger.Log("An error occured while connecting to Modbus device: " + ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)


        {
            if (rbholding.Checked)
            {
                readregister("holding");

            }
            else if (rbinput.Checked)
            {
                readregister("input");
            }
            else if (rbcoil.Checked)
            {
                readregister("coil");

            }
            else if (rbdiscrete.Checked)
            {
                readregister("discrete");
            }
        }
        private void readregister(string type)
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
                ushort[] registers;
                bool[] values;

                if(type == "holding"){
                    registers = master.ReadHoldingRegisters(slaveId, startAddress, numberofpoints);
                    txtdata.Text = string.Join(", ", registers);
                }
                else if(type =="input")
                {
                    registers = master.ReadInputRegisters(slaveId, startAddress, numberofpoints);
                    txtdata.Text = string.Join(", ", registers);
                }
                else if(type == "coil")
                {
                    values= master.ReadCoils(slaveId,startAddress, numberofpoints);
                    txtdata.Text= string.Join(", ", values);
                }
                else if (type == "discrete")
                {
                    values= master.ReadInputs(slaveId, startAddress, numberofpoints);
                    txtdata.Text= string.Join (", ", values);
                }
            }
            catch(Exception ex) { 
                MessageBox.Show($"Error: {ex.Message}"); }

        }
            
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnwritecoil_Click(object sender, EventArgs e)
        {
            try
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = 1;
                ushort coiladdress = 0;
                bool coilvalue = true;
                master.WriteSingleCoil(slaveId, coiladdress, coilvalue);
                MessageBox.Show("Coil written succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void btnwriteregister_Click(object sender, EventArgs e)
        {
            
            
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = 1;
                ushort registeraddress = 0;
                ushort registervalue = ushort.Parse(txtregister.Text);
                master.WriteSingleRegister(slaveId, registeraddress, registervalue);
                MessageBox.Show("Register written succesfully.");
                
            
            
           
        }

        private void rbcoil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbholding_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbinput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbdiscrete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = 1;
                ushort coiladdress = 0;
                bool coilvalue = false;
                master.WriteSingleCoil(slaveId, coiladdress, coilvalue);
                MessageBox.Show("Coil written succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Do you want to keep your current values for next time?", "Save Settings", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    Properties.Settings.Default.ipadresi = txtipaddress.Text;
                    Properties.Settings.Default.portdeger = txtport.Text;
                    Properties.Settings.Default.registervalue = txtregister.Text;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.ipadresi = txtipaddress.Text;
                Properties.Settings.Default.portdeger = txtport.Text;
                Properties.Settings.Default.registervalue = txtregister.Text;
                Properties.Settings.Default.Save();
            }
        }
            

        private void btndriverfw_Click(object sender, EventArgs e)
        {

        }

        private void txtport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnviewlog_Click(object sender, EventArgs e)
        {
            txtlog.Text = Logger.readlog();
        }
    }
    public static class Logger
    {
        private static string logfilepath = "application.log";
        public static void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(logfilepath, true))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
        public static string readlog()
        {
            return File.ReadAllText(logfilepath);
        }
    }
}


