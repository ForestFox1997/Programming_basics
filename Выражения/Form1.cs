using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Выражения
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x, y, l, m, k;

            x = Convert.ToDouble(numericUpDown1.Text);
            y = Convert.ToDouble(numericUpDown2.Text);

            l = Math.Pow(x, -0.25) - (Math.Pow(2 * Math.Sqrt(2), -4.0 / 3.0) * Math.Sin(x));
            m = Math.Log10(Math.Abs(2 * Math.Sin(1.0 / x) + Math.Cos(1.0 / y)));

            if (Math.Abs(l) < 5 * Math.Abs(m))
            {
                k = Math.Log(Math.Abs((2 * l) - 3 * (Math.Exp(2) * m)));
                textBox3.Text = k.ToString("0.00000000");
            }
            else
            {
                k = Math.Log(Math.Abs(Math.Abs(2 * l * Math.Exp(2)) - 3 * m));
                textBox3.Text = k.ToString("0.00000000");
            }

            textBox1.Text = l.ToString("0.00000000");
            textBox2.Text = m.ToString("0.00000000");

        }
    }
}
