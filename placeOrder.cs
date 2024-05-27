using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class placeOrder : Form
    {
        private int autoID = 1;

        public placeOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* myListView.View = View.Details;
             myListView.GridLines = true;
             myListView.FullRowSelect = true; */

            myListView.Columns.Add("Id", 60, HorizontalAlignment.Center);
            myListView.Columns.Add("Customer Name", 250, HorizontalAlignment.Center);
            myListView.Columns.Add("ItemName", 200, HorizontalAlignment.Center);
            myListView.Columns.Add("ItemNumber", 100, HorizontalAlignment.Center);
            myListView.Columns.Add("ItemPrice", 100, HorizontalAlignment.Center);

            




        }

        private void label2_Click(object sender, EventArgs e)
        {
            placeOrder place = new placeOrder();
            this.Hide();
        }

        private void addToListView(String CustomerName, String ItemName, String ItemNumber, String ItemPrice)
        {

            ListViewItem eachRow = new ListViewItem("" + autoID);
            ListViewItem.ListViewSubItem rowCustomername = new ListViewItem.ListViewSubItem(eachRow, CustomerName);
            ListViewItem.ListViewSubItem rowItemname = new ListViewItem.ListViewSubItem(eachRow, ItemName);
            ListViewItem.ListViewSubItem rowItemNumber = new ListViewItem.ListViewSubItem(eachRow, ItemNumber);
            ListViewItem.ListViewSubItem rowItemPrice = new ListViewItem.ListViewSubItem(eachRow, ItemPrice);

            eachRow.SubItems.Add(CustomerName);
            eachRow.SubItems.Add(ItemName);
            eachRow.SubItems.Add(ItemNumber);
            eachRow.SubItems.Add(ItemPrice);

            myListView.Items.Add(eachRow);

            this.autoID++;




        }

        private void myListView_SelectedIndexChanged(String CustomerName, String ItemName, String ItemNumber, String ItemPrice)
        {


            ListViewItem eachRow = new ListViewItem("" + autoID);
            ListViewItem.ListViewSubItem rowCustomername = new ListViewItem.ListViewSubItem(eachRow, CustomerName);
            ListViewItem.ListViewSubItem rowItemname = new ListViewItem.ListViewSubItem(eachRow, ItemName);
            ListViewItem.ListViewSubItem rowItemNumber = new ListViewItem.ListViewSubItem(eachRow, ItemNumber);
            ListViewItem.ListViewSubItem rowItemPrice =new ListViewItem.ListViewSubItem(eachRow, ItemPrice);

            eachRow.SubItems.Add(CustomerName);
            eachRow.SubItems.Add(ItemName);
            eachRow.SubItems.Add(ItemNumber);
            eachRow.SubItems.Add(ItemPrice);

            myListView.Items.Add(eachRow);

            this.autoID++;

        }

        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            customername.Text= myListView.FocusedItem.SubItems[1].Text;
            item.Text = myListView.FocusedItem.SubItems[2].Text;
            number.Text = myListView.FocusedItem.SubItems[3].Text;
            price.Text = myListView.FocusedItem.SubItems[4].Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CustomerName = this.customername.Text.ToString();
            string ItemName = this.item.Text.ToString();
            string ItemNumber = this.number.Text.ToString();
            string ItemPrice = this.price.Text.ToString();

            if ((CustomerName.Length > 1) && (ItemName.Length > 1) && (ItemNumber.Length > 1) && (ItemPrice.Length > 1))
            {
                addToListView(CustomerName, ItemName, ItemNumber, ItemPrice);
            }
            else
                MessageBox.Show("Please Fill All The Field Accordingly");
        }

        private void itemnumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void customername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void quan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MenuPage menu = new MenuPage();
            menu.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string AutoID = (customername.Text);
            int index = 0;

            myListView.Items[index].Remove();
            
                MessageBox.Show("Cleared Successfully");
        }

     

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myListView.FocusedItem.SubItems[1].Text = customername.Text;
            myListView.FocusedItem.SubItems[2].Text = item.Text;
            myListView.FocusedItem.SubItems[3].Text = number.Text;
            myListView.FocusedItem.SubItems[4].Text = price.Text;

            MessageBox.Show("Updated Successfully");
        }

        private void ItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            prices Prices = new prices();
            Prices.Show();
            this.Hide();
        }

        private void ItemPrice_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Xml Documents|*.xml", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in myListView.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text + "\t" + item.SubItems[4]);

                        }
                        MessageBox.Show("Your Data has been Successfully Exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

    

