using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Методы
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c, p;
        double[] углы_треугольника = new double[3];

        public double[] ВычислятельУглов(double a, double b, double c)
        {
            p = (a + b + c) / 2;
            углы_треугольника[0] = 2 * Math.Atan(1 / (p - a) * Math.Sqrt(((p - a) * (p - b) * (p - c)) / p));
            углы_треугольника[1] = 2 * Math.Atan(1 / (p - b) * Math.Sqrt(((p - a) * (p - b) * (p - c)) / p));
            углы_треугольника[2] = 2 * Math.Atan(1 / (p - c) * Math.Sqrt(((p - a) * (p - b) * (p - c)) / p));
            return углы_треугольника;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            ВычислятельУглов(a, b, c);

            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;

                double угол_A = углы_треугольника[0] * 180 / Math.PI;
                double угол_B = углы_треугольника[1] * 180 / Math.PI;
                double угол_C = углы_треугольника[2] * 180 / Math.PI;

                textBox4.Text = угол_A.ToString("0.0°");
                textBox5.Text = угол_B.ToString("0.0°");
                textBox6.Text = угол_C.ToString("0.0°");
            }

            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;

                textBox4.Text = углы_треугольника[0].ToString("0.000");
                textBox5.Text = углы_треугольника[1].ToString("0.000");
                textBox6.Text = углы_треугольника[2].ToString("0.000");
            }

        }
    }
}
