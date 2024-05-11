using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace frmIntro
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=cafeturedb");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup frmSignUp = new frmSignup();
            this.Hide();
            frmSignUp.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            
            if (username == "Admin" && password == "Admin123")
            {
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdmin adminForm = new frmAdmin();
                this.Hide();
                adminForm.ShowDialog();
            }
            else
            {
             
                string query = "SELECT * FROM accinfo WHERE username = @Username AND password = @Password";

                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHomeMenu frm = new frmHomeMenu();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
