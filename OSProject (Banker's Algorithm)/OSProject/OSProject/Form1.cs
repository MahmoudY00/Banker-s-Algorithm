using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSProject
{
    public partial class Form1 : Form
    {
        static public int no_of_process;
        static public int no_of_resources;
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ptxt.Text) && !string.IsNullOrEmpty(rtxt.Text))
            {
                if ((int.TryParse(ptxt.Text, out int p)) && (int.TryParse(rtxt.Text, out int r)))
                {
                    no_of_process = p;
                    no_of_resources = r;
                    Form2 f = new Form2();
                    this.Hide();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Please Enter An Integer Value");
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Number");
            }
        }
    }
}
