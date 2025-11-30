using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplikasirentalmobil
{
    public partial class FormTransaksi : Form
    {
        /* ===================================================================
           DAFTAR TOOLS (CONTROLS) WAJIB DI DESAIN FORM TRANSAKSI:
           Pastikan (Name) di Properties sesuai dengan daftar ini:
           
           1. DataGridView    : dgvTransaksi  (Untuk tabel daftar sewa)
           2. TextBox         : txtNama       (Menampilkan nama penyewa)
           3. TextBox         : txtMobil      (Menampilkan info mobil)
           4. TextBox         : txtTglRencana (PENTING: Menampilkan tgl rencana kembali dari DB)
           5. TextBox         : txtDenda      (Menampilkan hasil hitungan denda)
           6. DateTimePicker  : dtpTglKembali (Input tanggal pengembalian real/hari ini)
           7. Button          : btnHitung     (Tombol hitung denda)
           8. Button          : btnProses     (Tombol simpan pengembalian)
           9. Button          : btnRefresh    (Tombol refresh tabel)
           10. Button         : btnKembali    (Tombol tutup form)
           ===================================================================
        */

        // Sesuaikan nama server kamu
        string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        // Variable bantu
        int idSewaTerpilih = 0;
        int idMobilTerpilih = 0; // Penting untuk update status mobil nanti
        decimal dendaPerHari = 50000; // Contoh: Denda 50rb per hari telat

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            TampilDataSewa();
            AturInput(false); // Matikan input sebelum pilih data
        }

        // Fungsi Matikan/Nyalakan Input
        private void AturInput(bool status)
        {
            btnHitung.Enabled = status;
            btnProses.Enabled = status;
            dtpTglKembali.Enabled = status;
        }

        // ============================
        // 1. TAMPILKAN DATA (JOIN TABLE)
        // ============================
        private void TampilDataSewa()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // PERBAIKAN: Nama kolom disesuaikan dengan database (tanggal_sewa, tanggal_kembali_rencana)
                    string query = @"
                        SELECT 
                            s.id_sewa, 
                            p.nama AS nama_pelanggan, 
                            m.merk + ' - ' + m.plat_nomer AS info_mobil,
                            m.id_mobil,
                            s.tanggal_sewa, 
                            s.tanggal_kembali_rencana, 
                            s.total_bayar,
                            s.status
                        FROM tb_sewa s
                        JOIN tb_pelanggan p ON s.id_pelanggan = p.id_pelanggan
                        JOIN tb_mobil m ON s.id_mobil = m.id_mobil
                        WHERE s.status = 'Sedang Sewa'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTransaksi.DataSource = dt;

                    // Sembunyikan ID Mobil karena user gak perlu lihat
                    if (dgvTransaksi.Columns.Contains("id_mobil"))
                        dgvTransaksi.Columns["id_mobil"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Load Data: " + ex.Message);
                }
            }
        }

        // ============================
        // 2. PILIH DATA DARI TABEL
        // ============================
        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                idSewaTerpilih = Convert.ToInt32(row.Cells["id_sewa"].Value);
                idMobilTerpilih = Convert.ToInt32(row.Cells["id_mobil"].Value); // Simpan ID Mobil buat update status nanti

                txtNama.Text = row.Cells["nama_pelanggan"].Value.ToString();
                txtMobil.Text = row.Cells["info_mobil"].Value.ToString();

                // PERBAIKAN: Ambil dari kolom 'tanggal_kembali_rencana'
                // Pastikan txtTglRencana ada di Design Form kamu (TextBox)
                if (row.Cells["tanggal_kembali_rencana"].Value != DBNull.Value)
                {
                    txtTglRencana.Text = Convert.ToDateTime(row.Cells["tanggal_kembali_rencana"].Value).ToShortDateString();
                }

                // Nyalakan tombol
                AturInput(true);

                // Reset Denda
                txtDenda.Text = "0";
            }
        }

        // ============================
        // 3. HITUNG DENDA
        // ============================
        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (idSewaTerpilih == 0) return;

            // Pastikan txtTglRencana tidak kosong biar gak error
            if (string.IsNullOrEmpty(txtTglRencana.Text))
            {
                MessageBox.Show("Tanggal rencana kembali tidak valid!");
                return;
            }

            DateTime tglRencana = DateTime.Parse(txtTglRencana.Text);
            DateTime tglKembaliReal = dtpTglKembali.Value;

            // Hitung selisih hari
            TimeSpan selisih = tglKembaliReal.Date - tglRencana.Date;
            int telatHari = selisih.Days;

            if (telatHari > 0)
            {
                decimal totalDenda = telatHari * dendaPerHari;
                txtDenda.Text = totalDenda.ToString("N0"); // Format angka cantik
                MessageBox.Show($"Telat {telatHari} hari. Denda: Rp {totalDenda:N0}");
            }
            else
            {
                txtDenda.Text = "0";
                MessageBox.Show("Tidak ada keterlambatan. Aman!");
            }
        }

        // ============================
        // 4. PROSES PENGEMBALIAN (FINISH)
        // ============================
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (idSewaTerpilih == 0)
            {
                MessageBox.Show("Pilih transaksi dulu!");
                return;
            }

            if (MessageBox.Show("Proses pengembalian mobil ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        // A. INSERT ke Tabel Pengembalian
                        // PERBAIKAN: Nama kolom disesuaikan jadi 'tanggal_kembali' (bukan tgl_kembali_real)
                        string qKembali = "INSERT INTO tb_pengembalian (id_sewa, tanggal_kembali, denda, kondisi_mobil) VALUES (@idSewa, @tgl, @denda, 'Baik')";
                        SqlCommand cmd = new SqlCommand(qKembali, con);
                        cmd.Parameters.AddWithValue("@idSewa", idSewaTerpilih);
                        cmd.Parameters.AddWithValue("@tgl", dtpTglKembali.Value);

                        // Parse denda, hilangkan format titik/koma kalau ada
                        decimal dendaVal = 0;
                        decimal.TryParse(txtDenda.Text.Replace(".", "").Replace(",", ""), out dendaVal);
                        cmd.Parameters.AddWithValue("@denda", dendaVal);

                        cmd.ExecuteNonQuery();

                        // B. UPDATE Status Sewa jadi 'Selesai'
                        string qUpdateSewa = "UPDATE tb_sewa SET status='Selesai' WHERE id_sewa=@idSewa";
                        SqlCommand cmdSewa = new SqlCommand(qUpdateSewa, con);
                        cmdSewa.Parameters.AddWithValue("@idSewa", idSewaTerpilih);
                        cmdSewa.ExecuteNonQuery();

                        // C. UPDATE Status Mobil jadi 'Tersedia' (Biar bisa disewa orang lain lagi)
                        string qUpdateMobil = "UPDATE tb_mobil SET status='Tersedia' WHERE id_mobil=@idMobil";
                        SqlCommand cmdMobil = new SqlCommand(qUpdateMobil, con);
                        cmdMobil.Parameters.AddWithValue("@idMobil", idMobilTerpilih);
                        cmdMobil.ExecuteNonQuery();

                        MessageBox.Show("Pengembalian Berhasil Diproses!");

                        // Refresh data
                        TampilDataSewa();
                        BersihkanForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Proses: " + ex.Message);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilDataSewa();
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            txtNama.Text = "";
            txtMobil.Text = "";
            txtTglRencana.Text = "";
            txtDenda.Text = "0";
            dtpTglKembali.Value = DateTime.Now;

            idSewaTerpilih = 0;
            idMobilTerpilih = 0;
            AturInput(false);
        }

        // Tombol Kembali ke Dashboard
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
