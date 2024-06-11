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
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnwritetrue = new System.Windows.Forms.Button();
            this.btnwriteregister = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbholding = new System.Windows.Forms.RadioButton();
            this.rbdiscrete = new System.Windows.Forms.RadioButton();
            this.rbcoil = new System.Windows.Forms.RadioButton();
            this.rbinput = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnwritefalse = new System.Windows.Forms.Button();
            this.txtregister = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnviewlog = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maestro IP Address:";
            // 
            // lblipaddress
            // 
            this.lblipaddress.AutoSize = true;
            this.lblipaddress.Location = new System.Drawing.Point(140, 32);
            this.lblipaddress.Name = "lblipaddress";
            this.lblipaddress.Size = new System.Drawing.Size(61, 16);
            this.lblipaddress.TabIndex = 1;
            this.lblipaddress.Text = "Waiting...";
            this.lblipaddress.Click += new System.EventHandler(this.lblipaddress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection Status:";
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.Location = new System.Drawing.Point(402, 32);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(159, 16);
            this.lblconnection.TabIndex = 3;
            this.lblconnection.Text = "Connected/Disconnected";
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
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 218);
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
            this.groupBox2.Location = new System.Drawing.Point(248, 95);
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
            this.groupBox3.Location = new System.Drawing.Point(16, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 66);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 692);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(59, 142);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(115, 23);
            this.btnconnect.TabIndex = 14;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // txtipaddress
            // 
            this.txtipaddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtipaddress.Location = new System.Drawing.Point(67, 63);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(132, 22);
            this.txtipaddress.TabIndex = 4;
            this.txtipaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter an IP address and port to connect";
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(59, 97);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(165, 23);
            this.btnread.TabIndex = 20;
            this.btnread.Text = "Read ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(307, 541);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 22);
            this.txtdata.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reading";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(67, 91);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(48, 22);
            this.txtport.TabIndex = 23;
            this.txtport.TextChanged += new System.EventHandler(this.txtport_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "IP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Port :";
            // 
            // btnwritetrue
            // 
            this.btnwritetrue.Location = new System.Drawing.Point(16, 29);
            this.btnwritetrue.Name = "btnwritetrue";
            this.btnwritetrue.Size = new System.Drawing.Size(125, 23);
            this.btnwritetrue.TabIndex = 29;
            this.btnwritetrue.Text = "Write Coil True";
            this.btnwritetrue.UseVisualStyleBackColor = true;
            this.btnwritetrue.Click += new System.EventHandler(this.btnwritecoil_Click);
            // 
            // btnwriteregister
            // 
            this.btnwriteregister.Location = new System.Drawing.Point(112, 133);
            this.btnwriteregister.Name = "btnwriteregister";
            this.btnwriteregister.Size = new System.Drawing.Size(160, 23);
            this.btnwriteregister.TabIndex = 30;
            this.btnwriteregister.Text = "Write Register";
            this.btnwriteregister.UseVisualStyleBackColor = true;
            this.btnwriteregister.Click += new System.EventHandler(this.btnwriteregister_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnconnect);
            this.groupBox4.Controls.Add(this.txtipaddress);
            this.groupBox4.Controls.Add(this.txtport);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 248);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 1";
            // 
            // rbholding
            // 
            this.rbholding.AutoSize = true;
            this.rbholding.Location = new System.Drawing.Point(16, 28);
            this.rbholding.Name = "rbholding";
            this.rbholding.Size = new System.Drawing.Size(129, 20);
            this.rbholding.TabIndex = 32;
            this.rbholding.TabStop = true;
            this.rbholding.Text = "Holding Register";
            this.rbholding.UseVisualStyleBackColor = true;
            this.rbholding.CheckedChanged += new System.EventHandler(this.rbholding_CheckedChanged);
            // 
            // rbdiscrete
            // 
            this.rbdiscrete.AutoSize = true;
            this.rbdiscrete.Location = new System.Drawing.Point(151, 58);
            this.rbdiscrete.Name = "rbdiscrete";
            this.rbdiscrete.Size = new System.Drawing.Size(109, 20);
            this.rbdiscrete.TabIndex = 33;
            this.rbdiscrete.TabStop = true;
            this.rbdiscrete.Text = "Discrete Input";
            this.rbdiscrete.UseVisualStyleBackColor = true;
            this.rbdiscrete.CheckedChanged += new System.EventHandler(this.rbdiscrete_CheckedChanged);
            // 
            // rbcoil
            // 
            this.rbcoil.AutoSize = true;
            this.rbcoil.Location = new System.Drawing.Point(151, 28);
            this.rbcoil.Name = "rbcoil";
            this.rbcoil.Size = new System.Drawing.Size(51, 20);
            this.rbcoil.TabIndex = 34;
            this.rbcoil.TabStop = true;
            this.rbcoil.Text = "Coil";
            this.rbcoil.UseVisualStyleBackColor = true;
            this.rbcoil.CheckedChanged += new System.EventHandler(this.rbcoil_CheckedChanged);
            // 
            // rbinput
            // 
            this.rbinput.AutoSize = true;
            this.rbinput.Location = new System.Drawing.Point(16, 57);
            this.rbinput.Name = "rbinput";
            this.rbinput.Size = new System.Drawing.Size(110, 20);
            this.rbinput.TabIndex = 35;
            this.rbinput.TabStop = true;
            this.rbinput.Text = "Input Register";
            this.rbinput.UseVisualStyleBackColor = true;
            this.rbinput.CheckedChanged += new System.EventHandler(this.rbinput_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbholding);
            this.groupBox5.Controls.Add(this.rbinput);
            this.groupBox5.Controls.Add(this.btnread);
            this.groupBox5.Controls.Add(this.rbcoil);
            this.groupBox5.Controls.Add(this.rbdiscrete);
            this.groupBox5.Location = new System.Drawing.Point(273, 377);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 139);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 2a";
            // 
            // btnwritefalse
            // 
            this.btnwritefalse.Location = new System.Drawing.Point(148, 29);
            this.btnwritefalse.Name = "btnwritefalse";
            this.btnwritefalse.Size = new System.Drawing.Size(124, 23);
            this.btnwritefalse.TabIndex = 37;
            this.btnwritefalse.Text = "Write Coil False";
            this.btnwritefalse.UseVisualStyleBackColor = true;
            this.btnwritefalse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtregister
            // 
            this.txtregister.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtregister.Location = new System.Drawing.Point(126, 95);
            this.txtregister.Name = "txtregister";
            this.txtregister.Size = new System.Drawing.Size(132, 22);
            this.txtregister.TabIndex = 26;
            this.txtregister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtregister.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Register Value";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnwritetrue);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.btnwritefalse);
            this.groupBox6.Controls.Add(this.btnwriteregister);
            this.groupBox6.Controls.Add(this.txtregister);
            this.groupBox6.Location = new System.Drawing.Point(273, 584);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 171);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 2b";
            // 
            // btnviewlog
            // 
            this.btnviewlog.Location = new System.Drawing.Point(686, 106);
            this.btnviewlog.Name = "btnviewlog";
            this.btnviewlog.Size = new System.Drawing.Size(83, 23);
            this.btnviewlog.TabIndex = 40;
            this.btnviewlog.Text = "View Log";
            this.btnviewlog.UseVisualStyleBackColor = true;
            this.btnviewlog.Click += new System.EventHandler(this.btnviewlog_Click);
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(686, 149);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(250, 295);
            this.txtlog.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 767);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btnviewlog);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label5;
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
    }
}

