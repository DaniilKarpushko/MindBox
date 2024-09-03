using GeometryLib.Shapes.Interfaces;

namespace GeometryLib.Shapes.Entities;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(radius);
        Radius = radius;
    }
    public double CountArea()
    {
        return Math.PI * Math.Pow( Radius, 2);
    }
}