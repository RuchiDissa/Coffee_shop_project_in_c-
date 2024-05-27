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
using WindowsFormsApp4;

namespace ProjectCmpe214
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInPage log = new LogInPage();
            log.Show(); ;
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpPage sign = new SignUpPage();
            sign.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInPage log = new LogInPage();
            log.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPage menu = new MenuPage();
            menu.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OnlinePage online = new OnlinePage();
            online.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            placeOrder place = new placeOrder();
            place.Show();
        }
    }
}
