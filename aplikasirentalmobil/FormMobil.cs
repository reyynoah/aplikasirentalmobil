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
    public partial class FormMobil : Form
    {
       
        string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        
        int idMobilTerpilih = 0;

        public FormMobil()
        {
            InitializeComponent();
        }

        private void FormMobil_Load(object sender, EventArgs e)
        {
            TampilData();
            IsiComboBoxStatus();
            AturButton(true, false, false); 
        }

        private void IsiComboBoxStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Tersedia");
            cmbStatus.Items.Add("Disewa");
            cmbStatus.Items.Add("Servis");
            cmbStatus.SelectedIndex = 0; 
        }

     
        private void AturButton(bool simpan, bool edit, bool hapus)
        {
            btnSimpan.Enabled = simpan;
            btnEdit.Enabled = edit;
            btnHapus.Enabled = hapus;
        }

        
        private void TampilData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM tb_mobil";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMobil.DataSource = dt;

                    
                    dgvMobil.Columns["id_mobil"].HeaderText = "ID";
                    dgvMobil.Columns["plat_nomer"].HeaderText = "Plat Nomor";
                    dgvMobil.Columns["harga_sewa"].HeaderText = "Harga / Hari";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal ambil data: " + ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtPlat.Text == "" || txtMerk.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO tb_mobil (plat_nomer, merk, tipe, tahun, harga_sewa, status) VALUES (@plat, @merk, @tipe, @tahun, @harga, @status)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@plat", txtPlat.Text);
                    cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                    cmd.Parameters.AddWithValue("@tipe", txtTipe.Text);
                    cmd.Parameters.AddWithValue("@tahun", int.Parse(txtTahun.Text));
                    cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Mobil Berhasil Disimpan!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
        private void dgvMobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgvMobil.Rows[e.RowIndex];

                
                idMobilTerpilih = Convert.ToInt32(row.Cells["id_mobil"].Value);

                
                txtPlat.Text = row.Cells["plat_nomer"].Value.ToString();
                txtMerk.Text = row.Cells["merk"].Value.ToString();
                txtTipe.Text = row.Cells["tipe"].Value.ToString();
                txtTahun.Text = row.Cells["tahun"].Value.ToString();
                txtHarga.Text = row.Cells["harga_sewa"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["status"].Value.ToString();

                
                AturButton(false, true, true); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idMobilTerpilih == 0)
            {
                MessageBox.Show("Pilih mobil dahulu!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE tb_mobil SET plat_nomer=@plat, merk=@merk, tipe=@tipe, tahun=@tahun, harga_sewa=@harga, status=@status WHERE id_mobil=@id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Parameter sama seperti simpan, ditambah ID
                    cmd.Parameters.AddWithValue("@id", idMobilTerpilih);
                    cmd.Parameters.AddWithValue("@plat", txtPlat.Text);
                    cmd.Parameters.AddWithValue("@merk", txtMerk.Text);
                    cmd.Parameters.AddWithValue("@tipe", txtTipe.Text);
                    cmd.Parameters.AddWithValue("@tahun", int.Parse(txtTahun.Text));
                    cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Mobil Berhasil Diupdate!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Update: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idMobilTerpilih == 0)
            {
                MessageBox.Show("Pilih mobil yang akan dihapus!");
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus mobil ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM tb_mobil WHERE id_mobil=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idMobilTerpilih);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Mobil Berhasil Dihapus!");

                        TampilData();
                        Bersihkan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Hapus: " + ex.Message);
                    }
                }
            }
        }

       
        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

      
        private void Bersihkan()
        {
            txtPlat.Text = "";
            txtMerk.Text = "";
            txtTipe.Text = "";
            txtTahun.Text = "";
            txtHarga.Text = "";
            cmbStatus.SelectedIndex = 0;

            idMobilTerpilih = 0;
            AturButton(true, false, false); 
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
