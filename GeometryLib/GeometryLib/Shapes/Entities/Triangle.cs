using GeometryLib.Shapes.Interfaces;

namespace GeometryLib.Shapes.Entities;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sideA);
        ArgumentOutOfRangeException.ThrowIfNegative(sideB);
        ArgumentOutOfRangeException.ThrowIfNegative(sideC);
        
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Error: sides do not form a triangle");
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public bool IsRightTriangle()
    {
        return Math.Pow(SideC, 2).CompareTo(Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) == 0 ||
               Math.Pow(SideA, 2).CompareTo(Math.Abs(Math.Pow(SideC, 2) + Math.Pow(SideB, 2))) == 0 ||
               Math.Pow(SideB, 2).CompareTo(Math.Abs(Math.Pow(SideC, 2) + Math.Pow(SideA, 2))) == 0;
    }
    public double CountArea()
    {
        var p = ( SideA + SideB + SideC ) / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        
    }
}