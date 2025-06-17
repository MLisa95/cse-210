using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 7.2);
        Rectangle rectangle = new Rectangle("red", 4.4, 7.9);
        Circle circle = new Circle("blue", 3.41);

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():0.00}\n");
        }
    }
}