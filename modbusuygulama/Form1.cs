using Modbus.Device;
using System;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;


namespace modbusuygulama
{
    
    public partial class Form1 : Form
    {
        private IModbusMaster master;
        private TcpClient tcpClient;
        private NetworkStream stream;
       
        public Form1()
        {



            InitializeComponent();
            lblconnection.Text = "Disconnected";
            this.FormClosing += new FormClosingEventHandler(Form1_Load);
            this.Load += new EventHandler(Form1_Load);
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }


        //tabcontrol'un sekmelerini horizontal yapmaya yarayan microsoft kodu
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.DarkBlue);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        //uygulama kapatıldığında kaydedilen değerleri açınca geri çağıran kısım
        private void Form1_Load(object sender, EventArgs e)
        {
            txtipaddress.Text = Properties.Settings.Default.ipadresi;
            txtport.Text = Properties.Settings.Default.portdeger;
            txtaddressbox.Text = Properties.Settings.Default.anaadres;
            txtnopoint.Text = Properties.Settings.Default.numberofpoi;
            txtstartadd.Text = Properties.Settings.Default.startadresi;
            txtip_tcp.Text = Properties.Settings.Default.iptcp;
            txtport_tcp.Text = Properties.Settings.Default.porttcp;

            txtmainwrite.Text = Properties.Settings.Default.anadegerler;
        }

        private void combochannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //connect tuşu
        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ipaddress = txtipaddress.Text;
                lblipaddress.Text = ipaddress;
                int port = int.Parse(txtport.Text);
                tcpClient = new TcpClient(ipaddress, port);
                master = ModbusIpMaster.CreateIp(tcpClient);
                groupBox3.BackColor = Color.Green;
                lblconnection.Text = "Connected";

            }
            catch (Exception ex)
            {

                lblconnection.Text = "Disconnected";
                MessageBox.Show($"Error: {ex.Message}");
                groupBox3.BackColor=Color.Red;
            }
        }

        //seçilen radiobutton'a göre değer okuma 
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

        //değerleri okuyan esas fonksiyon
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

        //son reading'i kopyalama için gereken atama
        private string lastregisterreading = string.Empty;

        
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

        //kapanırken değerleri kaydetme ve tcp bağlantı koparma
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(stream != null)
                stream.Close();
            if(tcpClient!= null) 
                tcpClient.Close();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Do you want to keep your current values for next time?", "Save Settings", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Properties.Settings.Default.anadegerler = txtmainwrite.Text;
                    Properties.Settings.Default.ipadresi = txtipaddress.Text;
                    Properties.Settings.Default.portdeger = txtport.Text;
                    Properties.Settings.Default.anaadres = txtaddressbox.Text;
                    Properties.Settings.Default.numberofpoi=txtnopoint.Text;
                    Properties.Settings.Default.startadresi=txtstartadd.Text;
                    Properties.Settings.Default.iptcp = txtip_tcp.Text;
                    Properties.Settings.Default.porttcp = txtport_tcp.Text;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.anadegerler = null;
                    Properties.Settings.Default.ipadresi = null;
                    Properties.Settings.Default.portdeger = null;
                    Properties.Settings.Default.anaadres=null;
                    Properties.Settings.Default.numberofpoi = null;
                    Properties.Settings.Default.startadresi = null;
                    Properties.Settings.Default.iptcp = null;
                    Properties.Settings.Default.porttcp = null;

                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.anadegerler = txtmainwrite.Text;
                Properties.Settings.Default.ipadresi = txtipaddress.Text;
                Properties.Settings.Default.portdeger = txtport.Text;
                Properties.Settings.Default.anaadres = txtaddressbox.Text;
                Properties.Settings.Default.numberofpoi = txtnopoint.Text;
                Properties.Settings.Default.startadresi = txtstartadd.Text;
                Properties.Settings.Default.iptcp= txtip_tcp.Text;
                Properties.Settings.Default.porttcp=txtport_tcp.Text;


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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtoutput_TextChanged(object sender, EventArgs e)
        {

        }

        //son reading'i kopyalama fonksiyonu
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

        //reading kutusunu temizleme
        private void txtclear_Click(object sender, EventArgs e)
        {
            txtoutput.Clear();
            lastregisterreading = string.Empty;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
     
        //disconnect butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (master != null)
            {
                master.Dispose();
                master = null;
                lblconnection.Text = "Disconnected";
                groupBox3.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Already disconnected.");
            }
        }

        private void lblconnection_Click(object sender, EventArgs e)
        {

        }

        //yeni herseyi write etme kodu
        private void btnmainwrite_Click(object sender, EventArgs e)
        {
            string input = txtmainwrite.Text;
            categorizeinput(input);
        }
        private void categorizeinput(string input)
        {
            string multicoilpattern= @"^[a-zA-Z, \s]*$";
            string singlecoilpattern = @"^[a-zA-Z\s]*$";
            string singleregisterpattern = @"^[0-9\s]*$";
            string multiregisterpattern = @"^[0-9, \s]*$";

            if (Regex.IsMatch(input, multicoilpattern))
            {
                if(Regex.IsMatch (input, singlecoilpattern))
                {
                    try
                    {
                        if (master == null)
                        {
                            MessageBox.Show("Not connected to any Modbus device.");
                            return;
                        }

                        byte slaveId = 1;
                        ushort coiladdress = ushort.Parse(txtaddressbox.Text);
                        bool coilvalue = bool.Parse(txtmainwrite.Text);
                        master.WriteSingleCoil(slaveId, coiladdress, coilvalue);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error:{ex.Message}");
                    }
                }
                else
                {


                    try
                    {
                        if (master == null)
                        {
                            MessageBox.Show("Not connected to any Modbus device.");
                            return;
                        }

                        byte slaveId = 1;
                        ushort coiladdress = ushort.Parse(txtaddressbox.Text);
                        string[] values = txtmainwrite.Text.Split(new char[] { ',' });
                        bool[] coilvalue= new bool[values.Length];
                        for (int i = 0; i < values.Length; i++)
                        {
                            coilvalue[i] = bool.Parse(values[i]);
                        }


                        master.WriteMultipleCoils(slaveId, coiladdress, coilvalue);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error:{ex.Message}");
                    }

                }
            }
            else if (Regex.IsMatch(input,singleregisterpattern))
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }

                byte slaveId = 1;
                ushort registeraddress = ushort.Parse(txtaddressbox.Text);
                ushort registervalue = ushort.Parse(txtmainwrite.Text);
                master.WriteSingleRegister(slaveId, registeraddress, registervalue);
                
            }
            else if (Regex.IsMatch(input, multiregisterpattern))
            {
                if (master == null)
                {
                    MessageBox.Show("Not connected to any Modbus device.");
                    return;
                }
                try
                {
                    byte slaveid = 1;
                    string[] values = txtmainwrite.Text.Split(',');
                    ushort[] regvalues = new ushort[values.Length];
                    ushort registeraddress = ushort.Parse(txtaddressbox.Text);
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (!ushort.TryParse(values[i].Trim(), out regvalues[i]))
                        {
                            MessageBox.Show("Invalid value format.");
                            return;
                        }
                    }
                    master.WriteMultipleRegisters(slaveid, registeraddress, regvalues);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to register: {ex.Message}");
                }

            }
        }

        private void txtmainwrite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnopoint_TextChanged(object sender, EventArgs e)
        {

        }
        //reset tuşu
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmainwrite.Text = string.Empty;
            txtipaddress.Text = string.Empty;
            txtport.Text    = string.Empty;
            txtaddressbox.Text = string.Empty;
            txtnopoint.Text = string.Empty;
            txtstartadd.Text = string.Empty;

        }


        //tcp connect
        private void btnconnect_tcp_Click(object sender, EventArgs e)
        {
            
            try
            {
                string ipaddress = txtip_tcp.Text;
                lblipaddress.Text = ipaddress;
                int port = int.Parse(txtport_tcp.Text);
                tcpClient = new TcpClient(ipaddress, port);
                stream = tcpClient.GetStream();
                groupBox3.BackColor = Color.Green;
                lblconnection.Text = "Connected";
                
            }
            catch (Exception ex)
            {

                lblconnection.Text = "Disconnected";
                MessageBox.Show($"Error: {ex.Message}");
                groupBox3.BackColor = Color.Red;
            }
        }

        //tcp disconnect
        private void btndisconnect_tcp_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
                
                lblconnection.Text = "Disconnected";
                groupBox3.BackColor = Color.Red;
            }
            if (tcpClient != null)
            {
                tcpClient.Dispose();
                tcpClient = null;
            }
            else
            {
                MessageBox.Show("Already disconnected.");
            }
        }

        //tcp seçilen dosyadan ilk 54 byte okuma ve gönderme, gelen cevaba göre kalanı gönderme
        private void btnreadfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfiledialog = new OpenFileDialog();
                openfiledialog.Filter = "SNTL files (*.sntl)|*.sntl|All files (*.*)|*.*";

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilepath.Text = openfiledialog.FileName;
                }
               
            }
            catch (Exception ex) 
            {

                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private string sendbytes(byte[] data)
        {
            try
            {
                stream.Write(data, 0, data.Length);

                tcpClient.ReceiveTimeout = 2000; // ACCEPTED mesajını ne kadar bekleyecek, süre dolunca connection terminated

                byte[] responsebuff = new byte[1024];
                int byteread = stream.Read(responsebuff, 0, responsebuff.Length);
                string response = Encoding.UTF8.GetString(responsebuff, 0, byteread);
                return response;
            }
            catch (Exception ex) {
            MessageBox.Show($"An error occured while sending data: {ex.Message}");
                return null;
            }
        }
        private void sendotherbytes(FileStream fstrm)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int byteread;

                while((byteread=fstrm.Read(buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, byteread);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while sending rest of the data: {ex.Message}");
            }
        }

        //tcp sekmesindeki textboxları sıfırlama
        private void btnresettcp_Click(object sender, EventArgs e)
        {
            txtport_tcp.Text = string.Empty;
            txtip_tcp.Text = string.Empty;
            txtfilepath.Text = string.Empty;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string filepath = txtfilepath.Text;


            using (FileStream fstrm = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                byte[] first54 = new byte[54];
                fstrm.Read(first54, 0, 54);

                string response = sendbytes(first54);

                if (response == "ACCEPTED")
                {
                    sendotherbytes(fstrm);
                }
                else
                {

                    groupBox3.BackColor = Color.Red;
                    lblconnection.Text = "Disconnected";
                }

            }
        }

        private void txtfilepath_TextChanged(object sender, EventArgs e)
        {

        }

    }

}


