using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GSCH
{
    class Crypt
    {
        public char[] bukva;
        public string[] flow;
        public string code = @" ""абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ.;:?(),abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ\/|_=+@#0123456789-»«'";
        public string[] key;
        public Crypt(string str)
        {
            bukva = str.ToCharArray();
            flow = new string[bukva.Length];
            int[] rand = new int[1000];
            for (int i = 0; i < rand.Length; i++)
            {
                rand[i] = i;
            }
            GSCH slovar = new GSCH(rand, 1024);
            key = new string[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                slovar = new GSCH(slovar.gs, 1024);
                key[i] = slovar.gs[slovar.gs.Length - 1].ToString("X");
                for (int p = 0; p < key.Length; p++)
                {
                    if (key[i] == key[p] && p != i)
                    {
                        slovar = new GSCH(slovar.gs, 1024);
                        key[i] = slovar.gs[slovar.gs.Length - 1].ToString("X");
                        p = 0;
                    }
                }
                for (int h = 0; h < bukva.Length; h++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (bukva[h] == code[j])
                        {
                            flow[h] = key[j];
                            break;
                        }
                    }
                }
            }
        }
    }
}
