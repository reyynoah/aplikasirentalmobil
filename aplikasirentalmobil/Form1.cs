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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OMHB2120;Initial Catalog=rentalmobil;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string query = "SELECT * FROM tb_user WHERE username=@username AND password=@password";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // sembunyikan form login

                    DashboardAdmin dashboard = new DashboardAdmin();
                    dashboard.Show(); // buka form dashboard
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
