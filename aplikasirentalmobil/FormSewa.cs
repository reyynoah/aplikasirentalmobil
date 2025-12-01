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
    public partial class FormSewa : Form
    {
        // ==========================================
        // VARIABLES
        // ==========================================
        string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        // Variable lokal untuk menampung data kiriman
        private int _idMobil;
        private string _namaMobil;
        private decimal _hargaPerHari;

        // ==========================================
        // KONSTRUKTOR KHUSUS
        // Menerima data dari FormRentalUser
        // ==========================================
        public FormSewa(int idMobil, string namaMobil, decimal harga)
        {
            InitializeComponent();

            // Simpan data kiriman ke variable lokal
            this._idMobil = idMobil;
            this._namaMobil = namaMobil;
            this._hargaPerHari = harga;
        }

        // ==========================================
        // SAAT FORM DIBUKA
        // ==========================================
        private void FormSewa_Load(object sender, EventArgs e)
        {
            // Tampilkan Info Mobil di Label
            lblNamaMobil.Text = _namaMobil;
            lblHarga.Text = "Rp " + _hargaPerHari.ToString("N0") + " / hari";

            // Atur Tanggal Default
            dtpTglSewa.MinDate = DateTime.Now; // Gak boleh pilih tanggal kemarin
            dtpTglKembali.MinDate = DateTime.Now;

            // Set tanggal kembali default ke besok (biar sewa minimal 1 hari)
            dtpTglKembali.Value = DateTime.Now.AddDays(1);

            HitungTotal(); // Hitung harga awal
        }

        // ==========================================
        // LOGIKA HITUNG HARGA OTOMATIS
        // ==========================================
        private void HitungTotal()
        {
            DateTime tglAmbil = dtpTglSewa.Value.Date;
            DateTime tglBalik = dtpTglKembali.Value.Date;

            TimeSpan selisih = tglBalik - tglAmbil;
            int durasi = selisih.Days;

            // Validasi Tanggal
            if (durasi < 0)
            {
                lblTotalBayar.Text = "Tanggal Invalid (Kembali < Sewa)";
                btnBayar.Enabled = false; // Matikan tombol bayar
            }
            else if (durasi == 0)
            {
                // Kalau sewa & kembali hari yang sama, dihitung 1 hari
                durasi = 1;
                decimal total = durasi * _hargaPerHari;
                lblTotalBayar.Text = "Rp " + total.ToString("N0");
                btnBayar.Enabled = true;
            }
            else
            {
                decimal total = durasi * _hargaPerHari;
                lblTotalBayar.Text = "Rp " + total.ToString("N0");
                btnBayar.Enabled = true;
            }
        }

        // Event saat tanggal diganti
        private void dtpTglSewa_ValueChanged(object sender, EventArgs e)
        {
            // Update batas minimal tanggal kembali
            dtpTglKembali.MinDate = dtpTglSewa.Value;
            HitungTotal();
        }

        private void dtpTglKembali_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        // ==========================================
        // TOMBOL BAYAR & SEWA
        // ==========================================
        private void btnBayar_Click(object sender, EventArgs e)
        {
            // 1. Validasi Pelanggan Login
            int idPelanggan = Form1.idPelangganLogin;

            if (idPelanggan == 0)
            {
                MessageBox.Show("Error: Sesi Login Invalid. Silakan login ulang.");
                return;
            }

            DateTime tglAmbil = dtpTglSewa.Value;
            DateTime tglBalik = dtpTglKembali.Value;

            // Hitung ulang durasi buat disimpan
            TimeSpan selisih = tglBalik.Date - tglAmbil.Date;
            int durasi = selisih.Days;
            if (durasi == 0) durasi = 1;

            decimal totalBayar = durasi * _hargaPerHari;

            // 2. Konfirmasi Pembayaran
            if (MessageBox.Show($"Total Bayar: Rp {totalBayar:N0}\nLanjutkan sewa?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        // A. INSERT DATA SEWA (PERBAIKAN DISINI)
                        // Nama kolom disesuaikan dengan database: tanggal_sewa & tanggal_kembali_rencana
                        string qSewa = @"INSERT INTO tb_sewa 
                                       (id_pelanggan, id_mobil, tanggal_sewa, tanggal_kembali_rencana, total_bayar, status) 
                                       VALUES (@idPel, @idMobil, @tglSewa, @tglRencana, @total, 'Sedang Sewa')";

                        SqlCommand cmd = new SqlCommand(qSewa, con);
                        cmd.Parameters.AddWithValue("@idPel", idPelanggan);
                        cmd.Parameters.AddWithValue("@idMobil", _idMobil);
                        cmd.Parameters.AddWithValue("@tglSewa", tglAmbil);
                        cmd.Parameters.AddWithValue("@tglRencana", tglBalik);
                        cmd.Parameters.AddWithValue("@total", totalBayar);

                        cmd.ExecuteNonQuery();

                        // B. UPDATE STATUS MOBIL JADI 'DISEWA'
                        string qUpdateMobil = "UPDATE tb_mobil SET status='Disewa' WHERE id_mobil=@idMobil";
                        SqlCommand cmdMobil = new SqlCommand(qUpdateMobil, con);
                        cmdMobil.Parameters.AddWithValue("@idMobil", _idMobil);
                        cmdMobil.ExecuteNonQuery();

                        // C. TAMPILKAN STRUK
                        string struk = "=== BUKTI SEWA MOBIL ===\n\n" +
                                       $"Mobil: {_namaMobil}\n" +
                                       $"Tgl Ambil: {tglAmbil.ToShortDateString()}\n" +
                                       $"Tgl Kembali: {tglBalik.ToShortDateString()}\n" +
                                       $"Durasi: {durasi} Hari\n" +
                                       $"Total Bayar: Rp {totalBayar:N0}\n\n" +
                                       "Simpan struk ini sebagai bukti pengambilan.";

                        MessageBox.Show(struk, "Transaksi Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tutup form ini, balik ke daftar mobil
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Transaksi: " + ex.Message);
                    }
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalBayar_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}