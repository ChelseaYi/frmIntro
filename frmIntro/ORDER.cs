using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;

namespace frmIntro
{
    public partial class ORDER : UserControl
    {

      

        private List<string> coffeeDescriptions;
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;


        private PictureBox pic;
        private Label Price;
        private Label NameLabel;

        public ORDER()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = "datasource=localhost;port=3306;Initial Catalog='cafeturedb';username=root;password=";
            coffeeDescriptions = new List<string>();
            DATAGRID.Columns.Add("ITEM", "Item");
            DATAGRID.Columns.Add("COST", "Cost");
            
            DATAGRID.Columns.Add("QUANTITY", "Quantity");
            DATAGRID.Columns.Add("TOTAL", "Total");
        }

        public void AddItemToDataGridView(string itemName, decimal price, int quantity, decimal total)
        {

            int rowIndex = DATAGRID.Rows.Add();
            DataGridViewRow newRow = DATAGRID.Rows[rowIndex];
            newRow.Cells["ITEM"].Value = itemName;

            // I-set ang Price at Total na may format na may dalawang decimal places at may .00 suffix
            newRow.Cells["COST"].Value = price.ToString("0.00");
            newRow.Cells["QUANTITY"].Value = quantity;
            newRow.Cells["TOTAL"].Value = total.ToString("0.00");

            CalculateAndAddTotalToGrandTotal();

        }


        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                var info = clickedPictureBox.Tag as dynamic;
                if (info != null)
                {
                    string name = info.Name;
                    string price = info.Price;
                    string description = coffeeDescriptions[flowLayoutPanel1.Controls.IndexOf(clickedPictureBox)];


                    byte[] imageBytes = (byte[])info.ImageBytes;

                    frmItemOrder form = new frmItemOrder(this, name, price, description, imageBytes);
                    form.ShowDialog();

                }
            }
        }
        private void GetData()
        {
            cn.Open();
            cm = new MySqlCommand("select Coffee_img, Name, Price, Description from cafelang", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                coffeeDescriptions.Add(dr["Description"].ToString());

                pic = new PictureBox();

                pic.Width = 150;
                pic.Height = 150;

                
                pic.Margin = new Padding(10);

                pic.BackgroundImageLayout = ImageLayout.Stretch;

                Price = new Label();
                Price.Text = dr["Price"].ToString();
                Price.BackColor = Color.FromArgb(222, 184, 135);
                Price.TextAlign = ContentAlignment.MiddleCenter;
                Price.Dock = DockStyle.Bottom;
                Price.ForeColor = Color.FromArgb(139, 69, 19);


                Price.Font = new Font("Sitka Small", 10, FontStyle.Bold);
                NameLabel = new Label();
                NameLabel.Text = dr["Name"].ToString();
                NameLabel.BackColor = Color.FromArgb(210, 105, 30);
                NameLabel.TextAlign = ContentAlignment.MiddleCenter;

                NameLabel.ForeColor = Color.White;
                
                NameLabel.Font = new Font("Sitka Small", 10, FontStyle.Bold);

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                pic.Tag = new { Name = dr["Name"].ToString(), Price = dr["Price"].ToString(), ImageBytes = array };

                pic.Click += PictureBox_Click;
                pic.MouseEnter += PictureBox_MouseEnter;
                pic.MouseLeave += PictureBox_MouseLeave;

                pic.Controls.Add(NameLabel);
                pic.Controls.Add(Price);
                flowLayoutPanel1.Controls.Add(pic);
            }

            dr.Close();
            cn.Close();
        }

        private void ORDER_Load(object sender, EventArgs e)
        {
            GetData();

        }
      

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculateAndAddTotalToGrandTotal()
        {
            decimal total = 0;

            // Iteration sa bawat row sa DataGridView
            foreach (DataGridViewRow row in DATAGRID.Rows)
            {
                // Kunin ang halaga ng item, presyo, at dami
                decimal price = Convert.ToDecimal(row.Cells["COST"].Value);
                int quantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);

                // Compute ang subtotal para sa bawat item (presyo * dami)
                decimal subtotal = price * quantity;

                // Idagdag ang subtotal sa kabuuang total
                total += subtotal;
            }

            // Kunin ang kasalukuyang na-display na kabuuang total mula sa txtGrandTotal textbox
            decimal currentGrandTotal = 0;
            decimal.TryParse(txtGrandTotal.Text, out currentGrandTotal);

            // Idagdag ang total sa kasalukuyang na-display na kabuuang total
            decimal newGrandTotal = currentGrandTotal + total;

            // I-set ang bagong kabuuang total sa txtGrandTotal textbox at i-format na may dalawang decimal places
            txtGrandTotal.Text = newGrandTotal.ToString("F2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComputeChange(decimal amount, decimal grandTotal)
        {
            decimal change = amount - grandTotal;

            if (change < 0)
            {
                MessageBox.Show("Amount is less than Grand Total. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            txtChange.Text = change.ToString("0.00");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Siguraduhing may laman ang txtAmount at txtGrandTotal bago mag-compute
            if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtGrandTotal.Text))
            {
                MessageBox.Show("Please enter both Amount and Grand Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kunin ang halaga ng Amount at Grand Total mula sa mga TextBox
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal grandTotal;
            if (!decimal.TryParse(txtGrandTotal.Text, out grandTotal))
            {
                MessageBox.Show("Please enter a valid Grand Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kalkulahin ang sukli
            ComputeChange(amount, grandTotal);
        }
    }
}
