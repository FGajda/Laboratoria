using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konsola
{
    class FunkcjaKwadratowa
    {
        
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public FunkcjaKwadratowa() { }
        public FunkcjaKwadratowa(int a, int b, int c) { A = a; B = b; C = c; }
        Punkt Wierzchołek() 
        {
                float delta;
                delta = (B * B) - (4 * A * C);
                float p = -B / (2 * A);
                float q = -delta / (4 * A);
                Punkt wierz = new Punkt(p, q);
                return wierz;
        }
        double MiejsceZerowe()
        {
            float delta;
            delta = (B * B) - (4 * A * C);
            if (delta > 0)
            {
                double x1 = (-B - Math.Sqrt(delta) / (2 * A));
                double x2 = (-B + Math.Sqrt(delta) / (2 * A));
                return Console.WriteLine("Miejsca zerowe to {0} i {1}", x1, x2);
            }
            if (delta == 0)
            {
                double x = (-B / (2 * A));
                return Console.WriteLine("Miejsce zerowe to {0}", x);
            }
            if (delta < 0)
            {
                return Console.WriteLine("Brak miejsc zerowych");
            }
            
        }
        public String info()
        {
            return string.Format("funkcja kwadratowa {0}x^2+({1}x)+({2}) ma wierzchołek w {3} i {4}", A, B, C, Wierzchołek(), MiejsceZerowe());
        }
    }
}
