using GeometryLib;
using GeometryLib.Figures;

namespace GeometryLibTests;

public class CircleTests
{
    [Test]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5); 
        var area = GeometryCalculator.CalculateArea(circle);
        Assert.AreEqual(Math.PI * 25, area, 1e-10);
    }

    [Test]
    public void Constructor_NegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}