using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bernulli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p;
        double n;
        double k;
        double q;
        double C;

        static double factorial(double n)
        {

            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }

            return p;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            k = Convert.ToDouble(textBox6.Text);

            textBox2.Text = k.ToString();
            textBox5.Text = k.ToString();

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox11.Text);

            textBox4.Text = p.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToDouble(textBox9.Text);

            textBox3.Text = n.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            q = 1 - p;

            textBox7.Text = q.ToString();

            double q1 = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox2.Text);

            textBox8.Text = q1.ToString();
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double r = C * Math.Pow(p, k) * Math.Pow(q, Convert.ToDouble(textBox8.Text));
            textBox10.Text = r.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            C = factorial(n) / (factorial(k) * factorial(k));

            textBox1.Text = C.ToString();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            q = 1 - p;

            textBox7.Text = q.ToString();

            double q1 = n - k;

            textBox8.Text = q1.ToString();
        }
    }
}
