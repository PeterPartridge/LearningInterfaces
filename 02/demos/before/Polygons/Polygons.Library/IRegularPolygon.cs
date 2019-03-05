namespace Polygons.Library
{
    // all interfaces are IName
    public interface IRegularPolygon
    {
        // These are declerations and must be declared in the child.
        int NumberOfSides { get; set; }
        int SideLength { get; set; }
        //method declerations. These must be declared in a child.
        double GetPerimeter();
        double GetArea();
    }
}
