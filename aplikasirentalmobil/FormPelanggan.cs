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
    public partial class FormPelanggan : Form
    {
        
        string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        
        int idPelangganTerpilih = 0;

        public FormPelanggan()
        {
            InitializeComponent();
        }

       
        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            TampilData();
            AturButton(true, false, false);
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
                   
                    string query = "SELECT * FROM tb_pelanggan";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPelanggan.DataSource = dt;

                    
                    dgvPelanggan.Columns["id_pelanggan"].HeaderText = "ID";
                    dgvPelanggan.Columns["nama"].HeaderText = "Nama Lengkap";
                    dgvPelanggan.Columns["no_ktp"].HeaderText = "No KTP";

                   
                    if (dgvPelanggan.Columns.Contains("id_user"))
                        dgvPelanggan.Columns["id_user"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal tampil data: " + ex.Message);
                }
            }
        }

       
        private void dgvPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPelanggan.Rows[e.RowIndex];

                idPelangganTerpilih = Convert.ToInt32(row.Cells["id_pelanggan"].Value);

                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtTelepon.Text = row.Cells["telepon"].Value.ToString();
                txtKTP.Text = row.Cells["no_ktp"].Value.ToString();

                AturButton(false, true, true); 
            }
        }

        
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtTelepon.Text == "")
            {
                MessageBox.Show("Nama dan Telepon wajib diisi!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                   
                    string query = "INSERT INTO tb_pelanggan (nama, alamat, telepon, no_ktp) VALUES (@nama, @alamat, @telp, @ktp)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@telp", txtTelepon.Text);
                    cmd.Parameters.AddWithValue("@ktp", txtKTP.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pelanggan Berhasil Ditambahkan!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Simpan: " + ex.Message);
                }
            }
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (idPelangganTerpilih == 0)
            {
                MessageBox.Show("Pilih pelanggan dulu!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE tb_pelanggan SET nama=@nama, alamat=@alamat, telepon=@telp, no_ktp=@ktp WHERE id_pelanggan=@id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", idPelangganTerpilih);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@telp", txtTelepon.Text);
                    cmd.Parameters.AddWithValue("@ktp", txtKTP.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Pelanggan Berhasil Diupdate!");

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
            if (idPelangganTerpilih == 0)
            {
                MessageBox.Show("Pilih pelanggan yang akan dihapus!");
                return;
            }

            if (MessageBox.Show("Yakin hapus data pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                       
                        string query = "DELETE FROM tb_pelanggan WHERE id_pelanggan=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idPelangganTerpilih);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Pelanggan Berhasil Dihapus!");

                        TampilData();
                        Bersihkan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal Hapus (Mungkin pelanggan ini punya riwayat sewa): " + ex.Message);
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
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelepon.Text = "";
            txtKTP.Text = "";
            idPelangganTerpilih = 0;
            AturButton(true, false, false);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
