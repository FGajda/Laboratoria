using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tablice
{
    public class Tablica
    {
        public static int[] GenerowanieJeden (int n)
        {
            Random A = new Random();
            int[] tab = new int[n];
            for(int i=0;i<n;i++)
            {
                tab[i]=A.Next(100);
            }
            return tab;
        }
        public static int[,] GenerowanieDwa(int n,int n2)
        {
            Random A = new Random();
            int[,] tab = new int[n,n2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    tab[i,j] = A.Next(100);
                }
            }
            return tab;
        }
        public static void Sortowanie(ref int[] tab,int n) 
        {
            int temp;
            for (int i = 1; i < n; i++) 
            {
                for(int j=1;j<n;j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
        public static void Sortowanie(ref int[,] tab, int n, int n2)
        {
            int temp;
            for (int o = 0; o <= n2; o++)
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        if (tab[j - 1,o] > tab[j,o])
                        {
                            temp = tab[j - 1,o];
                            tab[j - 1,o] = tab[j,o];
                            tab[j,o] = temp;
                        }
                    }
                }
            }
        }
        public static void Mediana(int[] tab, int n,int typ)
        {
            /*if (n % 2 = 0)
            {
                int c = n / 2;
                if (typ == 0) { Console.WriteLine("{0}\t", tablica[c]); }
                if (typ == 1) { MessageBox.Show(
            }*/
        }
    }
}
