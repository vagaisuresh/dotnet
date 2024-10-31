namespace SolidPrinciples;

public class AreaCalculator
{
    public double CalculateTotalArea(IEnumerable<IShape> shapes)
    {
        double totalArea = 0;

        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
        }

        return totalArea;
    }
}