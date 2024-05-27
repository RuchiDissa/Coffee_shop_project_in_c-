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

namespace ItemsPageForm
{
    public partial class Form1 : Form
    {
        BindingList<Products> productsList = new BindingList<Products>();
        Image img;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsList.Add(new Products { id = 1, productName = "Affogato", quantity = "1pc", price = "300tl" });
            productsList.Add(new Products { id = 2, productName = "Hot cappuchino", quantity = "1pc", price = "395tl" });
            productsList.Add(new Products { id = 3, productName = "Flat White", quantity = "1pc", price = "290tl" });
            productsList.Add(new Products { id = 4, productName = "Galano", quantity = "1pc", price = "230tl" });
            productsList.Add(new Products { id = 5, productName = "Hot Mocha", quantity = "1pc", price = "270tl" });
            productsList.Add(new Products { id = 6, productName = "Hot Americano", quantity = "1pc", price = "200tl" });
            productsList.Add(new Products { id = 7, productName = "Nescafe", quantity = "1pc", price = "270tl" });
            productsList.Add(new Products { id = 8, productName = "Machiato", quantity = "1pc", price = "180tl" });
            productsList.Add(new Products { id = 9, productName = "Hot Irish", quantity = "1pc", price = "350tl" });
            productsList.Add(new Products { id = 10, productName = "Carmel", quantity = "1pc", price = "325tl" });
            productsList.Add(new Products { id = 11, productName = "Ristettro", quantity = "1pc", price = "200tl" });
            productsList.Add(new Products { id = 12, productName = "Hot chocolate", quantity = "1pc", price = "270tl" });
            productsList.Add(new Products { id = 13, productName = "Frappuchino", quantity = "1pc", price = "180tl" });
            productsList.Add(new Products { id = 14, productName = "Black Coffee", quantity = "1pc", price = "350tl" });
            productsList.Add(new Products { id = 15, productName = "Black Coffee", quantity = "1pc", price = "325tl" });

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

            if(selectedProduct!=null)
            {
                string ImageDirectory = @"../../../image/" + selectedProduct.id.ToString() + ".jpeg";

                try
                {
                    img = Image.FromFile(ImageDirectory);
                    ProductImage.Image = img;
                }
                catch(Exception ex)
                {
                    img = Image.FromFile(@"../../../image/0.jpeg.");
                    ProductImage.Image = img;
                    MessageBox.Show("No Image");
                }
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
        }
        private void ProductImage_Click(object sender, EventArgs e)
        {

        }
    }
}
