using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan3
{
    public partial class Form1 : Form
    {
        String kelamin = "";
        String nama = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rblaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rblaki.Checked == true)
            {
                rbperempuan.Checked = false;
                kelamin = "Laki-Laki";
            }
        }

        private void rbperempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbperempuan.Checked == true)
            {
                rblaki.Checked = false;
                kelamin = "Perempuan";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txthasil.Visible = false;
            txtalamat.Text = "";
            txtemail.Text = "";
            txtnama.Text = "";
            txtnomorhp.Text = "";
            txtpendaftaran.Text = "";
            txttanggaldaftar.Text = "";
            txttempat.Text = "";
            rblaki.Checked = false;
            rbperempuan.Checked = false;

            if (cbbulan.Items.Count > 0)
            {
                cbbulan.SelectedIndex = 0;
            }
            if (cbhari.Items.Count > 0){
                cbhari.SelectedIndex = 0;
            }
            if (cbtahun.Items.Count > 0)
            {
                cbtahun.SelectedIndex = 0;
            }
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {

            


            if (cbhari.SelectedItem == null || cbbulan.SelectedItem == null || cbtahun.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mapping month names to their numeric values
            Dictionary<string, int> monthMap = new Dictionary<string, int>
    {
        {"Januari", 1}, {"Februari", 2}, {"Maret", 3}, {"April", 4}, {"Mei", 5}, {"Juni", 6},
        {"Juli", 7}, {"Agustus", 8}, {"September", 9}, {"Oktober", 10}, {"November", 11}, {"Desember", 12}
    };

            string day = cbhari.SelectedItem.ToString();
            string selectedMonth = cbbulan.SelectedItem.ToString();
            int month = monthMap[selectedMonth]; // Get numeric value from mapping
            string year = cbtahun.SelectedItem.ToString();

            // Create the complete date string in the "dd/mm/yyyy" format
            string tanggalLahir = $"{day}/{month:D2}/{year}";

            txthasil.Visible = true;
            txthasil.Text = "No. Pendaftaran : " + txtpendaftaran.Text +
                "\n Nama Lengkap : " + txtnama.Text +
                "\n Alamat : " + txtalamat.Text +
                "\n No HP/WA : " + txtnomorhp.Text +
                "\n Jenis Kelamin : " + kelamin +
                "\n Tempat Lahir : " + txttempat.Text +
                "\n Tanggal Lahir : " + tanggalLahir +
                "\n Alamat Email : " + txtemail.Text;
        }

        private void cbhari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            kalender.Visible = false;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            kalender.Visible = true;
        }

        private void cbbulan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txthasil_Click(object sender, EventArgs e)
        {

        }

        private void txtpendaftaran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
