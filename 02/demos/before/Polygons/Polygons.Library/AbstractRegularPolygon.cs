namespace Polygons.Library
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        
        public AbstractRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        // This is a decleration and requires child class to impliment. 
        public abstract double GetArea();
      //  public abstract string HelloWorld();
    }
}
