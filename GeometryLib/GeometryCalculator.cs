using GeometryLib.Figures;

namespace GeometryLib;

public static class GeometryCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}