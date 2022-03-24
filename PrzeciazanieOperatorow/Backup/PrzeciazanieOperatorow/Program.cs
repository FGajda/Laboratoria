using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrzeciazanieOperatorow
{
    class Program
    {
        static void Main(string[] args)
        {
            KoszOwocow Adam = new KoszOwocow(5, 4, 3);
            KoszOwocow Anna = new KoszOwocow(5, 4, 3);
            Console.WriteLine("Ile maja osobno");
            Console.WriteLine(Adam.ToString());
            Console.WriteLine(Anna.ToString());
            Console.WriteLine("Ile by miał Tomek gdyby odali swoje??");
            KoszOwocow tomek=Adam+Anna;
            Console.WriteLine(tomek.ToString());

            Console.WriteLine("Przetestowanie konwersji");
            if(Adam==Anna)
            {
                Console.WriteLine("Adam i Anna maja tyle samo");
            }
            else
            {
                Console.WriteLine("Maja różna ilosc");
            }
            int z=tomek;
            if(z>8)
            {
                Console.WriteLine("Tomek jest zadowoloony że ma tyle jabłęk: {0}",z);
            }
            else
            {
                Console.WriteLine("Tomek nie jest zadowolony bo ma za mało jabłek");
            }
            Console.ReadKey();
        }
    }
}
