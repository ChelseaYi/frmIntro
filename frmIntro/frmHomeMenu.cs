using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace frmIntro
{
    public partial class frmHomeMenu : Form
    {
        public frmHomeMenu()
        {
            InitializeComponent();
            ORDER uc = new ORDER();
            AddUserControl(uc);

            //menuforms(new frmOrder());

        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            menupanel.Controls.Clear();
            menupanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //public void menuforms(object Form)
        //{
        //    if (this.menupanel.Controls.Count > 0)
        //        this.menupanel.Controls.Clear();

        //    Form f = Form as Form;
        //    f.TopLevel = false;
        //    f.Dock = DockStyle.Fill;
        //    this.menupanel.Controls.Add(f);
        //    this.menupanel.Tag = f;
        //    f.Show();
        //}
        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmIntro intro = new frmIntro();
            this.Hide();
            intro.Show();
        }

        private void frmHomeMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //PlaceOrder placeOrder = new PlaceOrder();
            //this.Hide();
            //placeOrder.Show();  
        }

        private void menupanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
