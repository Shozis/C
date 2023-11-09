using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numb_of_permutations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;

        static double factorial(double n)
        {

            double p = 1;
            for (int i = 1; i <= n; i++)
            {
                p *= i;
            }

            return p;

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox3.Text);

            textBox1.Text = a.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double g = factorial(a);

            textBox2.Text = g.ToString();
        }
    }
}
