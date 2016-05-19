using System;
using System.Windows.Forms;
using calculator.OneOperation;
using calculator.TwoOperation;

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
            try
            {

                double firstArg = Convert.ToDouble(textBox1.Text);
                double secArg = Convert.ToDouble(textBox2.Text);
                ICalculator calc = Factory.CreateCalculator(((Button) sender).Name);
                var result = calc.Doit(firstArg, secArg);
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            
        }

        private void OneCalculate(object sender, EventArgs e)
        {
            try
            {

                double firstArg = Convert.ToDouble(textBox1.Text);
                IOneCalculator calc = OneFactory.CreateCalculator(((Button) sender).Name);
                var result = calc.Doit(firstArg);
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
