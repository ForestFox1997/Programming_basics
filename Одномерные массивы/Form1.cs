using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Одномерные_массивы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int длина_массива = textBox1.Lines.Length;
            int [] массив = new Int32[длина_массива];           //Объявление массива

            for (int i = 0; i < длина_массива; i = i + 1)       //Заполнение массива введёнными данными
            {
                массив[i] = Convert.ToInt32(textBox1.Lines[i]);
            }

            int максимальный_элемент = массив[0];
            for (int i = 1; i < длина_массива; i = i + 1)       //Вычисление максимального элемента
            {
                if (максимальный_элемент < массив[i])
                    максимальный_элемент = массив[i];
            }

            double[] массив_2 = new double[длина_массива];      //Создание второго массива

            for (int i = 0; i < длина_массива; i = i + 1)
            {
                массив_2[i] = (double)массив[i] / максимальный_элемент;
            }

            textBox2.Clear();
            for (int i = 0; i < длина_массива; i = i + 1)
            {
                textBox2.AppendText(массив_2[i] + Environment.NewLine);       //Вывод преобразованных чисел
            }
            textBox1.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.ReadOnly = false;
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
