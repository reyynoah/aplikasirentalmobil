using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplikasirentalmobil
{
    public partial class FormRentalUser : Form
    {
        // ==========================================
        // VARIABLES
        // ==========================================
        private int idMobilDipilih = 0;
        private string namaMobilDipilih = ""; // Gabungan Merk + Tipe
        private decimal hargaDipilih = 0;

        // Connection String (Sesuaikan Server PC Kamu)
        private string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        public FormRentalUser()
        {
            InitializeComponent();
        }

        // ==========================================
        // SAAT FORM DIBUKA
        // ==========================================
        private void FormRentalUser_Load(object sender, EventArgs e)
        {
            LoadMobil();
        }

        private void LoadMobil()
        {
            // Pakai blok using agar koneksi otomatis ditutup (Aman & Stabil)
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // FILTER: Hanya ambil yang statusnya 'Tersedia'
                    // Mobil yang sedang disewa TIDAK AKAN MUNCUL DISINI
                    string query = "SELECT id_mobil, plat_nomer, merk, tipe, harga_sewa, status FROM tb_mobil WHERE status = 'Tersedia'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMobil.DataSource = dt;

                    // Rapikan kolom tabel
                    if (dgvMobil.Columns.Contains("id_mobil"))
                        dgvMobil.Columns["id_mobil"].Visible = false; // Sembunyikan ID

                    if (dgvMobil.Columns.Contains("harga_sewa"))
                        dgvMobil.Columns["harga_sewa"].DefaultCellStyle.Format = "N0"; // Format duit (Rp 100.000)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Load Data: " + ex.Message);
                }
            }
        }

        // ==========================================
        // PILIH MOBIL DARI TABEL
        // ==========================================
        private void dgvMobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Header diklik, abaikan

            try
            {
                DataGridViewRow row = dgvMobil.Rows[e.RowIndex];

                idMobilDipilih = Convert.ToInt32(row.Cells["id_mobil"].Value);

                // Ambil Merk dan Tipe biar lebih jelas (Contoh: "Honda Jazz")
                namaMobilDipilih = row.Cells["merk"].Value.ToString() + " " + row.Cells["tipe"].Value.ToString();

                hargaDipilih = Convert.ToDecimal(row.Cells["harga_sewa"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat pilih mobil: " + ex.Message);
            }
        }

        // ==========================================
        // TOMBOL SEWA
        // ==========================================
        private void btnSewa_Click(object sender, EventArgs e)
        {
            if (idMobilDipilih == 0)
            {
                MessageBox.Show("Pilih mobil terlebih dahulu dari daftar!");
                return;
            }

            // Buka Form Sewa & Kirim Data
            // Pastikan FormSewa.cs kamu punya konstruktor yang menerima (int, string, decimal)
            FormSewa f = new FormSewa(idMobilDipilih, namaMobilDipilih, hargaDipilih);

            this.Hide();     // Sembunyikan form list mobil sementara
            f.ShowDialog();  // TUNGGU sampai user selesai transaksi di form sebelah

            // --- KODE DI BAWAH INI JALAN SETELAH FORM SEWA DITUTUP ---

            this.Show();     // Munculkan lagi form ini
            LoadMobil();     // Refresh data! Mobil yang barusan disewa akan HILANG dari list

            // Reset pilihan
            idMobilDipilih = 0;
            namaMobilDipilih = "";
            hargaDipilih = 0;
        }

        // ==========================================
        // TOMBOL LOGOUT
        // ==========================================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Reset Sesi Global
                Form1.idUserLogin = 0;
                Form1.idPelangganLogin = 0;

                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dgvMobil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}