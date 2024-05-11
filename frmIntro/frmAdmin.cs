using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmIntro
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.coffeepanel.Controls.Count > 0)
                this.coffeepanel.Controls.Clear();

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.coffeepanel.Controls.Add(f);
            this.coffeepanel.Tag = f;
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadform(new CoffeeManagement());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmIntro frmIntro = new frmIntro();
            this.Hide();
            frmIntro.Show();    
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadform(new EMPLOYEEMANAGEMENT());
        }
    }
}
