using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] tablica = new int[5];
            for (int i = 0; i < 5; i++) {
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine("{0}",tablica[i]);
            int[,] tablica = new int[5, 2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("jestes {0},{1}", i, j);
                tablica[i,j] = int.Parse(Console.ReadLine());
            }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("jest to {0},{1}", i, j);
                    Console.WriteLine("{0}", tablica[i,j]);
                }
            }*/
            int liczba, maks = 0;
            int[] tablica ={2,4,5,7,8,11,0,30,5,3};
            for(int i=0;i<10;i++){
                liczba = tablica[i];
                if(maks<liczba){
                    maks=liczba;
                }
            }
            Console.WriteLine("{0}", maks);
            Console.ReadKey();
        }
    }
}
