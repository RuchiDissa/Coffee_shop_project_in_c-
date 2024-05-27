using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProjectCmpe214
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage sign = new SignUpPage();
            sign.Show();
            this.Hide();
        }




        private void btnLogIn_Click_1(object sender, EventArgs e)
        {

            var doc = XDocument.Load(@"../../users.xml");


            string UserName = this.txtUserName.Text.ToString();
            string Password = this.txtPassword.Text.ToString();

            if (UserName.Length > 1 && Password.Length > 1)
            {
                if (txtUserName.Text == "admin" && txtPassword.Text == "password")
                {
                    AdminPage admin = new AdminPage();
                    admin.Show();
                    this.Hide();

                    MessageBox.Show("you are successfully Login to the system", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtUserName.Text == "home" && txtPassword.Text == "home")
                    {
                        HomePage menu = new HomePage();
                        menu.Show();
                        this.Hide();

                        MessageBox.Show("you are successfully Login to the system", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("invalid login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }

            }
            else
            {
                errorProvider1.SetError(txtUserName,"Please enter your username");

                errorProvider2.SetError(txtPassword, "Please enter your Password");
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LogInPage log = new LogInPage();
            this.Hide();
        }
    }
}
