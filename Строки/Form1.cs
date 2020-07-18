using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace Строки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string SomeMethod(string _string) => new string(_string.ToCharArray().Reverse().ToArray());


        private void button1_Click(object sender, EventArgs e)
        {

            string строка = textBox1.Text;
            char[] разделитель = { ' ' };
            string[] массив_слов = строка.Split(разделитель, StringSplitOptions.RemoveEmptyEntries);     //Разделить строку на слова и заполнить ими массив
            int[] массив_чисел = new int[массив_слов.Length];
            for (int i = 0; i < массив_слов.Length; i++)
            {
                int длина_слова = массив_слов[i].Length;
                массив_чисел[i] = длина_слова;
            }
            double среднее_значение = массив_чисел.Average();

            textBox2.Text = среднее_значение.ToString("0.00");

        }
    }
}
