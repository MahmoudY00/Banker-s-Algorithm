using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OSProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            print_steps();
        }

        public void print_steps()
        {
            foreach (string x in Form2.steps)
            {
                richTextBox1.Text += x;
            }
        }

    }


}
