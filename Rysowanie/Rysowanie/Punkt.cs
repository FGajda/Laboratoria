using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rysowanie
{
    class Punkt
    {
            public double X { get; set; }
            public double Y { get; set; }
            public Punkt(double x, double y) { X = x; Y = y; }

        public string info() { return string.Format("({0},{1})", X, Y); }
    }
}
