using Kalkulator2;
using System;
using System.Windows.Forms;

namespace Zad_2._4
{
    public partial class Form1 : Form
    {
        Kalkulator2.MathCalc.Calculator kalkulator = new Kalkulator2.MathCalc.Calculator();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            textBox3.Text = kalkulator.Add(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            textBox3.Text = kalkulator.Substract(a, b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            textBox3.Text = kalkulator.Multiply(a, b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            try
            {
                textBox3.Text = kalkulator.Divide(a, b).ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = "B³¹d!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
