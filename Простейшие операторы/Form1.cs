using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Простейшие_операторы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           double a, b, h, m, p, S_trapeciya, TOLSHINA_trapeciya, VOLUME_trapeciya;

           a = Convert.ToDouble(textBox1.Text);       //Первое основание трапеции 
           b = Convert.ToDouble(textBox2.Text);       //Второе основание трапеции
           h = Convert.ToDouble(textBox3.Text);       //Высота трапеции
           m = Convert.ToDouble(textBox4.Text);       //Масса трапеции
           p = Convert.ToDouble(textBox5.Text);       //Плотность доски 

           S_trapeciya = (a + b) / 2 * h;       //Площадь трапеции
           VOLUME_trapeciya = m / p;            //Объём трапеции
           TOLSHINA_trapeciya = VOLUME_trapeciya / S_trapeciya;     //Толщина трапеции(доски)

           textBox6.Text = TOLSHINA_trapeciya.ToString("0.0000");

        }
    }
}
