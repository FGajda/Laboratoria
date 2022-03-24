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
            int[] tablica= Tablice.Tablica.GenerowanieJeden(wielkosc);
            for (int i = 0; i < wielkosc; i++)
            {
                Console.WriteLine("{0}", tablica[i]);
            }
        }
    }
}
