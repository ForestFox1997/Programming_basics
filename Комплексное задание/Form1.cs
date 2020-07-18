using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Комплексное_задание
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text += Environment.NewLine + DateTime.Now + "   Запуск программы";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown1.Value - 1);
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown2.Value - 1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown1.Value - 1);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown2.Value - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Заполнение матрицы случайными числами
            Random random = new Random();
            numericUpDown1.Value = random.Next(2, 5 + 1);
            numericUpDown2.Value = random.Next(3, 6 + 1);

            for (int строка = 0; строка < dataGridView1.RowCount; строка++)
            {
                for (int столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                {
                    dataGridView1.Rows[строка].Cells[столбец].Value = random.Next(20, 155 + 1);
                }
            }

            richTextBox1.Text += Environment.NewLine + DateTime.Now + "   Была сгенерирована матрица " + dataGridView1.ColumnCount + " x " + dataGridView1.RowCount + '.';

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Считывание данных
            int[,] числовая_матрица = new int[dataGridView1.RowCount, dataGridView1.ColumnCount]; 
            for (int строка = 0; строка < dataGridView1.RowCount; строка++)
            {
                for (int столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                {
                    числовая_матрица[строка, столбец] = Convert.ToInt32(dataGridView1.Rows[строка].Cells[столбец].Value);
                }
            }

            //Запись данных в файл
            using (BinaryWriter BW = new BinaryWriter(File.Open("sourse.dat", FileMode.Create)))
            {
                BW.Write(dataGridView1.RowCount);                  //Записать количество строк в бинарный файл
                BW.Write(dataGridView1.ColumnCount);               //Записать количество столбцов в бинарный файл
                for (int строка = 0; строка < dataGridView1.RowCount; строка++)
                {
                    for (int столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                    {
                        BW.Write(числовая_матрица[строка, столбец]);
                    }
                }
            }

            richTextBox1.Text += Environment.NewLine + DateTime.Now + "   Матрица была сохранена в файл ";

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Чтение из файла и заполнение матрицы
            using (BinaryReader BR = new BinaryReader(File.Open("sourse.dat", FileMode.Open)))
            {
                numericUpDown1.Value = BR.ReadInt32();              //Получить кол-во строк из бинарного файла
                numericUpDown2.Value = BR.ReadInt32();              //Получить кол-во столбцов из бинарного файла
                for (int строка = 0; строка < dataGridView1.RowCount; строка++)
                {
                    for (int столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                    {
                        dataGridView1.Rows[строка].Cells[столбец].Value = BR.ReadInt32();
                    }
                } 
            }

            richTextBox1.Text += Environment.NewLine + DateTime.Now + "   Матрица была загружена из файла";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Найти минимальный элемент матрицы, номер строки и номер столца, содержащих минимальный элемент
            int[,] числовая_матрица = new int[dataGridView1.RowCount, dataGridView1.ColumnCount]; int строка = 0, столбец = 0, стр_с_мин_элем = 0, столб_с_мин_элем = 0; ;
            for (строка = 0; строка < dataGridView1.RowCount; строка++)
            {
                for (столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                {
                    числовая_матрица[строка, столбец] = Convert.ToInt32(dataGridView1[столбец, строка].Value);
                }
            }
            int минимальный_элемент = числовая_матрица[0, 0];
            for (строка = 0; строка < dataGridView1.RowCount; строка++)
            {
                for (столбец = 0; столбец < dataGridView1.ColumnCount; столбец++)
                {
                    if (числовая_матрица[строка, столбец] < минимальный_элемент)
                    {
                        минимальный_элемент = числовая_матрица[строка, столбец];
                        стр_с_мин_элем = строка;
                        столб_с_мин_элем = столбец;
                    }
                }
            }

            //Создать матрицу, методом удаления строки и столба, содержащих минимальный элемент из изначальной матрицы
            int[,] преобразованная_матрица = new int[числовая_матрица.GetLength(0) - 1, числовая_матрица.GetLength(1) - 1];
            for (столбец = 0; столбец < числовая_матрица.GetLength(1); столбец++)
            {
                for (строка = 0; строка < числовая_матрица.GetLength(0); строка++)
                {
                    if (строка < стр_с_мин_элем && столбец < столб_с_мин_элем)
                    {
                        преобразованная_матрица[строка, столбец] = числовая_матрица[строка, столбец];
                    }
                    else if (строка < стр_с_мин_элем && столбец > столб_с_мин_элем)
                    {
                        преобразованная_матрица[строка, столбец - 1] = числовая_матрица[строка, столбец];
                    }
                    else if (строка > стр_с_мин_элем && столбец < столб_с_мин_элем)
                    {
                        преобразованная_матрица[строка - 1, столбец] = числовая_матрица[строка, столбец];
                    }
                    else if (строка > стр_с_мин_элем && столбец > столб_с_мин_элем)
                    {
                        преобразованная_матрица[строка - 1, столбец - 1] = числовая_матрица[строка, столбец];
                    }
                }
            }

            //Вывод преобразованной матрицы
            dataGridView2.RowCount = преобразованная_матрица.GetLength(0);
            dataGridView2.ColumnCount = преобразованная_матрица.GetLength(1);
            for (строка = 0; строка < преобразованная_матрица.GetLength(0); строка++)
            {
                for(столбец = 0; столбец < преобразованная_матрица.GetLength(1); столбец++)
                {
                    dataGridView2[столбец, строка].Value = преобразованная_матрица[строка, столбец];
                }
            }

            richTextBox1.Text += Environment.NewLine + DateTime.Now + "   Был выполнен расчёт;" + Environment.NewLine + "   Столбец с нимимальным элементом: " + столб_с_мин_элем + ',' + Environment.NewLine + "   Строка с нимимальным элементом: " + стр_с_мин_элем + '.';

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Получить результаты вычислений
            int[,] результат = new int[dataGridView2.RowCount,dataGridView2.ColumnCount];
            for (int строка = 0; строка < dataGridView2.RowCount; строка++)
            {
                for (int столбец = 0; столбец < dataGridView2.ColumnCount; столбец++)
                {
                    результат[строка, столбец] = Convert.ToInt32(dataGridView2[столбец, строка].Value);
                }
            }

            //Сохранить результаты расчёта в текстовый файл
            using (StreamWriter SR = new StreamWriter(File.Open("result.txt", FileMode.Create)))
            {
                for (int строка = 0; строка < dataGridView2.RowCount; строка++)
                {
                    int[] массив = new int[dataGridView2.ColumnCount];
                    for (int столбец = 0; столбец < dataGridView2.RowCount; столбец++)
                    {
                        массив[столбец] = результат[строка, столбец];
                    }
                    string строчка = null;
                    for (int j = 0; j < массив.Length; j++)
                    {
                        строчка = строчка + массив[j] + ' ';
                    }
                    SR.Write(строчка + Environment.NewLine);
                }
            }

            richTextBox1.Text += Environment.NewLine + DateTime.Now + "  Результаты расчёта были сохранены в текстовый файл.";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            
        }

    }
}
