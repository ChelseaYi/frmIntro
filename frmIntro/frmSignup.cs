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
    public partial class frmSignup : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Database=cafeturedb;username=root;password=");

        public frmSignup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin dl = new frmLogin();
            this.Hide();
            dl.ShowDialog();
        }

        private void txtPasswordSignup_Validating(object sender, CancelEventArgs e)
        {
            string password = txtPasswordSignup.Text;


            if (!char.IsUpper(password[0]))
            {
                MessageBox.Show("Ang unang letra ng password ay dapat malaking titik.");
                e.Cancel = true;
                return;
            }

            
            if (password.Length < 8)
            {
                MessageBox.Show("Ang haba ng password ay dapat hindi mas mababa sa 8.");
                e.Cancel = true;
                return;
            }


            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Ang password ay dapat may kasamang special symbol.");
                e.Cancel = true;
                return;
            }
        }

        private void txtPasswordSignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFname.Text;
                string lastName = txtLname.Text;
                string address = txtAddress.Text;
                int contactNo = int.Parse(txtContact.Text); // Convert contact number to int
                string dateOfBirth = dtpBirth.Value.ToString("yyyy-MM-dd");
                string username = txtUsernameSignup.Text;
                string password = txtPasswordSignup.Text;
                string type = "Cashier";

                string confirmpass = txtConfirmpass.Text.Trim();
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(txtContact.Text) || string.IsNullOrWhiteSpace(dateOfBirth) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpass))
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != confirmpass)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (!char.IsUpper(password[0]))
                {
                    MessageBox.Show("Ang unang letra ng password ay dapat malaking titik.");
                    return;
                }

                if (password.Length < 8)
                {
                    MessageBox.Show("Ang haba ng password ay dapat hindi mas mababa sa 8.");
                    return;
                }

                if (!password.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Ang password ay dapat may kasamang special symbol.");
                    return;
                }

                string insertQuery = "INSERT INTO accinfo (Firstname, Lastname, Address, Contact_No, DateOfBirth, Username, Password, Type) VALUES (@FirstName, @LastName, @Address, @Contact_No, @DateOfBirth, @Username, @Password, @Type)";

                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=cafeturedb"))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Type", type);

                        command.ExecuteNonQuery();
                        MessageBox.Show("User successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ClearAllTextBoxes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllTextBoxes()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            dtpBirth.Value = DateTime.Now;
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            txtConfirmpass.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
