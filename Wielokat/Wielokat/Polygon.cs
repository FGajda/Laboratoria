using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wielokat
{
    class Polygon
    {
        int NumberOfSides { get; set; }
        double SideSize { get; set; }
        List<double> Sides;
        Point Centre();
        double Angle;
        double R;

        public Polygon() { }
        public Polygon(int X, int Y, double Sidesize) 
        { Centre(X, Y); double SideSize = Sidesize; }
        public Polygon(int NumberofSides, double Sidesize, int X, int Y)
        {
            NumberOfSides = NumberofSides; SideSize = Sidesize; Centre(X, Y);
            Angle = 2 * Math.PI / NumberOfSides;
            R = SideSize / (2 * Math.Sin(Math.PI / NumberOfSides));
        }

        public double Perimeter()
        {
            double Ob = SideSize * NumberOfSides;
            return Ob;
        }
        public virtual void Data()
        {
            
        }
    }
}
