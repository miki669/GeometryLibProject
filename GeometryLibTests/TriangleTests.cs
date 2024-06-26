using GeometryLib;
using GeometryLib.Figures;

namespace GeometryLibTests;

public class TriangleTests
{
    [Test]
    public void CalculateArea_ValidSides_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = GeometryCalculator.CalculateArea(triangle);
        Assert.AreEqual(6, area, 1e-10);
    }

    [Test]
    public void Constructor_InvalidSides_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Test]
    public void IsRightAngled_RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        var isRightAngled = triangle.IsRightAngled();
        Assert.IsTrue(isRightAngled);
    }

    [Test]
    public void IsRightAngled_NotRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3, 4, 6);
        var isRightAngled = triangle.IsRightAngled();
        Assert.IsFalse(isRightAngled);
    }
}