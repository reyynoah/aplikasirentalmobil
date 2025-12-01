using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasirentalmobil
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
           
            label1.Text = "Selamat Datang di Panel Admin";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            
            FormMobil mobil = new FormMobil();
            mobil.ShowDialog(); 
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan mobil = new FormPelanggan();
            mobil.ShowDialog();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi trans = new FormTransaksi();
            trans.ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPelanggan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {

        }
    }
}
