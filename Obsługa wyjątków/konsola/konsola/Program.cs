using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Osoba = new Osoba("Fabian","Gajda");
            Konto konto = new Konto("Wojciech","Gajda",615,1234);
            int PIN;
            Console.WriteLine("Podaj pin");
            PIN=int.Parse(Console.ReadLine());
            konto.wyplata(300, PIN);
            konto.info(PIN);
            Console.ReadKey();
        }
    }
}
