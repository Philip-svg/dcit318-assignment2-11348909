// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
}

// Circle class derived from Shape
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class derived from Shape
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a circle with radius 5
        Shape circle = new Circle(5);
        Console.WriteLine($"Area of Circle (radius 5): {circle.GetArea():F2}");

        // Create a rectangle with width 4 and height 6
        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Area of Rectangle (4x6): {rectangle.GetArea():F2}");
    }
}
