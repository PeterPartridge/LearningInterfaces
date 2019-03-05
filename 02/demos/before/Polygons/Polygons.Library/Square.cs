namespace Polygons.Library
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) :
            base(4, length)
        { }
        /*
         * When the below method is commented out the project will continue to compile,
         * but will throw the not implimented execption in the concrete class that is inherited.        
         * Nothing is forcing an overide.
         */
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
