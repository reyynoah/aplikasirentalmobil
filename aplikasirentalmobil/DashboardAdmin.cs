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
            label1.Text = "Selamat Datang, Admin!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnMobil_Click(object sender, EventArgs e)
        {
            FormMobil mobil = new FormMobil();
            mobil.Show();
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Kelola Pelanggan belum dibuat.");
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Kelola Transaksi belum dibuat.");
        }
    }
}
