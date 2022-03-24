using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Osoba> ListaOsob = new List<Osoba>();
            ListaOsob.Add(new Osoba(1234, "Jan", "Kowalski", 25));
            ListaOsob.Add(new Osoba(1235, "Jan", "Nowak", 40));
            ListaOsob.Add(new Osoba(1236, "Jan", "Niekowalski", 70));

            foreach(Osoba O in ListaOsob)
            {
                Console.WriteLine("{0} {1} {2}", O.FirstName, O.LastName, O.Age);
            }
            Console.ReadKey();
            */
            Bank bank = new Bank();
            bank.StartMenu();
        }
    }
}
