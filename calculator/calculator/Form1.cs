using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            double result = firstArg + secArg;
            label1.Text = result.ToString();

        }

    }
}
