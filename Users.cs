using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ProjectCmpe214
{
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                XElement users = XElement.Load(@"../../users.xml");
                richTextBoxUsers.Text = users.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage sp = new SignUpPage();
            sp.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                String UserId = this.txtDeleteId.Text;

                if (!checkIfEmpty(UserId))
                {
                    var user = XDocument.Load(@"../../users.xml");

                    DialogResult dialogResult = MessageBox.Show("Do you want to remove User Id : " + UserId, "Do you want to delete permanently?", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {

                        user.Descendants("user").Where(x => (string)x.Element("userId") == UserId).Remove();

                        user.Save(@"../../users.xml");

                        MessageBox.Show("Existing record (if it exists) is deleted");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
                XmlDocument Doc = new XmlDocument();
                Doc.LoadXml("<usersList>" +
                    "<user>" +
                    "<username>admin</username>" +
                    "<userId>admin</userId>" +
                    "<password>admin</password>" +


                    "</user>" +
                    "</usersList>");

                using (XmlTextWriter writer = new XmlTextWriter(@"../../users.xml", null))
                {
                    writer.Formatting = Formatting.Indented;

                    Doc.Save(writer);
                }
        }
        private bool checkIfEmpty(String value)
        {

            bool control = true;

            if (value.Length < 1)
                control = true;

            else
                control = false;


            return control;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeleteId.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
