using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rysowanie
{
    class FunkcjaKwadratowa
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public FunkcjaKwadratowa() { }
        public FunkcjaKwadratowa(double a, double b) { A = a; B = b; }

        public FunkcjaKwadratowa(double a, double b, double c) { A = a; B = b; C = c; }
        public Punkt Wierzchołek() 
        {
                double delta;
                delta = (B * B) - (4 * A * C);
                double p = -B / (2 * A);
                double q = -delta / (4 * A);
                Punkt wierz = new Punkt(p, q);
                return wierz;
        }

        public double MiejsceZeroweL()
        {
            double x=(-B)/A;
            return x;

        }
        public String MiejsceZerowe()
        {
            double delta;
            delta = (B * B) - 4 * A * C;
            if (delta > 0)
            {
                double x1 = (-(B - Math.Sqrt(delta)) / (2 * A));
                double x2 = (-(B + Math.Sqrt(delta)) / (2 * A));
                return string.Format("Miejsca zerowe to ({0};0) i ({1};0)", x1, x2);  
            }
            if(delta == 0)
            {
                double x = (-B / (2 * A));
                return string.Format("Miejsce zerowe to ({0},0)", x);  
            }
            if(delta < 0)
            {
                return string.Format("nie przecina osi X");
            }
            return string.Format("Err");
        }
        public String info()
        {
            return string.Format("funkcja kwadratowa {0}x+({1}) ma miejsce zerowe punkcie ({2},0)", A, B, MiejsceZeroweL());
            
        }
        public String info2()
        {
            double delta = (B * B) - (4 * A * C);
            double p = -B / (2 * A);
            double q = -delta / (4 * A);
            return string.Format("funkcja kwadratowa {0}x^2+({1}x)+({2}) ma wierzchołek w ({3},{4}) i {5}", A, B, C, p,q, MiejsceZerowe());
        }
    }
}
