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
        public char[] slovar1 = " абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ.;:?(),".ToCharArray();
        public char[] slovar2 = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.;:?(),".ToCharArray();
        public string[] key;
        public int check;
        public Crypt(string str)
        {
            bukva = str.ToCharArray();
            flow = new string[bukva.Length];
            for (int i = 1; i < slovar1.Length - 6; i++)
            {
                if (slovar1[i] == bukva[0])
                {
                    check = 1;
                }
                else if (i < slovar2.Length - 6 && slovar2[i] == bukva[0])
                {
                    check = 2;
                }
            }
            int[] rand = new int[100];
            for (int i = 0; i < rand.Length; i++)
            {
                rand[i] = i;
            }
            GSCH slovar = new GSCH(rand, 128);
            if (check == 1)
            {
                key = new string[slovar1.Length];
                for (int i = 0; i < slovar1.Length; i++)
                {
                    slovar = new GSCH(slovar.gs, 128);
                    key[i] = slovar.gs[slovar.gs.Length - 1].ToString();
                    for (int p = 0; p < key.Length; p++)
                    {
                        if (key[i] == key[p] && p != i)
                        {
                            slovar = new GSCH(slovar.gs, 128);
                            key[i] = slovar.gs[slovar.gs.Length - 1].ToString();
                            p = 0;
                        }
                    }
                }
                for (int i = 0; i < bukva.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (bukva[i] == slovar1[j])
                        {
                            flow[i] = key[j];
                            break;
                        }
                    }
                }
            }
            else if (check == 2)
            {
                key = new string[slovar2.Length];
                for (int i = 0; i < slovar2.Length; i++)
                {
                    slovar = new GSCH(slovar.gs, 128);
                    key[i] = slovar.gs[slovar.gs.Length - 1].ToString();
                    for (int p = 0; p < key.Length; p++)
                    {
                        if (key[i] == key[p] && p != i)
                        {
                            slovar = new GSCH(slovar.gs, 128);
                            key[i] = slovar.gs[slovar.gs.Length - 1].ToString();
                            p = 0;
                        }
                    }
                }
                for (int i = 0; i < bukva.Length; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (bukva[i] == slovar2[j])
                        {
                            flow[i] = key[j];
                            break;
                        }
                    }
                }
            }
        }
    }
}
