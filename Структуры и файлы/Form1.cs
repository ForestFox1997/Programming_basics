using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Структуры_и_файлы
{
    struct TPeople
    {
        public string Фамилия;
        public string Имя;
        public string Операция;
        public double Сумма;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.RowCount = 1;
            dataGridView3.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TPeople people;

             

            //Запись данных в файл
            using (BinaryWriter bw = new BinaryWriter(File.Open("данные.dat", FileMode.Create)))
            {
                for(int i = 0; i < dataGridView1.RowCount; i++)
                {
                    people.Фамилия = Convert.ToString(dataGridView1[0, i].Value);
                    people.Имя = Convert.ToString(dataGridView1[1, i].Value);
                    people.Операция = Convert.ToString(dataGridView1[2, i].Value);
                    people.Сумма = Convert.ToDouble(dataGridView1[3, i].Value);
                    bw.Write(people.Фамилия);
                    bw.Write(people.Имя);
                    bw.Write(people.Операция);
                    bw.Write(people.Сумма);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TPeople[] peoples = new TPeople[0];
            int n = 0;

            //Прочтение данных из файла
            using (BinaryReader br = new BinaryReader(File.Open("данные.dat", FileMode.Open)))
            {
                while (br.PeekChar() != -1)
                {
                    Array.Resize(ref peoples, ++n);
                    peoples[n - 1].Фамилия = br.ReadString();
                    peoples[n - 1].Имя = br.ReadString();
                    peoples[n - 1].Операция = br.ReadString();
                    peoples[n - 1].Сумма = br.ReadDouble();
                }
            }

            dataGridView2.RowCount = n;

            //Нахождение клиента, положившего наибольшую сумму
            TPeople богатый_клиент = peoples[0];
            int a = 0;
            while (peoples[a].Операция != "пополнение")
            {
                a = a + 1;
                богатый_клиент = peoples[a];
            }
            for (int i = 0; i < peoples.Length; i++)
            {
                if (peoples[i].Операция == "пополнение" && peoples[i].Сумма >= богатый_клиент.Сумма)
                {
                    богатый_клиент = peoples[i];
                }
            }

            //Вывод данных нужного клиента
            dataGridView3[0, 0].Value = богатый_клиент.Фамилия;
            dataGridView3[1, 0].Value = богатый_клиент.Имя;
            dataGridView3[2, 0].Value = богатый_клиент.Операция;
            dataGridView3[3, 0].Value = богатый_клиент.Сумма;

            //Добавление искомых клиентов в архив
            TPeople[] клиенты = new TPeople[0];
            int конечный_элемент = 0;
            for (int i = 0; i < peoples.Length; i++)
            {
                if (peoples[i].Операция == "снятие" && peoples[i].Сумма > 1000)
                {
                    Array.Resize(ref клиенты, i + 1);
                    клиенты[конечный_элемент] = peoples[i];
                    конечный_элемент = конечный_элемент + 1;
                }
            }

            //Вывод данных искомых клиентов
            for (int i = 0; i < конечный_элемент; i++)
            {
                dataGridView2[0, i].Value = клиенты[i].Фамилия;
                dataGridView2[1, i].Value = клиенты[i].Имя;
                dataGridView2[2, i].Value = клиенты[i].Операция;
                dataGridView2[3, i].Value = клиенты[i].Сумма;
            }

        }
    }
}
