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
        private void Calculate(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            ICalculator calc = Factory.CreateCalculator(((Button) sender).Name);
            var result = calc.Doit(firstArg, secArg);
            label1.Text = result.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OneCalculate(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
           
            IOneCalculator calc = OneFactory.CreateCalculator(((Button)sender).Name);
            var result = calc.Doit(firstArg);
            label1.Text = result.ToString();
        }

    }
}
