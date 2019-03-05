using System;

namespace Polygons.Library
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) :
            base(3, length)
        { }
        /*
         * Abstract class requires you to impliment all abstract classes from the inherited class. 
         * This is regardless of you needing to use them.
         */
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
