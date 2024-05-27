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

namespace WindowsFormsApp1
{
    public partial class Payment : Form
    {
        
        public Payment()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            textBox1.Clear();
            errorProvider1.Clear();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
                       
        if (maskedTextBox1.Text == "4000-5000-6000-7000" && maskedTextBox2.Text=="12/23" && maskedTextBox3.Text=="333")

              new  PaymentForm2().Show();


            else
                new PaymentForm3().Show();

            if (textBox1.Text == "")

            {
                errorProvider1.SetError(textBox1, "You must enter the name on the card");
            }

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")

            {
                errorProvider1.SetError(textBox1, "You must enter the name on the card");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnlinePage online = new OnlinePage();
            online.Show();
            this.Hide();
        }
    }
}
