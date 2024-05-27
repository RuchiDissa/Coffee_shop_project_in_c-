using ItemsPageForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCmpe214
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnED_Click(object sender, EventArgs e)
        {
            EmployeeDPage ed = new EmployeeDPage();
            ed.Show();
            this.Hide();
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            UsersPage up = new UsersPage();
            up.Show();
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuAd mad = new MenuAd();
            mad.Show();
        }
    }
}
