using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WielokatKonsola
{
    class Triangle:Polygon
    {
        double Height { get; set; }
        public Triangle(int X, int Y, double SideSize): base(X, Y, SideSize)
        {
            NumberOfSides = 3;
            Angle = 2 * Math.PI / 3;
            R = SideSize / (2 * Math.Sin(Math.PI / 3));
            Height = SideSize * Math.Sqrt(3) / 2;
        }
        public double Area()
        {
            return 1 / 2 * SideSize * Height;
        }
        public override string Data()
        {
            return string.Format("Figura to Trójkąt o polu {0} i obwodzie {1}", Area(), Perimeter());
        }
    }
}
