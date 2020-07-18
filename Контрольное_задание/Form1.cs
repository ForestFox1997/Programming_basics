using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Многомерные_массивы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            СеткаДанных.RowCount = Convert.ToInt32(РазмерМатрицы.Value);
            СеткаДанных.ColumnCount = Convert.ToInt32(РазмерМатрицы.Value);
        }

        private void Rows_NUD_ValueChanged(object sender, EventArgs e)
        {
            СеткаДанных.RowCount = Convert.ToInt32(РазмерМатрицы.Value);
            СеткаДанных.ColumnCount = Convert.ToInt32(РазмерМатрицы.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int строка = 0, столбец = 0;

            /* Создание матрицы */
            int[,] матрица = new int[СеткаДанных.RowCount, СеткаДанных.ColumnCount];
            for (строка = 0; строка < СеткаДанных.RowCount; строка++)
            for (столбец = 0; столбец < СеткаДанных.ColumnCount; столбец++)
            {
                матрица[строка, столбец] = Convert.ToInt32(СеткаДанных[столбец, строка].Value);
            }

            /* Нахождение минимального элемента главной диагонали */
            int минимальный_элемент = матрица[0, 0];
            int мин = 0, номер_строки = 0;
            for (int i = 0; i < РазмерМатрицы.Value; i++)
            {
                if (матрица[i, i] < минимальный_элемент)
                {
                    минимальный_элемент = матрица[i, i];
                    мин = i;
                    номер_строки = i;
                }
            }

            /* Созданием массива из нужной строки и его сортировка по убыванию*/
            int[] массив = new int[СеткаДанных.ColumnCount];
            for (int i = 0; i < СеткаДанных.ColumnCount; i++)
            {
                массив[i] = матрица[номер_строки, i];
            }
            for (int i = 0; i < массив.Length; i++)
            {
                Array.Sort(массив);
                Array.Reverse(массив);
            }

            /* Вывод результата*/
            Тестирование.Clear();
            for (int lol = 0; lol < массив.Length; lol++)
            {
                Тестирование.Text = Тестирование.Text += массив[lol] + ' '.ToString();
            }

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

            int строка = 0, столбец = 0; Random случайно = new Random();

            /* Создание матрицы */
            int[,] матрица = new int[СеткаДанных.RowCount, СеткаДанных.ColumnCount];
            for (строка = 0; строка < СеткаДанных.RowCount; строка++)
                for (столбец = 0; столбец < СеткаДанных.ColumnCount; столбец++)
                {
                    матрица[строка, столбец] = Convert.ToInt32(СеткаДанных[столбец, строка].Value);
                }

            /* Заполнение матрицы случайными числами */
            for (строка=0; строка<СеткаДанных.RowCount; строка++)
            {
                for(столбец=0; столбец<СеткаДанных.ColumnCount; столбец++)
                {
                    СеткаДанных[строка, столбец].Value = случайно.Next(-1000, 1000);
                }
            }

        }
    }
}
