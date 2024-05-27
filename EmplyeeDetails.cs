using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace ProjectCmpe214
{
    public partial class EmployeeDPage : Form
    {
        ArrayList EmployeeId = new ArrayList();
        public EmployeeDPage()
        {
            InitializeComponent();
        }

        private void EmployeeDPage_Load(object sender, EventArgs e)
        {
            myListView.View = View.Details;
            myListView.GridLines = true;
            myListView.FullRowSelect = true;

            myListView.Columns.Add("ID", 30, HorizontalAlignment.Left);
            myListView.Columns.Add("Name", 215, HorizontalAlignment.Left);
            myListView.Columns.Add("Surname", 215, HorizontalAlignment.Left);
            myListView.Columns.Add("Email", 215, HorizontalAlignment.Left);
            myListView.Columns.Add("UserName", 215, HorizontalAlignment.Left);

            txtUpdateId.Enabled = false;
            txtDeleteId.Enabled = false;

            addDataToListView(100, "Hary", "Lucus","Harry1987@gmail.com","HarryL");
            addDataToListView(101, "Robet", "Mike", "RobertMike2@gmail.com", "Robert92");
            addDataToListView(102, "George", "Paul", "PaulGeorge34gmail.com", "Paul34");

            EmployeeId.Add(100);
            EmployeeId.Add(101);
            EmployeeId.Add(102);
        }
        private void addDataToListView(long eno, String name, String surname,String email,String username)
        {
            
            ListViewItem row = new ListViewItem(eno.ToString());

            ListViewItem.ListViewSubItem columnName = new ListViewItem.ListViewSubItem(row, name);
            ListViewItem.ListViewSubItem columnSurname = new ListViewItem.ListViewSubItem(row, surname);
            ListViewItem.ListViewSubItem columnEmail = new ListViewItem.ListViewSubItem(row, email);
            ListViewItem.ListViewSubItem columnUserName = new ListViewItem.ListViewSubItem(row, username);

            row.SubItems.Add(columnName);
            row.SubItems.Add(columnSurname);
            row.SubItems.Add(columnEmail);
            row.SubItems.Add(columnUserName);

            myListView.Items.Add(row);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (myListView.FocusedItem != null)
                {
                    myListView.FocusedItem.SubItems[1].Text = txtUpdateName.Text;
                    myListView.FocusedItem.SubItems[2].Text = txtUpdateSurname.Text;
                    myListView.FocusedItem.SubItems[3].Text = txtUpdateEmail.Text;
                    myListView.FocusedItem.SubItems[4].Text = txtUpdateUserName.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Mismatch in the value you are trying to update \n\n {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUpdateId.Clear();
            txtUpdateName.Clear();
            txtUpdateSurname.Clear();
            txtUpdateEmail.Clear();
            txtUpdateSurname.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkIfNumberExists = false;

            String eno = txtAddId.Text.ToString();
            String name = txtAddName.Text.ToString();
            String surname = txtAddSurname.Text.ToString();
            String email = txtAddEmail.Text.ToString();
            String username = txtAddUserName.Text.ToString();

            try
            {
                int EmployeeNo = int.Parse(eno);

                if ((name.Length < 1) || (surname.Length < 1) || (email.Length < 1) || (username.Length < 1))
                    MessageBox.Show("Please enter all empty fields", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {

                    foreach (int eachNumber in EmployeeId)
                    {
                        if (eachNumber == EmployeeNo)
                        {
                            checkIfNumberExists = true;
                            break;
                        }
                    }

                    if (checkIfNumberExists)
                        MessageBox.Show($"The number {EmployeeNo} already exists. So you cannot add it.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        addDataToListView(EmployeeNo, name, surname,email,username);
                        EmployeeId.Add(EmployeeNo);
                    }

                }// else


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Please enter a number to student number \n\n {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String deleteNoStr = this.txtDeleteId.Text.ToString();
            long deleteNo = 0;
            bool deleteFound = false;

            txtUpdateId.Clear();
            txtUpdateName.Clear();
            txtUpdateSurname.Clear();
            txtUpdateEmail.Clear();
            txtUpdateUserName.Clear();


            try
            {
                deleteNo = long.Parse(deleteNoStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please select a valid student number \n\n {ex.Message}", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int index = 0;

            foreach (int eachNumber in EmployeeId)
            {
                if (eachNumber == deleteNo)
                {
                    deleteFound = true;
                    break;
                }
                ++index;
            }

            if (deleteFound)
            {

                if (MessageBox.Show($"Do you want to delete this record : {deleteNo} ?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    try
                    {
                        myListView.Items[index].Remove();
                        EmployeeId.RemoveAt(index);
                        txtDeleteId.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Delete operation cannot be performed \n\n {ex.Message}", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void myListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.txtUpdateId.Text = myListView.FocusedItem.SubItems[0].Text;
            this.txtUpdateName.Text = myListView.FocusedItem.SubItems[1].Text;
            this.txtUpdateSurname.Text = myListView.FocusedItem.SubItems[2].Text;
            this.txtUpdateEmail.Text = myListView.FocusedItem.SubItems[3].Text;
            this.txtUpdateUserName.Text = myListView.FocusedItem.SubItems[4].Text;
            this.txtDeleteId.Text = myListView.FocusedItem.SubItems[0].Text;
        }

        private async void btnSaveFile_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd =new SaveFileDialog() { Filter = "Xml Documents|*.xml",ValidateNames=true})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using(TextWriter tw = new StreamWriter(new FileStream(sfd.FileName,FileMode.Create),Encoding.UTF8))
                    {
                        foreach (ListViewItem item in myListView.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text + "\t" + item.SubItems[4].Text);

                        }
                        MessageBox.Show("Your Data has been Successfully Exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtAddEmail.Clear();
            txtAddId.Clear();
            txtAddName.Clear();
            txtAddSurname.Clear();
            txtAddUserName.Clear();
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
