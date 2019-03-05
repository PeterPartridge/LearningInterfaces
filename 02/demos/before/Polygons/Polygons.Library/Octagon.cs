using System;

namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        //All sections of the interface must be created.
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }
        /*
         * No overide is needed to create the methods.
         */
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
