using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WielokatKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon pieciokat=new Polygon(5,4,2,3);
            Rectangle kwadrat = new Rectangle(2, 3, 8);
            Triangle trojkat = new Triangle(1, 2, 5);
            Console.WriteLine(pieciokat.Data());
            Console.WriteLine(kwadrat.Data());
            Console.WriteLine(trojkat.Data());
            Console.ReadKey();
        }
    }
}
