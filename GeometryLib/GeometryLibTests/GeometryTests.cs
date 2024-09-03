using GeometryLib.Shapes.Entities;
using GeometryLib.Shapes.Interfaces;

namespace GeometryLibTests;

[TestFixture]
public class GeometryTests
{
    [TestCase(-1)]
    [TestCase(-0.00001)]
    public void Circle_InvalidRadiusTest_ReturnsArgumentOutOfRangeException(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            IShape circle = new Circle(radius);
        });
    }
    
    [TestCase(10)]
    [TestCase(0.04)]
    public void Circle_ValidRadiusTest_ReturnsNoException(double radius)
    {
        Assert.DoesNotThrow(() =>
        {
            IShape circle = new Circle(radius);
        });
    }
    
    [TestCase(10, 314.1592653589793)]
    [TestCase(0.04, 0.0050265482457436689)]
    public void Circle_CountSquareTest_ReturnsTrue(double radius, double expected)
    {
        IShape circle = new Circle(radius);
        
        Assert.That(circle.CountArea(), Is.EqualTo(expected));
    }
    
    [TestCase(3, 4 ,1)]
    [TestCase(0.04, 0.05, 0.003)]
    public void Triangle_InvalidSides_ReturnsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            IShape triangle = new Triangle(a, b, c);
        });
    }
    
    [TestCase(-3, 4 ,5)]
    [TestCase(-0.6, -0.6, -1)]
    public void Triangle_InvalidSides_ReturnsArgumentOutOfRangeException(double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            IShape triangle = new Triangle(a, b, c);
        });
    }
    
    [TestCase(1.1, 2 ,3)]
    [TestCase(0.6, 0.6, 1)]
    public void Triangle_InvalidSides_ReturnsNoException(double a, double b, double c)
    {
        Assert.DoesNotThrow(() =>
        {
            IShape triangle = new Triangle(a, b, c);
        });
    }
    
    [TestCase(3, 4 ,5, 6)]
    [TestCase(0.6, 0.6, 0.8, 0.17888543819998318)]
    public void Triangle_CountSquare_ReturnsTrue(double a, double b, double c, double expected)
    {
        IShape triangle = new Triangle(a, b, c);
        
        Assert.That(triangle.CountArea(), Is.EqualTo(expected));
    }
    
    [TestCase(3, 7 ,5)]
    [TestCase(0.6, 0.6, 0.8)]
    public void Triangle_IsRightTriangle_ReturnsFalse(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        
        Assert.That(triangle.IsRightTriangle(), Is.False);
    }
    
    [TestCase(3, 4 ,5)]
    [TestCase(13, 23.3, 26.681266836490355)]
    public void Triangle_IsRightTriangle_ReturnsTrue(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        
        Assert.That(triangle.IsRightTriangle(), Is.True);
    }
}