using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l3
{
    class Program
    {
        static void kolo(double promien, ref double pole, ref double obwod) {
            pole = Math.PI * promien * promien;
            obwod = 2 * Math.PI * promien;
        }
        static void silnia(double liczba, ref double wynik) {
            int silnia = 1;
            for (int i = 1; i <= liczba; i++) {
                silnia = silnia * i;
            }
            wynik = silnia;
        }
        static long silnia2(int wynik) {
            if (wynik == 1)
                return 1;
            else
                return wynik * silnia2( wynik - 1);
            }
        static void NWD(double a, double b, ref double wyn) {
            double c = 0;
            c = a % b;
            a = b;
            b = c;
            wyn = a;
            if (b != 0)
            NWD(a,b,ref wyn); 
        }
        static void NWW(double a, double b, double c,ref double wynik) {
            wynik = a*b / c;
        }
        static void druk(int[] tab) {
            for (int i = 0; i < 10; i++)
              Console.WriteLine("{0}",tab[i]);
        }

        static void Main(string[] args)
        {
            double a,b,pole=0, obwod=0;
            int[] tablica = { 2, 4, 5, 7, 8, 11, 0, 30, 5, 3 };
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            /*pole = Math.PI * a * a;
            obwod = 2 * Math.PI * a;
            kolo(a,ref pole,ref obwod);
            Console.WriteLine("Obwod: {0}\n Pole : {1}\n", obwod, pole);*/
            //silnia(a, ref pole);
            /*
            int z;
            z = int.Parse(Console.ReadLine());
            silnia2(z);
            Console.WriteLine("{0}", z); */
            //NWD(a, b, ref pole);
            /*NWD(a, b, ref obwod);
            NWW(a, b,obwod,ref pole);*/
            //Console.WriteLine("{0}", pole);

            Console.ReadKey();
        }
    }
}
