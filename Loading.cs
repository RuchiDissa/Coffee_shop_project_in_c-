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
    public partial class LoadingPage : Form
    {
        int a = 0;
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(a == 0)
            
                label1.Text = "Loading....";
            
            if (a == 10)
            
                label1.Text = "Loading Coffee Shop Managment System...";
            
            if (a == 20)
            
                label1.Text = "Please Wait....";
            if (a == 30)

                label1.Text = "Loading....";

            if (a == 40)

                label1.Text = "Loading Coffee Shop Managment System...";

            if (a == 50)

                label1.Text = "Please Wait....";
            if (a == 80)

                label1.Text = "Loading....";

            if (a == 95)
            
                label1.Text = "Done!";
            
            a += 1;
            if (a >= 100)
            {
                LogInPage log = new LogInPage();
                log.Show();
                this.Hide();
                timer1.Enabled = false;
               

            }
            progressBar1.Value = a;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
