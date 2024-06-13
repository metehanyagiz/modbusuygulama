﻿using Modbus.Device;
using System;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;
using System.Text;


namespace modbusuygulama
{
    
    public partial class Form1 : Form
    {
        private IModbusMaster master;
        private TcpClient tcpClient;
        private int countdown;
       
        public Form1()
        {
            InitializeComponent();
            lblconnection.Text = "Disconnected";
            this.FormClosing += new FormClosingEventHandler(Form1_Load);
            this.Load += new EventHandler(Form1_Load);
            countdown = 5;
            timer1.Tick += new EventHandler(timer1_Tick);
            chkautorefresh.CheckedChanged += new EventHandler(chkautorefresh_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtipaddress.Text = Properties.Settings.Default.ipadresi;
            txtport.Text = Properties.Settings.Default.portdeger;
            txtregister.Text = Properties.Settings.Default.registervalue;
            txtcoiladd.Text = Properties.Settings.Default.coiladresi;
            txtregisteradd.Text = Properties.Settings.Default.registeradresi;
            txtnopoint.Text = Properties.Settings.Default.numberofpoi;
            txtstartadd.Text = Properties.Settings.Default.startadresi;
            txtslaveid.Text = Properties.Settings.Default.slavid;
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
                byte slaveId = byte.Parse(txtslaveid.Text);
                ushort startAddress = ushort.Parse(txtstartadd.Text);
                ushort numberofpoints = ushort.Parse(txtnopoint.Text);
                ushort[] registers;
                bool[] values;

                if(type == "holding"){
                    registers = master.ReadHoldingRegisters(slaveId, startAddress, numberofpoints);

                    
                    StringBuilder sonucsirala = new StringBuilder();
                    sonucsirala.Append($"Register values at address {startAddress} - {startAddress+numberofpoints}: ");
                    sonucsirala.AppendLine();
                    for (int i = 0; i< registers.Length; i++)
                    {
                        sonucsirala.AppendLine($"Register {startAddress+i}: {registers[i]}");


                    }

                    txtoutput.AppendText(sonucsirala.ToString());
                    lastregisterreading=sonucsirala.ToString();

                }
                else if(type =="input")
                {
                    registers = master.ReadInputRegisters(slaveId, startAddress, numberofpoints);


                    StringBuilder sonucsirala = new StringBuilder();
                    sonucsirala.Append($"Register values at address {startAddress} - {startAddress + numberofpoints}: ");
                    sonucsirala.AppendLine();
                    for (int i = 0; i < registers.Length; i++)
                    {
                        sonucsirala.AppendLine($"Register {startAddress + i}: {registers[i]}");


                    }
                    txtoutput.AppendText(sonucsirala.ToString());
                    lastregisterreading = sonucsirala.ToString();

                }
                else if(type == "coil")
                {
                    values= master.ReadCoils(slaveId,startAddress, numberofpoints);


                    StringBuilder sonucsirala = new StringBuilder();
                    sonucsirala.Append($"Coil values at address {startAddress} - {startAddress + numberofpoints}: ");
                    sonucsirala.AppendLine();
                    for (int i = 0; i < values.Length; i++)
                    {
                        sonucsirala.AppendLine($"Register {startAddress + i}: {values[i]}");


                    }
                    txtoutput.AppendText(sonucsirala.ToString());
                    lastregisterreading = sonucsirala.ToString();
                }
                else if (type == "discrete")
                {
                    values= master.ReadInputs(slaveId, startAddress, numberofpoints);

                    StringBuilder sonucsirala = new StringBuilder();
                    sonucsirala.Append($"Coil values at address {startAddress} - {startAddress + numberofpoints}: ");
                    sonucsirala.AppendLine();
                    for (int i = 0; i < values.Length; i++)
                    {
                        sonucsirala.AppendLine($"Register {startAddress + i}: {values[i]}");


                    }
                    txtoutput.AppendText(sonucsirala.ToString());
                    lastregisterreading = sonucsirala.ToString();
                }
            }
            catch(Exception ex) { 
                MessageBox.Show($"Error: {ex.Message}"); }

        }

        private string lastregisterreading = string.Empty;
        private void saveconfig(string filepath)
        {
            var config = new Config
            {
                ipcnfg = txtipaddress.Text,
                portcnfg = txtport.Text,
                registercnfg = txtregister.Text,
                coiladdcnfg = txtcoiladd.Text,
                registeraddcnfg = txtregisteradd.Text,
                nopointcnfg = txtnopoint.Text,
                startaddcnfg = txtstartadd.Text,
                slaveidcnfg = txtslaveid.Text,
            };
            string jsonstring= JsonSerializer.Serialize(config);
            File.WriteAllText(filepath, jsonstring);
        }
        private void loadconfig(string filepath)
        {
            string jsonstring= File.ReadAllText(filepath);
            var config=JsonSerializer.Deserialize<Config>(jsonstring);

            txtipaddress.Text = config.ipcnfg;
            txtport.Text = config.portcnfg;
            txtregister.Text=config.registercnfg;
            txtcoiladd.Text=config.coiladdcnfg;
            txtregisteradd.Text=config.registeraddcnfg;
            txtnopoint.Text=config.nopointcnfg;
            txtstartadd.Text=config.startaddcnfg;
            txtslaveid.Text=config.slaveidcnfg;
        }
        public class Config
        {
            public string ipcnfg { get; set; }
            public string portcnfg { get; set; }
            public string registercnfg { get; set; }
            public string coiladdcnfg { get; set; }
            public string registeraddcnfg { get; set; }
            public string nopointcnfg {  get; set; }
            public string startaddcnfg { get; set; }
            public string slaveidcnfg {  get; set; }
        }    
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //write coil true
        private void btnwritecoil_Click(object sender, EventArgs e)
        {
            try
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = byte.Parse(txtslaveid.Text);
                ushort coiladdress = ushort.Parse(txtcoiladd.Text);
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

                byte slaveId = byte.Parse(txtslaveid.Text);
                ushort registeraddress = ushort.Parse(txtregisteradd.Text);
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
        //write coil false
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = byte.Parse(txtslaveid.Text);
                ushort coiladdress = ushort.Parse(txtcoiladd.Text);
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
                    Properties.Settings.Default.coiladresi= txtcoiladd.Text;
                    Properties.Settings.Default.registeradresi=txtregisteradd.Text;
                    Properties.Settings.Default.numberofpoi=txtnopoint.Text;
                    Properties.Settings.Default.startadresi=txtstartadd.Text;
                    Properties.Settings.Default.slavid=txtslaveid.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.ipadresi = null;
                    Properties.Settings.Default.portdeger = null;
                    Properties.Settings.Default.registervalue = null;
                    Properties.Settings.Default.coiladresi = null;
                    Properties.Settings.Default.registeradresi = null;
                    Properties.Settings.Default.numberofpoi = null;
                    Properties.Settings.Default.startadresi = null;
                    Properties.Settings.Default.slavid = null;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.ipadresi = txtipaddress.Text;
                Properties.Settings.Default.portdeger = txtport.Text;
                Properties.Settings.Default.registervalue = txtregister.Text;
                Properties.Settings.Default.coiladresi = txtcoiladd.Text;
                Properties.Settings.Default.registeradresi = txtregisteradd.Text;
                Properties.Settings.Default.numberofpoi = txtnopoint.Text;
                Properties.Settings.Default.startadresi = txtstartadd.Text;
                Properties.Settings.Default.slavid = txtslaveid.Text;
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
            scrolllog();
            timer1.Start();
            lblrefresh.Text= countdown.ToString();
            countdown = 5;
            btnviewlog.Visible = false;
            
        }

        private void scrolllog()
        {
            txtlog.Text= Logger.readlog();
            if(chkautorefresh.Checked )
            {
                txtlog.SelectionStart = txtlog.Text.Length;
                txtlog.ScrollToCaret();
            }

        }

        private void btnsavecnfg_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "config.json");
            saveconfig(filepath);
            Logger.Log("Configuration saved to "+ filepath);
        }

        private void btnloadcnfg_Click(object sender, EventArgs e)
        {
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "config.json");
            if (File.Exists(filepath))
            {
                loadconfig(filepath);
                Logger.Log("Configuration loaded from " + filepath);
            }
            else
            {
                MessageBox.Show("Configuration file not found.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown <= 0)
            {
                scrolllog();
                countdown=5;
            }
            else
            {
                countdown--;
            }
            lblrefresh.Text = countdown.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblrefresh_Click(object sender, EventArgs e)
        {

        }

        private void chkautorefresh_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcopyclip_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lastregisterreading))
                    {
                    Clipboard.SetText(lastregisterreading);
                    MessageBox.Show("Register values copied to clipboard succesfully.");

                }
                else {
                    MessageBox.Show("No register reading to copy.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtclear_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            lastregisterreading = string.Empty;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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


