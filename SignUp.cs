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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {

            var doc = XDocument.Load(@"../../users.xml");

            string UserId = this.txtUID.Text.ToString();
            string UserName = this.txtUserName.Text.ToString();
            string Password = this.txtPassword.Text.ToString();

            if (UserName.Length > 1 && Password.Length > 1)
            {
                var newElement = new XElement("user",
                    new XElement("username", txtUserName.Text),
                    new XElement("userId", txtUID.Text),
                    new XElement("password", txtPassword.Text));


                doc.Element("usersList").Add(newElement);


                doc.Save(@"../../users.xml");

                MessageBox.Show("you are successfully sigup to the system","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                errorProvider1.SetError(txtUserName, "Please enter your username");
                errorProvider2.SetError(txtUID, "Please enter your user id");
                errorProvider3.SetError(txtPassword, "Please enter your password");
            }

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnLogIn2_Click(object sender, EventArgs e)
        {
            LogInPage log = new LogInPage();
            log.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SignUpPage sign = new SignUpPage();
            this.Hide();
        }
    }
}
