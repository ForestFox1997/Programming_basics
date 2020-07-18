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
            СеткаДанных.RowCount = Convert.ToInt32(ЧислоСтрок.Value);
            СеткаДанных.ColumnCount = Convert.ToInt32(ЧислоСтолбцов.Value);
        }

        private void Rows_NUD_ValueChanged(object sender, EventArgs e)
        {
            СеткаДанных.RowCount = Convert.ToInt32(ЧислоСтрок.Value);
        }

        private void Cols_NUD_ValueChanged(object sender, EventArgs e)
        {
            СеткаДанных.ColumnCount = Convert.ToInt32(ЧислоСтолбцов.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int строка=0, столбец=0;

            /* Создание матрицы */
            int[,] матрица = new int[СеткаДанных.RowCount, СеткаДанных.ColumnCount];
            for (строка = 0; строка < СеткаДанных.RowCount; строка++)
            for (столбец = 0; столбец < СеткаДанных.ColumnCount; столбец++)
            {
                матрица[строка, столбец] = Convert.ToInt32(СеткаДанных[столбец, строка].Value);
            }

            /* Нахождение минимальных элементов строки и выбор из них максимального*/
            int минимум = Int32.MinValue, максимум = Int32.MinValue;
            for (int a = 0; a < строка; a++)
            {
                минимум = матрица[a, 0];
                for (int b = 0; b < столбец; b++)
                {
                    минимум = Math.Min(минимум, матрица[a, b]);
                }
                максимум = Math.Max(минимум, максимум);
            }

            /* Вывод результата*/
            Результат1.Text = максимум.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int строка = 0, столбец = 0; Random случайно = new Random();

            /* Создание матрицы */
            int[,] матрица = new int[СеткаДанных.RowCount, СеткаДанных.ColumnCount];

            /* Заполнение матрицы случайными числами */
            for (строка=0; строка<СеткаДанных.RowCount; строка++)
            {
                for(столбец=0; столбец<СеткаДанных.ColumnCount; столбец++)
                {
                    СеткаДанных[строка, столбец].Value = случайно.Next(1, 100);
                }
            }

        }
    }
}
