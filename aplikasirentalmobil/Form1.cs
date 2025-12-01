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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            "Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True"
        );

        public static int idUserLogin = 0;        
        public static int idPelangganLogin = 0;   

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                
                    SqlCommand cmd = new SqlCommand(
                        "SELECT id_user, role FROM tb_user WHERE username=@user AND password=@pass",
                        con
                    );

                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        
                        idUserLogin = Convert.ToInt32(dr["id_user"]);
                        string role = dr["role"].ToString();
                        dr.Close(); 

                       

                        if (role == "admin")
                        {
                            
                            MessageBox.Show("Login Admin Berhasil!");
                            this.Hide();
                            DashboardAdmin admin = new DashboardAdmin();
                            admin.Show();
                        }
                        else if (role == "user")
                        {
                           
                            SqlCommand getPelanggan = new SqlCommand(
                                "SELECT id_pelanggan FROM tb_pelanggan WHERE id_user=@id",
                                con
                            );
                            getPelanggan.Parameters.AddWithValue("@id", idUserLogin);

                            object idPel = getPelanggan.ExecuteScalar();

                            if (idPel == null)
                            {
                                
                                MessageBox.Show("Error: Data profil pelanggan tidak ditemukan. Hubungi Admin.");
                                return;
                            }

                            idPelangganLogin = Convert.ToInt32(idPel);

                            MessageBox.Show("Login Berhasil!");
                            this.Hide();
                            FormRentalUser userForm = new FormRentalUser(); 
                            userForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Koneksi: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrasi reg = new FormRegistrasi();
            reg.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
