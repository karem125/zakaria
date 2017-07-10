using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Name Is Mohamed Moafa");
        }
    }
}
