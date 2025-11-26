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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True");

        public FormMobil()
        {
            InitializeComponent();
        }

        // Load data mobil
        private void LoadMobil()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tb_mobil", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMobil.DataSource = dt;
        }

        private void FormMobil_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Tersedia");
            cmbStatus.Items.Add("Disewa");
            LoadMobil();
        }

        // Tambah data mobil
        private void btnTambah_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO tb_mobil(nama_mobil, plat_nomor, tahun, harga_sewa, status) " +
                           "VALUES (@nama, @plat, @tahun, @harga, @status)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nama", txtNamaMobil.Text);
            cmd.Parameters.AddWithValue("@plat", txtPlat.Text);
            cmd.Parameters.AddWithValue("@tahun", txtTahun.Text);
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Mobil berhasil ditambahkan!");

            LoadMobil();
        }

        // Pilih data di datagrid
        private void dgvMobil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNamaMobil.Text = dgvMobil.Rows[e.RowIndex].Cells["nama_mobil"].Value.ToString();
            txtPlat.Text = dgvMobil.Rows[e.RowIndex].Cells["plat_nomor"].Value.ToString();
            txtTahun.Text = dgvMobil.Rows[e.RowIndex].Cells["tahun"].Value.ToString();
            txtHarga.Text = dgvMobil.Rows[e.RowIndex].Cells["harga_sewa"].Value.ToString();
            cmbStatus.Text = dgvMobil.Rows[e.RowIndex].Cells["status"].Value.ToString();
        }

        // Edit mobil
        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE tb_mobil SET nama_mobil=@nama, plat_nomor=@plat, tahun=@tahun, harga_sewa=@harga, status=@status WHERE id_mobil=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nama", txtNamaMobil.Text);
            cmd.Parameters.AddWithValue("@plat", txtPlat.Text);
            cmd.Parameters.AddWithValue("@tahun", txtTahun.Text);
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@id", dgvMobil.CurrentRow.Cells["id_mobil"].Value.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data mobil berhasil diubah!");
            LoadMobil();
        }

        // Hapus mobil
        private void btnHapus_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM tb_mobil WHERE id_mobil=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", dgvMobil.CurrentRow.Cells["id_mobil"].Value.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Mobil berhasil dihapus!");
            LoadMobil();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNamaMobil.Clear();
            txtPlat.Clear();
            txtTahun.Clear();
            txtHarga.Clear();
            cmbStatus.SelectedIndex = -1;
        }
    }
}
