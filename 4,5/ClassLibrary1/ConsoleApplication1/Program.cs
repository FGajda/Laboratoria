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
            int ZmiennaWAplikacji = 35;
            Console.WriteLine(ZmiennaWAplikacji);
            ClassLibrary1.Class1.Metoda(ref ZmiennaWAplikacji);
            Console.WriteLine(ZmiennaWAplikacji);
            Console.ReadKey();
        }
    }
}
