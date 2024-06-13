namespace modbusuygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblipaddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblconnection = new System.Windows.Forms.Label();
            this.combochannel = new System.Windows.Forms.ComboBox();
            this.comboaddress = new System.Windows.Forms.ComboBox();
            this.btndebug = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnmaestrofw = new System.Windows.Forms.Button();
            this.lbldeviceinfo = new System.Windows.Forms.Label();
            this.combocommand = new System.Windows.Forms.ComboBox();
            this.comboquery = new System.Windows.Forms.ComboBox();
            this.btndriverfw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.txtipaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnread = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnwritetrue = new System.Windows.Forms.Button();
            this.btnwriteregister = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.txtslaveid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnopoint = new System.Windows.Forms.TextBox();
            this.txtstartadd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnloadcnfg = new System.Windows.Forms.Button();
            this.btnsavecnfg = new System.Windows.Forms.Button();
            this.rbholding = new System.Windows.Forms.RadioButton();
            this.rbdiscrete = new System.Windows.Forms.RadioButton();
            this.rbcoil = new System.Windows.Forms.RadioButton();
            this.rbinput = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnwritefalse = new System.Windows.Forms.Button();
            this.txtregister = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmultireg = new System.Windows.Forms.Button();
            this.txtregisteradd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcoiladd = new System.Windows.Forms.TextBox();
            this.btnviewlog = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblrefresh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkautorefresh = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.txtcopyclip = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtaddressbox = new System.Windows.Forms.TextBox();
            this.txtmainwrite = new System.Windows.Forms.TextBox();
            this.btnmainwrite = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maestro IP Address:";
            // 
            // lblipaddress
            // 
            this.lblipaddress.AutoSize = true;
            this.lblipaddress.Location = new System.Drawing.Point(310, 20);
            this.lblipaddress.Name = "lblipaddress";
            this.lblipaddress.Size = new System.Drawing.Size(61, 16);
            this.lblipaddress.TabIndex = 1;
            this.lblipaddress.Text = "Waiting...";
            this.lblipaddress.Click += new System.EventHandler(this.lblipaddress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection Status:";
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.Location = new System.Drawing.Point(572, 20);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(159, 16);
            this.lblconnection.TabIndex = 3;
            this.lblconnection.Text = "Connected/Disconnected";
            this.lblconnection.Click += new System.EventHandler(this.lblconnection_Click);
            // 
            // combochannel
            // 
            this.combochannel.FormattingEnabled = true;
            this.combochannel.Items.AddRange(new object[] {
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Channel 5",
            "Channel 6",
            "Channel 7",
            "Channel 8",
            "Channel 9"});
            this.combochannel.Location = new System.Drawing.Point(6, 21);
            this.combochannel.Name = "combochannel";
            this.combochannel.Size = new System.Drawing.Size(121, 24);
            this.combochannel.TabIndex = 4;
            this.combochannel.Text = "Channel";
            this.combochannel.SelectedIndexChanged += new System.EventHandler(this.combochannel_SelectedIndexChanged);
            // 
            // comboaddress
            // 
            this.comboaddress.FormattingEnabled = true;
            this.comboaddress.Items.AddRange(new object[] {
            "Address 1",
            "Address 2",
            "Address 3",
            "Address 4",
            "Address 5",
            "Address 6",
            "Address 7",
            "Address 8",
            "Address 9"});
            this.comboaddress.Location = new System.Drawing.Point(138, 21);
            this.comboaddress.Name = "comboaddress";
            this.comboaddress.Size = new System.Drawing.Size(121, 24);
            this.comboaddress.TabIndex = 5;
            this.comboaddress.Text = "Address";
            // 
            // btndebug
            // 
            this.btndebug.Location = new System.Drawing.Point(22, 116);
            this.btndebug.Name = "btndebug";
            this.btndebug.Size = new System.Drawing.Size(146, 23);
            this.btndebug.TabIndex = 6;
            this.btndebug.Text = "Debug Mode";
            this.btndebug.UseVisualStyleBackColor = true;
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(22, 145);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(146, 23);
            this.btnlog.TabIndex = 7;
            this.btnlog.Text = "Retrieve Logs";
            this.btnlog.UseVisualStyleBackColor = true;
            // 
            // btnmaestrofw
            // 
            this.btnmaestrofw.Location = new System.Drawing.Point(22, 174);
            this.btnmaestrofw.Name = "btnmaestrofw";
            this.btnmaestrofw.Size = new System.Drawing.Size(146, 23);
            this.btnmaestrofw.TabIndex = 8;
            this.btnmaestrofw.Text = "Update Maestro FW";
            this.btnmaestrofw.UseVisualStyleBackColor = true;
            // 
            // lbldeviceinfo
            // 
            this.lbldeviceinfo.AutoSize = true;
            this.lbldeviceinfo.Location = new System.Drawing.Point(6, 71);
            this.lbldeviceinfo.Name = "lbldeviceinfo";
            this.lbldeviceinfo.Size = new System.Drawing.Size(121, 16);
            this.lbldeviceinfo.TabIndex = 9;
            this.lbldeviceinfo.Text = "Device Information:";
            // 
            // combocommand
            // 
            this.combocommand.BackColor = System.Drawing.Color.DarkGreen;
            this.combocommand.ForeColor = System.Drawing.Color.Azure;
            this.combocommand.FormattingEnabled = true;
            this.combocommand.Items.AddRange(new object[] {
            "XX",
            "YY",
            "ZZ"});
            this.combocommand.Location = new System.Drawing.Point(9, 178);
            this.combocommand.Name = "combocommand";
            this.combocommand.Size = new System.Drawing.Size(96, 24);
            this.combocommand.TabIndex = 10;
            this.combocommand.Text = "Command";
            // 
            // comboquery
            // 
            this.comboquery.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.comboquery.ForeColor = System.Drawing.Color.Azure;
            this.comboquery.FormattingEnabled = true;
            this.comboquery.Items.AddRange(new object[] {
            "XX",
            "YY",
            "ZZ"});
            this.comboquery.Location = new System.Drawing.Point(151, 178);
            this.comboquery.Name = "comboquery";
            this.comboquery.Size = new System.Drawing.Size(77, 24);
            this.comboquery.TabIndex = 11;
            this.comboquery.Text = "Query";
            // 
            // btndriverfw
            // 
            this.btndriverfw.Location = new System.Drawing.Point(62, 225);
            this.btndriverfw.Name = "btndriverfw";
            this.btndriverfw.Size = new System.Drawing.Size(137, 23);
            this.btndriverfw.TabIndex = 13;
            this.btndriverfw.Text = "Update Driver FW";
            this.btndriverfw.UseVisualStyleBackColor = true;
            this.btndriverfw.Click += new System.EventHandler(this.btndriverfw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Maestro Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndebug);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnlog);
            this.groupBox1.Controls.Add(this.btnmaestrofw);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(31, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 220);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboquery);
            this.groupBox2.Controls.Add(this.combocommand);
            this.groupBox2.Controls.Add(this.combochannel);
            this.groupBox2.Controls.Add(this.comboaddress);
            this.groupBox2.Controls.Add(this.lbldeviceinfo);
            this.groupBox2.Controls.Add(this.btndriverfw);
            this.groupBox2.Location = new System.Drawing.Point(297, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 271);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblipaddress);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblconnection);
            this.groupBox3.Location = new System.Drawing.Point(12, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 52);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(951, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(43, 165);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(156, 42);
            this.btnconnect.TabIndex = 9;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // txtipaddress
            // 
            this.txtipaddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtipaddress.Location = new System.Drawing.Point(111, 72);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(100, 22);
            this.txtipaddress.TabIndex = 4;
            this.txtipaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter necessary information to connect";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(338, 431);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(156, 75);
            this.btnread.TabIndex = 14;
            this.btnread.Text = "Read ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(111, 97);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 22);
            this.txtport.TabIndex = 5;
            this.txtport.TextChanged += new System.EventHandler(this.txtport_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "IP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Port :";
            // 
            // btnwritetrue
            // 
            this.btnwritetrue.Location = new System.Drawing.Point(303, 21);
            this.btnwritetrue.Name = "btnwritetrue";
            this.btnwritetrue.Size = new System.Drawing.Size(123, 23);
            this.btnwritetrue.TabIndex = 16;
            this.btnwritetrue.Text = "Write Coil True";
            this.btnwritetrue.UseVisualStyleBackColor = true;
            this.btnwritetrue.Click += new System.EventHandler(this.btnwritecoil_Click);
            // 
            // btnwriteregister
            // 
            this.btnwriteregister.Location = new System.Drawing.Point(144, 177);
            this.btnwriteregister.Name = "btnwriteregister";
            this.btnwriteregister.Size = new System.Drawing.Size(125, 23);
            this.btnwriteregister.TabIndex = 20;
            this.btnwriteregister.Text = "Write Register";
            this.btnwriteregister.UseVisualStyleBackColor = true;
            this.btnwriteregister.Click += new System.EventHandler(this.btnwriteregister_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btndisconnect);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnconnect);
            this.groupBox4.Controls.Add(this.txtipaddress);
            this.groupBox4.Controls.Add(this.txtport);
            this.groupBox4.Controls.Add(this.txtslaveid);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(32, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 281);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connect";
            // 
            // btndisconnect
            // 
            this.btndisconnect.Location = new System.Drawing.Point(43, 220);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(156, 44);
            this.btndisconnect.TabIndex = 47;
            this.btndisconnect.Text = "Disconnect";
            this.btndisconnect.UseVisualStyleBackColor = true;
            this.btndisconnect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtslaveid
            // 
            this.txtslaveid.Location = new System.Drawing.Point(111, 125);
            this.txtslaveid.Name = "txtslaveid";
            this.txtslaveid.Size = new System.Drawing.Size(100, 22);
            this.txtslaveid.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Slave ID :";
            // 
            // txtnopoint
            // 
            this.txtnopoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnopoint.Location = new System.Drawing.Point(131, 59);
            this.txtnopoint.Name = "txtnopoint";
            this.txtnopoint.Size = new System.Drawing.Size(142, 23);
            this.txtnopoint.TabIndex = 8;
            this.txtnopoint.TextChanged += new System.EventHandler(this.txtnopoint_TextChanged);
            // 
            // txtstartadd
            // 
            this.txtstartadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstartadd.Location = new System.Drawing.Point(131, 24);
            this.txtstartadd.Name = "txtstartadd";
            this.txtstartadd.Size = new System.Drawing.Size(142, 23);
            this.txtstartadd.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "No. of Values :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(10, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Start Address :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnloadcnfg
            // 
            this.btnloadcnfg.Location = new System.Drawing.Point(84, 537);
            this.btnloadcnfg.Name = "btnloadcnfg";
            this.btnloadcnfg.Size = new System.Drawing.Size(235, 23);
            this.btnloadcnfg.TabIndex = 43;
            this.btnloadcnfg.Text = "Load profile";
            this.btnloadcnfg.UseVisualStyleBackColor = true;
            this.btnloadcnfg.Click += new System.EventHandler(this.btnloadcnfg_Click);
            // 
            // btnsavecnfg
            // 
            this.btnsavecnfg.Location = new System.Drawing.Point(84, 498);
            this.btnsavecnfg.Name = "btnsavecnfg";
            this.btnsavecnfg.Size = new System.Drawing.Size(235, 23);
            this.btnsavecnfg.TabIndex = 42;
            this.btnsavecnfg.Text = "Save current profile";
            this.btnsavecnfg.UseVisualStyleBackColor = true;
            this.btnsavecnfg.Click += new System.EventHandler(this.btnsavecnfg_Click);
            // 
            // rbholding
            // 
            this.rbholding.AutoSize = true;
            this.rbholding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbholding.Location = new System.Drawing.Point(13, 107);
            this.rbholding.Name = "rbholding";
            this.rbholding.Size = new System.Drawing.Size(134, 21);
            this.rbholding.TabIndex = 10;
            this.rbholding.TabStop = true;
            this.rbholding.Text = "Holding Register";
            this.rbholding.UseVisualStyleBackColor = true;
            this.rbholding.CheckedChanged += new System.EventHandler(this.rbholding_CheckedChanged);
            // 
            // rbdiscrete
            // 
            this.rbdiscrete.AutoSize = true;
            this.rbdiscrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbdiscrete.Location = new System.Drawing.Point(14, 188);
            this.rbdiscrete.Name = "rbdiscrete";
            this.rbdiscrete.Size = new System.Drawing.Size(116, 21);
            this.rbdiscrete.TabIndex = 13;
            this.rbdiscrete.TabStop = true;
            this.rbdiscrete.Text = "Discrete Input";
            this.rbdiscrete.UseVisualStyleBackColor = true;
            this.rbdiscrete.CheckedChanged += new System.EventHandler(this.rbdiscrete_CheckedChanged);
            // 
            // rbcoil
            // 
            this.rbcoil.AutoSize = true;
            this.rbcoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbcoil.Location = new System.Drawing.Point(13, 162);
            this.rbcoil.Name = "rbcoil";
            this.rbcoil.Size = new System.Drawing.Size(52, 21);
            this.rbcoil.TabIndex = 11;
            this.rbcoil.TabStop = true;
            this.rbcoil.Text = "Coil";
            this.rbcoil.UseVisualStyleBackColor = true;
            this.rbcoil.CheckedChanged += new System.EventHandler(this.rbcoil_CheckedChanged);
            // 
            // rbinput
            // 
            this.rbinput.AutoSize = true;
            this.rbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbinput.Location = new System.Drawing.Point(13, 136);
            this.rbinput.Name = "rbinput";
            this.rbinput.Size = new System.Drawing.Size(117, 21);
            this.rbinput.TabIndex = 12;
            this.rbinput.TabStop = true;
            this.rbinput.Text = "Input Register";
            this.rbinput.UseVisualStyleBackColor = true;
            this.rbinput.CheckedChanged += new System.EventHandler(this.rbinput_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbholding);
            this.groupBox5.Controls.Add(this.rbinput);
            this.groupBox5.Controls.Add(this.rbcoil);
            this.groupBox5.Controls.Add(this.rbdiscrete);
            this.groupBox5.Controls.Add(this.txtnopoint);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtstartadd);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(32, 347);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 217);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Read";
            // 
            // btnwritefalse
            // 
            this.btnwritefalse.Location = new System.Drawing.Point(302, 50);
            this.btnwritefalse.Name = "btnwritefalse";
            this.btnwritefalse.Size = new System.Drawing.Size(124, 23);
            this.btnwritefalse.TabIndex = 17;
            this.btnwritefalse.Text = "Write Coil False";
            this.btnwritefalse.UseVisualStyleBackColor = true;
            this.btnwritefalse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtregister
            // 
            this.txtregister.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtregister.Location = new System.Drawing.Point(137, 149);
            this.txtregister.Name = "txtregister";
            this.txtregister.Size = new System.Drawing.Size(132, 22);
            this.txtregister.TabIndex = 19;
            this.txtregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtregister.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Register Value :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.btnmultireg);
            this.groupBox6.Controls.Add(this.txtregisteradd);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtcoiladd);
            this.groupBox6.Controls.Add(this.btnwritetrue);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.btnwritefalse);
            this.groupBox6.Controls.Add(this.btnwriteregister);
            this.groupBox6.Controls.Add(this.txtregister);
            this.groupBox6.Location = new System.Drawing.Point(393, 77);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(461, 483);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 2b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "(values should be seperated by commas)";
            // 
            // btnmultireg
            // 
            this.btnmultireg.Location = new System.Drawing.Point(40, 227);
            this.btnmultireg.Name = "btnmultireg";
            this.btnmultireg.Size = new System.Drawing.Size(200, 23);
            this.btnmultireg.TabIndex = 42;
            this.btnmultireg.Text = "Write Multiple Registers";
            this.btnmultireg.UseVisualStyleBackColor = true;
            this.btnmultireg.Click += new System.EventHandler(this.btnmultireg_Click);
            // 
            // txtregisteradd
            // 
            this.txtregisteradd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtregisteradd.Location = new System.Drawing.Point(137, 110);
            this.txtregisteradd.Name = "txtregisteradd";
            this.txtregisteradd.Size = new System.Drawing.Size(132, 22);
            this.txtregisteradd.TabIndex = 18;
            this.txtregisteradd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtregisteradd.TextChanged += new System.EventHandler(this.txtregisteradd_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Register Address :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Coil Address :";
            // 
            // txtcoiladd
            // 
            this.txtcoiladd.Location = new System.Drawing.Point(137, 28);
            this.txtcoiladd.Name = "txtcoiladd";
            this.txtcoiladd.Size = new System.Drawing.Size(132, 22);
            this.txtcoiladd.TabIndex = 15;
            this.txtcoiladd.TextChanged += new System.EventHandler(this.txtcoiladd_TextChanged);
            // 
            // btnviewlog
            // 
            this.btnviewlog.Location = new System.Drawing.Point(169, 326);
            this.btnviewlog.Name = "btnviewlog";
            this.btnviewlog.Size = new System.Drawing.Size(83, 23);
            this.btnviewlog.TabIndex = 40;
            this.btnviewlog.Text = "Initialize";
            this.btnviewlog.UseVisualStyleBackColor = true;
            this.btnviewlog.Click += new System.EventHandler(this.btnviewlog_Click);
            // 
            // txtlog
            // 
            this.txtlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtlog.Location = new System.Drawing.Point(6, 21);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(250, 295);
            this.txtlog.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblrefresh
            // 
            this.lblrefresh.AutoSize = true;
            this.lblrefresh.Location = new System.Drawing.Point(100, 329);
            this.lblrefresh.Name = "lblrefresh";
            this.lblrefresh.Size = new System.Drawing.Size(44, 16);
            this.lblrefresh.TabIndex = 44;
            this.lblrefresh.Text = "Never";
            this.lblrefresh.Click += new System.EventHandler(this.lblrefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Next refresh in";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // chkautorefresh
            // 
            this.chkautorefresh.AutoSize = true;
            this.chkautorefresh.Location = new System.Drawing.Point(6, 355);
            this.chkautorefresh.Name = "chkautorefresh";
            this.chkautorefresh.Size = new System.Drawing.Size(171, 20);
            this.chkautorefresh.TabIndex = 46;
            this.chkautorefresh.Text = "Auto scroll log to bottom";
            this.chkautorefresh.UseVisualStyleBackColor = true;
            this.chkautorefresh.CheckedChanged += new System.EventHandler(this.chkautorefresh_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtlog);
            this.groupBox7.Controls.Add(this.chkautorefresh);
            this.groupBox7.Controls.Add(this.lblrefresh);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.btnviewlog);
            this.groupBox7.Location = new System.Drawing.Point(84, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(275, 396);
            this.groupBox7.TabIndex = 48;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Log";
            // 
            // txtoutput
            // 
            this.txtoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtoutput.Location = new System.Drawing.Point(17, 27);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ReadOnly = true;
            this.txtoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtoutput.Size = new System.Drawing.Size(266, 372);
            this.txtoutput.TabIndex = 49;
            this.txtoutput.TextChanged += new System.EventHandler(this.txtoutput_TextChanged);
            // 
            // txtcopyclip
            // 
            this.txtcopyclip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcopyclip.Location = new System.Drawing.Point(17, 405);
            this.txtcopyclip.Name = "txtcopyclip";
            this.txtcopyclip.Size = new System.Drawing.Size(266, 23);
            this.txtcopyclip.TabIndex = 50;
            this.txtcopyclip.Text = "Copy last reading to the clipboard";
            this.txtcopyclip.UseVisualStyleBackColor = true;
            this.txtcopyclip.Click += new System.EventHandler(this.txtcopyclip_Click);
            // 
            // txtclear
            // 
            this.txtclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtclear.Location = new System.Drawing.Point(17, 434);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(266, 23);
            this.txtclear.TabIndex = 51;
            this.txtclear.Text = "Clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.txtclear_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtoutput);
            this.groupBox8.Controls.Add(this.txtclear);
            this.groupBox8.Controls.Add(this.txtcopyclip);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(558, 197);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 487);
            this.groupBox8.TabIndex = 52;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Readings";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 100);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 778);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnread);
            this.tabPage2.Controls.Add(this.btnmainwrite);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 770);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modbus";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.txtaddressbox);
            this.groupBox9.Controls.Add(this.txtmainwrite);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.Location = new System.Drawing.Point(32, 585);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(279, 169);
            this.groupBox9.TabIndex = 54;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Write";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(10, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 17);
            this.label16.TabIndex = 58;
            this.label16.Text = "Value(s) to write :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(10, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Starting Address: ";
            // 
            // txtaddressbox
            // 
            this.txtaddressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaddressbox.Location = new System.Drawing.Point(134, 29);
            this.txtaddressbox.Name = "txtaddressbox";
            this.txtaddressbox.Size = new System.Drawing.Size(139, 23);
            this.txtaddressbox.TabIndex = 56;
            // 
            // txtmainwrite
            // 
            this.txtmainwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmainwrite.Location = new System.Drawing.Point(131, 80);
            this.txtmainwrite.Multiline = true;
            this.txtmainwrite.Name = "txtmainwrite";
            this.txtmainwrite.Size = new System.Drawing.Size(142, 70);
            this.txtmainwrite.TabIndex = 53;
            this.txtmainwrite.TextChanged += new System.EventHandler(this.txtmainwrite_TextChanged);
            // 
            // btnmainwrite
            // 
            this.btnmainwrite.Location = new System.Drawing.Point(338, 644);
            this.btnmainwrite.Name = "btnmainwrite";
            this.btnmainwrite.Size = new System.Drawing.Size(156, 75);
            this.btnmainwrite.TabIndex = 55;
            this.btnmainwrite.Text = "Write";
            this.btnmainwrite.UseVisualStyleBackColor = true;
            this.btnmainwrite.Click += new System.EventHandler(this.btnmainwrite_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 770);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maestro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.btnsavecnfg);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.btnloadcnfg);
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1173, 770);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Deneme Özellikleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1037, 843);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "SentiPort v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblipaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblconnection;
        private System.Windows.Forms.ComboBox combochannel;
        private System.Windows.Forms.ComboBox comboaddress;
        private System.Windows.Forms.Button btndebug;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnmaestrofw;
        private System.Windows.Forms.Label lbldeviceinfo;
        private System.Windows.Forms.ComboBox combocommand;
        private System.Windows.Forms.ComboBox comboquery;
        private System.Windows.Forms.Button btndriverfw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TextBox txtipaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnwritetrue;
        private System.Windows.Forms.Button btnwriteregister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbholding;
        private System.Windows.Forms.RadioButton rbdiscrete;
        private System.Windows.Forms.RadioButton rbcoil;
        private System.Windows.Forms.RadioButton rbinput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnwritefalse;
        private System.Windows.Forms.TextBox txtregister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnviewlog;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Button btnsavecnfg;
        private System.Windows.Forms.Button btnloadcnfg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblrefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkautorefresh;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtslaveid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnopoint;
        private System.Windows.Forms.TextBox txtstartadd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcoiladd;
        private System.Windows.Forms.TextBox txtregisteradd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button txtcopyclip;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnmultireg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.TextBox txtmainwrite;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnmainwrite;
        private System.Windows.Forms.TextBox txtaddressbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

