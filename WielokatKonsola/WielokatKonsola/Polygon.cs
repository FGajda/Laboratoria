using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WielokatKonsola
{
    class Polygon
    {
        protected int NumberOfSides { get; set; }
        protected double SideSize { get; set; }
        List<double> Sides;
        Point Centre;
        protected double Angle;
        protected double R;
        
        public Polygon() { }
        public Polygon(int X, int Y, double Sidesize)
        { Centre=new Point(X,Y); double SideSize = Sidesize; }
        public Polygon(int NumberofSides, double Sidesize, int X, int Y)
        {
            NumberOfSides = NumberofSides; SideSize = Sidesize; Centre=new Point(X,Y);
            Angle = 2 * Math.PI / NumberOfSides;
            R = SideSize / (2 * Math.Sin(Math.PI / NumberOfSides));
        }

        public double Perimeter()
        {
            return SideSize * NumberOfSides;
        }
        public virtual string Data()
        {
            return string.Format("To jest {0}-kąt, jego obwód wynosi ; {1}.", NumberOfSides, Perimeter());
        }
    }
}
