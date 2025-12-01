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
    public partial class FormRegistrasi : Form
    {
        string connectionString = "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True";

        public FormRegistrasi()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string telepon = txtTelepon.Text;
            string ktp = txtKTP.Text;

            if (username == "" || password == "" || confirm == "" ||
                nama == "" || alamat == "" || telepon == "" || ktp == "")
            {
                MessageBox.Show("Semua data (termasuk data diri) harus diisi lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Password dan konfirmasi tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string queryCheck = "SELECT COUNT(*) FROM tb_user WHERE username=@user";
                    SqlCommand checkCmd = new SqlCommand(queryCheck, con);
                    checkCmd.Parameters.AddWithValue("@user", username);

                    int exist = (int)checkCmd.ExecuteScalar();
                    if (exist > 0)
                    {
                        MessageBox.Show("Username sudah digunakan, silakan ganti!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string queryUser = "INSERT INTO tb_user (username, password, role) OUTPUT INSERTED.id_user VALUES (@user, @pass, 'user')";
                    SqlCommand cmdUser = new SqlCommand(queryUser, con);
                    cmdUser.Parameters.AddWithValue("@user", username);
                    cmdUser.Parameters.AddWithValue("@pass", password);

                    
                    int newUserId = (int)cmdUser.ExecuteScalar();

                    
                    string queryPelanggan = "INSERT INTO tb_pelanggan (nama, alamat, telepon, no_ktp, id_user) VALUES (@nama, @alamat, @telp, @ktp, @idUser)";
                    SqlCommand cmdPel = new SqlCommand(queryPelanggan, con);
                    cmdPel.Parameters.AddWithValue("@nama", nama);
                    cmdPel.Parameters.AddWithValue("@alamat", alamat);
                    cmdPel.Parameters.AddWithValue("@telp", telepon);
                    cmdPel.Parameters.AddWithValue("@ktp", ktp);
                    cmdPel.Parameters.AddWithValue("@idUser", newUserId); 
                    cmdPel.ExecuteNonQuery();

                   
                    MessageBox.Show("Registrasi Berhasil! Data pelanggan telah disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form1 login = new Form1(); 
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Error: " + ex.Message);
                }
            }
        }

        

        private void FormRegistrasi_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
