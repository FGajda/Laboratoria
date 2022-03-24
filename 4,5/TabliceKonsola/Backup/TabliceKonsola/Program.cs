using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabliceKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiekość tablicy");
            int wielkosc = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj drugą wiekość tablicy");
            //int wielkosc2 = int.Parse(Console.ReadLine());
            int[] tablica = Tablice.Tablica.GenerowanieJeden(wielkosc);
            //int[,] tablica2 = Tablice.Tablica.GenerowanieDwa(wielkosc,wielkosc2);
            for (int i = 0; i < wielkosc; i++)
            {
                Console.WriteLine("{0}\t", tablica[i]);
            }
            Tablice.Tablica.Sortowanie(ref tablica, wielkosc);
            for (int i = 0; i < wielkosc; i++)
            {
                Console.WriteLine("{0}", tablica[i]);
            }
            /*for (int i = 0; i < wielkosc; i++)
            {
                for (int j = 0; j < wielkosc2; j++)
                {
                    Console.WriteLine("jest to {0},{1}", i, j);
                    Console.WriteLine("{0}", tablica2[i,j]);
                }
            }*/
            Console.ReadKey();
        }
    }
}
