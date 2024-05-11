using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace frmIntro
{
    public partial class frmItemOrder : Form
    {
         private ORDER orderControl;
        
        public frmItemOrder(ORDER orderControl, string itemName, string price, string description, byte[] imageBytes)
        {
            InitializeComponent();
            this.orderControl = orderControl;

            txtItemName.Text = itemName;
            txtPrice.Text = price;
            txtDescription.Text = description;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                picBox.Image = Image.FromStream(ms);
            }
            guna2NumericUpDown1.Value = 1; 
            UpdateTotal();
        }

        private void UpdateOrderButtonState()
        {
           
            guna2Button1.Enabled = guna2NumericUpDown1.Value > 0;
        }

        private void frmItemOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderButtonState();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
            UpdateOrderButtonState();



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void UpdateTotal()
        {
            decimal price;
            int quantity;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtPrice.Text = price.ToString("0.00");

            quantity = (int)guna2NumericUpDown1.Value;
            decimal total = price * quantity;

         
            txtTotal.Text = total.ToString("0.00");
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

      
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = (int)guna2NumericUpDown1.Value;
            decimal total = price * quantity;

            if (quantity > 0)
            {
                MessageBox.Show($"Order placed for {quantity} {itemName}(s) totaling ${total}", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                orderControl.AddItemToDataGridView(itemName, price, quantity, total);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
   
    }
}
