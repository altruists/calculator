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

        private void button4_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            double result = firstArg - secArg;
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            double result = firstArg * secArg;
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            double result = firstArg / secArg;
            label1.Text = result.ToString();
        }
        private void Calculate(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(textBox1.Text);
            double secArg = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button) sender).Name)
            {
                case "button1":
                {
                    result = firstArg + secArg;
                    break;
                }
                case "button2":
                {
                    result = firstArg * secArg;
                    break;
                }
                case "button3":
                {
                    result = firstArg / secArg;
                    break;
                }
                case "button4":
                {
                    result = firstArg - secArg;
                    break;
                }
                default : throw new Exception("Sorry you are not winner");

            }

            label1.Text = result.ToString();

        }

    }
}
