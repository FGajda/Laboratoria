 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            FunkcjaKwadratowa Kwadrat = new FunkcjaKwadratowa(5, 8, 3);
            Console.WriteLine(Kwadrat.info());
            Console.ReadKey();
        }
    }
}
