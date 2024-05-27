using ProjectCmpe214;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsPageForm
{
    public partial class MenuAd : Form
    {
        BindingList<Products> productsList = new BindingList<Products>();
        Image img;
        int autoID = 11;
        public MenuAd()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            productsList.Add(new Products { id = 1, productName = "Choker Crystal color heart PINK", quantity = "1pc", price = "300tl" });
            productsList.Add(new Products { id = 2, productName = "The MATTE chain", quantity = "1pc", price = "395tl" });
            productsList.Add(new Products { id = 3, productName = "LAZURITE AND PEARL Bracelet", quantity = "1pc", price = "290tl" });
            productsList.Add(new Products { id = 4, productName = "Z.gold Bracelet", quantity = "1pc", price = "230tl" });
            productsList.Add(new Products { id = 5, productName = "MEG Earrings", quantity = "1pc", price = "270tl" });
            productsList.Add(new Products { id = 6, productName = "BASE/ gold earrings with natural pearls", quantity = "1pc", price = "200tl" });
            productsList.Add(new Products { id = 7, productName = "AVRORA Ring", quantity = "1pc", price = "270tl" });
            productsList.Add(new Products { id = 8, productName = "EDEN gold ring", quantity = "1pc", price = "180tl" });
            productsList.Add(new Products { id = 9, productName = "Unique Platinum Plated Sterling Silver Ring With a Gradient Of Color", quantity = "3pc", price = "350tl" });
            productsList.Add(new Products { id = 10, productName = "Elegant Cute Crystal Crown Women's Fashion Necklace", quantity = "1pc", price = "325tl" });

            MyDataGridView.DataSource = productsList;
            MyDataGridView.Columns["id"].Visible = false;

            MyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MyDataGridView.ReadOnly = true;

            img = Image.FromFile(@"../../../image/0.jpeg.");
            ProductImage.Image = img;
        }

        private void MyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedProduct = MyDataGridView.SelectedRows[0].DataBoundItem as Products;

            if (selectedProduct != null)
            {
                string ImageDirectory = @"../../../image/" + selectedProduct.id.ToString() + ".jpeg";

                try
                {
                    img = Image.FromFile(ImageDirectory);
                    ProductImage.Image = img;
                }
                catch (Exception ex)
                {
                    img = Image.FromFile(@"../../../image/0.jpeg.");
                    ProductImage.Image = img;
                    MessageBox.Show("No Image");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtProductName.Text.ToString();
            string Quantity = txtQuantity.Text.ToString();
            string Price = txtPrice.Text.ToString();

            if(Name.Length>1&&Quantity.Length>1&&Price.Length>1)
            {
                productsList.Add(new Products { id = autoID, productName = Name, quantity = Quantity, price = Price });
                ++autoID;
            }
            else
            {
                MessageBox.Show("Please enter all information");
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteIdStr = "";
          
            try
            {
                deleteIdStr = MyDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                int id = int.Parse(deleteIdStr);
                

                for (var i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].id == id)
                    {
                        productsList.Remove(productsList[i]);
                    }
                }
                MyDataGridView.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Select a valid record to delete");
                ex.GetHashCode();
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }
    }
}
