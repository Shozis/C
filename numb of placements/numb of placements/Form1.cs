using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numb_of_placements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double k;
        double n;
        double nk;
        double n1;
        double q;

        static double factorial(double n)
        {

            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }

            return p;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            k = Convert.ToDouble(textBox6.Text);

            textBox1.Text = k.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToDouble(textBox7.Text);

            textBox2.Text = n.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            nk = factorial(n-k);
            n1 = factorial(n);



            textBox3.Text = n1.ToString();
            textBox4.Text = nk.ToString();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            q = n1 / nk;
            textBox8.Text = q.ToString();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
