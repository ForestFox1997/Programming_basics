using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(textBox2.Text);
            double X = Convert.ToDouble(textBox1.Text);
            double сумма = 0;                 //Переменная для суммы членов ряда
            for (int i = 1; i <= N; i = i + 1)        //Цикл перебора членов ряда, до значения n
            {
                //Расчет факториала
                int f = 1;
                for (int j = 2; j <= i; j = j + 1)
                {
                    f = f * j;
                }
                //Возведение x в нужную степень
                double sx = X;
                for (int j = 2; j <= 2 * i; j = j + 1)
                {
                    sx = sx * X;
                }
                //Итоговый расчёт
                сумма = сумма + (Math.Pow(-1, i + 1)) * sx * (Math.Sin(X * i)) / f;
            }
            textBox4.Text = сумма.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double E = Convert.ToDouble(textBox3.Text);
            double X = Convert.ToDouble(textBox1.Text);
            double сумма = 0;                   //Переменная для суммы членов ряда
            double член_ряда = double.MaxValue; //Переменная для значения члена ряда
            double i = 0;                       //Переменная для номера члена ряда
            while ( !(член_ряда < E) )          //Проверка условия повтора цикла
            {
                i = i + 1;
                //Расчет факториала
                int f = 1;
                for (int j = 2; j <= i; j = j + 1)
                {
                    f = f * j;
                }
                //Возведение x в нужную степень
                double sx = X;
                for (int j = 2; j <= 2 * i; j = j + 1)
                {
                    sx = sx * X;
                }
                //Итоговый расчёт
                член_ряда = (Math.Pow(-1, i + 1)) * sx * (Math.Sin(X * i)) / f;
                if (член_ряда >= E)
                {
                    сумма = сумма + член_ряда;
                }

            }
            textBox5.Text = сумма.ToString();
        }
    }
}
