using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSCH
{
    public partial class Form1 : Form
    {
        public int x;
        Crypt crypt;
        public Form1()
        {
            InitializeComponent();
            Diapazon_1.Maximum = 1000000;
            Diapazon_1.Minimum = 0;
            Diapazon_2.Maximum = 10000000;
            Diapazon_2.Minimum = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 2; //2 для возведения в степень
            int a = Decimal.ToInt32(Diapazon_1.Value); //Диапазон
            int b = Decimal.ToInt32(Diapazon_2.Value); //Диапазон
            int n = 0; //Степень 2
            double c = 0; //Сама степень
            while (n < b) //Нахождение необходимой степени 2 для ГПСЧ
            {
                n = (int)Math.Pow(s, c);
                c++;
            }
            int[] massiv = new int[b - a]; //Создание массива с числами
            int q = a;
            for (int l = 0; l < massiv.Length; l++) //Заполнение массива
            {
                massiv[l] = q;
                q++;

            }
            GSCH vihod = new GSCH(massiv, n);
            Vivod.Text = "Результат работы генератора:" + vihod.gs[^1];
        }

        private void Oracul_Click(object sender, EventArgs e)
        {
            x = (x * 3 + 1) % 32;
            Vivod.Text = "Результат работы " + x + " Сколько?";
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            crypt = new Crypt(Vvod.Text);

            string s = null;
            foreach (string k in crypt.flow)
            {
                s = s + k;
            }
            Vivod.Text = s;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string[] reshifr = new string[crypt.flow.Length];
            for (int i = 0; i < crypt.flow.Length; i++)
            {
                for (int j = 0; j < crypt.key.Length; j++)
                {
                    if (crypt.flow[i] == crypt.key[j])
                    {
                        reshifr[i] = crypt.slovar2[j].ToString();
                    }
                }
            }
            string s = null;
            foreach(string i in reshifr)
            {
                s = s + i;
            }
            Vvod.Text = s;
        }
    }
}
