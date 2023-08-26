
namespace Latihan3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndaftar = new System.Windows.Forms.Button();
            this.cbtahun = new System.Windows.Forms.ComboBox();
            this.cbbulan = new System.Windows.Forms.ComboBox();
            this.cbhari = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttempat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnomorhp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpendaftaran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttanggaldaftar = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kalender = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txthasil = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulir Pendaftaran Siswa Baru\r\nTahun 2023\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbperempuan);
            this.groupBox1.Controls.Add(this.rblaki);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btndaftar);
            this.groupBox1.Controls.Add(this.cbtahun);
            this.groupBox1.Controls.Add(this.cbbulan);
            this.groupBox1.Controls.Add(this.cbhari);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttempat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnomorhp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpendaftaran);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Location = new System.Drawing.Point(220, 249);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(79, 17);
            this.rbperempuan.TabIndex = 23;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "Perempuan";
            this.rbperempuan.UseVisualStyleBackColor = true;
            this.rbperempuan.CheckedChanged += new System.EventHandler(this.rbperempuan_CheckedChanged);
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Location = new System.Drawing.Point(122, 249);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(68, 17);
            this.rblaki.TabIndex = 22;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "Laki-Laki";
            this.rblaki.UseVisualStyleBackColor = true;
            this.rblaki.CheckedChanged += new System.EventHandler(this.rblaki_CheckedChanged);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(231, 439);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(84, 34);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(128, 439);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(84, 34);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndaftar
            // 
            this.btndaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndaftar.Location = new System.Drawing.Point(21, 439);
            this.btndaftar.Name = "btndaftar";
            this.btndaftar.Size = new System.Drawing.Size(89, 34);
            this.btndaftar.TabIndex = 19;
            this.btndaftar.Text = "DAFTAR";
            this.btndaftar.UseVisualStyleBackColor = true;
            this.btndaftar.Click += new System.EventHandler(this.btndaftar_Click);
            // 
            // cbtahun
            // 
            this.cbtahun.FormattingEnabled = true;
            this.cbtahun.Items.AddRange(new object[] {
            "",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009"});
            this.cbtahun.Location = new System.Drawing.Point(261, 322);
            this.cbtahun.Name = "cbtahun";
            this.cbtahun.Size = new System.Drawing.Size(61, 21);
            this.cbtahun.TabIndex = 18;
            // 
            // cbbulan
            // 
            this.cbbulan.FormattingEnabled = true;
            this.cbbulan.Items.AddRange(new object[] {
            "",
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cbbulan.Location = new System.Drawing.Point(166, 323);
            this.cbbulan.Name = "cbbulan";
            this.cbbulan.Size = new System.Drawing.Size(88, 21);
            this.cbbulan.TabIndex = 17;
            this.cbbulan.SelectedIndexChanged += new System.EventHandler(this.cbbulan_SelectedIndexChanged);
            // 
            // cbhari
            // 
            this.cbhari.FormattingEnabled = true;
            this.cbhari.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbhari.Location = new System.Drawing.Point(122, 323);
            this.cbhari.Name = "cbhari";
            this.cbhari.Size = new System.Drawing.Size(37, 21);
            this.cbhari.TabIndex = 16;
            this.cbhari.SelectedIndexChanged += new System.EventHandler(this.cbhari_SelectedIndexChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(122, 362);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(193, 20);
            this.txtemail.TabIndex = 15;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txttempat
            // 
            this.txttempat.Location = new System.Drawing.Point(122, 290);
            this.txttempat.Name = "txttempat";
            this.txttempat.Size = new System.Drawing.Size(193, 20);
            this.txttempat.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Alamat Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tanggal Lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tempat Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jenis Kelamin";
            // 
            // txtnomorhp
            // 
            this.txtnomorhp.Location = new System.Drawing.Point(122, 201);
            this.txtnomorhp.Name = "txtnomorhp";
            this.txtnomorhp.Size = new System.Drawing.Size(193, 20);
            this.txtnomorhp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "No HP/WA";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(122, 112);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(193, 74);
            this.txtalamat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat Lengkap";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(122, 66);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(193, 20);
            this.txtnama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Lengkap  :";
            // 
            // txtpendaftaran
            // 
            this.txtpendaftaran.Location = new System.Drawing.Point(122, 28);
            this.txtpendaftaran.Name = "txtpendaftaran";
            this.txtpendaftaran.Size = new System.Drawing.Size(193, 20);
            this.txtpendaftaran.TabIndex = 1;
            this.txtpendaftaran.TextChanged += new System.EventHandler(this.txtpendaftaran_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Pendaftaran   :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(540, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tanggal Daftar";
            // 
            // txttanggaldaftar
            // 
            this.txttanggaldaftar.Location = new System.Drawing.Point(650, 105);
            this.txttanggaldaftar.Name = "txttanggaldaftar";
            this.txttanggaldaftar.Size = new System.Drawing.Size(143, 20);
            this.txttanggaldaftar.TabIndex = 3;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(799, 102);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(63, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnhide
            // 
            this.btnhide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhide.Location = new System.Drawing.Point(799, 155);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(63, 23);
            this.btnhide.TabIndex = 5;
            this.btnhide.Text = "Hide";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kalender);
            this.groupBox2.Location = new System.Drawing.Point(557, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 171);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // kalender
            // 
            this.kalender.Location = new System.Drawing.Point(3, 9);
            this.kalender.Name = "kalender";
            this.kalender.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txthasil);
            this.groupBox3.Location = new System.Drawing.Point(557, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 269);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Pendaftar";
            // 
            // txthasil
            // 
            this.txthasil.AutoSize = true;
            this.txthasil.Location = new System.Drawing.Point(7, 27);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(30, 13);
            this.txthasil.TabIndex = 0;
            this.txthasil.Text = "Data";
            this.txthasil.Visible = false;
            this.txthasil.Click += new System.EventHandler(this.txthasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 731);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txttanggaldaftar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnomorhp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpendaftaran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtahun;
        private System.Windows.Forms.ComboBox cbbulan;
        private System.Windows.Forms.ComboBox cbhari;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttempat;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndaftar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttanggaldaftar;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar kalender;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txthasil;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.RadioButton rblaki;
    }
}

