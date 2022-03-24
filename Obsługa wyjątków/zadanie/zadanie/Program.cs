using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            Class nowy = new Class(4);
            Console.WriteLine("{0}",nowy.w1);
            nowy.w1=44;
            nowy.w1=17;
            Console.WriteLine("{0}",nowy.w1);
            Console.ReadKey();
        }
    }
}
