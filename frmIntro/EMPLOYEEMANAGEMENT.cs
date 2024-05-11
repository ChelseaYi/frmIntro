using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace frmIntro
{
    public partial class EMPLOYEEMANAGEMENT : Form
    {
        private int selectedID;
        string connectionString = "datasource=localhost;Initial Catalog=cafeturedb;User ID=root;Password=; Integrated Security=True;";
        public EMPLOYEEMANAGEMENT()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            if (selectedID != 0)
            {
                
                UpdateRecord();
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
            //try
            //{
            //    // Buuin ang connection gamit ang connection string para sa MySQL
            //    using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=cafeturedb;username=root;password="))
            //    {
            //        // Buuin ang SQL query para sa UPDATE
            //        string query = "UPDATE accinfo SET Firstname=@Firstname, Lastname=@Lastname, Address=@Address, Contact_No=@ContactNo, DateOfBirth=@DateOfBirth, Username=@Username, Password=@Password, Type=@Type WHERE ID=@ID";

            //        MySqlCommand cmd = new MySqlCommand(query, conn);


            //        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
            //        cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
            //        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            //        cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
            //        cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
            //        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            //        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            //        cmd.Parameters.AddWithValue("@Type", txtType.Text);

            //        // Buksan ang connection
            //        conn.Open();

            //        // Execute ang command
            //        int rowsAffected = cmd.ExecuteNonQuery();

            //        // Kung may na-affected na rows, ibig sabihin na-successful ang pag-update
            //        if (rowsAffected > 0)
            //        {
            //            MessageBox.Show("Record successfully updated!");
            //            LoadData(); // I-refresh ang data sa DataGridView
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed to update record!");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

        }

        private void UpdateRecord()
        {
            try
            {
                // Buuin ang connection gamit ang connection string para sa MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Buuin ang SQL query para sa UPDATE
                    string query = "UPDATE accinfo SET Firstname=@Firstname, Lastname=@Lastname, Address=@Address, Contact_No=@ContactNo, DateOfBirth=@DateOfBirth, Username=@Username, Password=@Password, Type=@Type WHERE ID=@ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Set parameters
                    cmd.Parameters.AddWithValue("@ID", selectedID);
                    cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);

                    // Open connection
                    conn.Open();

                    // Execute command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if record was successfully updated
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record successfully updated!");
                        LoadData(); // Refresh data in DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        private void LoadData()
        {
            // Buuin ang connection gamit ang connection string para sa MySQL
            using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=cafeturedb;username=root;password="))
            {
                // Buuin ang SQL query
                string query = "SELECT ID, Firstname, Lastname, Address, Contact_No, DateOfBirth, Username, Password, Type FROM accinfo";

                // Buuin ang MySqlCommand gamit ang query at connection
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Buuin ang MySqlDataAdapter para mag-fill ng dataset
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                // Buuin ang dataset
                DataSet ds = new DataSet();

                try
                {
                    // Buksan ang connection
                    conn.Open();

                    // Fill ang dataset gamit ang MySqlDataAdapter
                    da.Fill(ds, "accinfo");

                    // Iset ang DataGridView.DataSource sa dataset table
                    dataGridView1.DataSource = ds.Tables["accinfo"];
                }
                catch (Exception ex)
                {
                    // I-handle ang error kung may problema sa pagkuha ng data
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void EMPLOYEEMANAGEMENT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != "" && txtLastname.Text != "" && txtAddress.Text != "" && txtContactNo.Text != "" && txtDateOfBirth.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtType.Text != "")
            {
                try
                {
                    
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        string query = "INSERT INTO accinfo (Firstname, Lastname, Address, Contact_No, DateOfBirth, Username, Password, Type) VALUES (@Firstname, @Lastname, @Address, @ContactNo, @DateOfBirth, @Username, @Password, @Type)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Type", txtType.Text);

                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record successfully added!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add record!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a record.");
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            if (selectedID != 0)
            {
                // I-delete ang record na napili
                DeleteRecord();
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
            //try
            //{
            //    // Kumpirmahin muna ang pag-delete
            //    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        // Buuin ang connection gamit ang connection string para sa MySQL
            //        using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;database=cafeturedb;username=root;password="))
            //        {
            //            // Buuin ang SQL query para sa DELETE
            //            string query = "DELETE FROM accinfo WHERE ID=@ID";

            //            // Buuin ang MySqlCommand gamit ang query at connection
            //            MySqlCommand cmd = new MySqlCommand(query, conn);


            //            cmd.Parameters.AddWithValue("@ID", selectedID); // Kailangan mo ng selectedID variable na naka-declare sa class level para sa pag-update

            //            // Buksan ang connection
            //            conn.Open();

            //            // Execute ang command
            //            int rowsAffected = cmd.ExecuteNonQuery();

            //            // Kung may na-affected na rows, ibig sabihin na-successful ang pag-delete
            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("Record successfully deleted!");
            //                LoadData(); // I-refresh ang data sa DataGridView
            //            }
            //            else
            //            {
            //                MessageBox.Show("Failed to delete record!");
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void DeleteRecord()
        {
            try
            {
                // Kumpirmahin muna ang pag-delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Buuin ang connection gamit ang connection string para sa MySQL
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        // Buuin ang SQL query para sa DELETE
                        string query = "DELETE FROM accinfo WHERE ID=@ID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        // Set parameter
                        cmd.Parameters.AddWithValue("@ID", selectedID);

                        // Open connection
                        conn.Open();

                        // Execute command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if record was successfully deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record successfully deleted!");
                            LoadData(); // Refresh data in DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

           
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // Kunin ang ID mula sa 'ID' column ng selected row
                selectedID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);
            }
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
