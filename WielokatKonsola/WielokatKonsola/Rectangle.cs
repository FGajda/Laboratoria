using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WielokatKonsola
{
    class Rectangle:Polygon
    {
        public Rectangle(int X, int Y, double SideSize): base(X, Y, SideSize)
        {
            NumberOfSides = 4;
            Angle = Math.PI / 2;
            R = SideSize / (2 * Math.Sin(Math.PI / 4));
        }
        public double Area()
        {
            return SideSize * SideSize;
        }
        public override string Data()
        {
            return string.Format("Figura to kwadrat o polu {0} i obwodzie {1}", Area(), Perimeter());
        }
    }
}
