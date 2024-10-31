namespace SolidPrinciples;

// Step 2: Implement Shape Classes

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// Step 4: Adding New Shapes

public class Triangle : IShape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}