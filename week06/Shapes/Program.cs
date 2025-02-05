using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
//      Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine("This is the Shape Area Calculator!\n");

        // Create different shape objects
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Circle("Green", 3),
            new Triangle("Yellow", 5, 8),
            new Trapezoid("Purple", 6, 4, 5),
            new Hexagon("Orange", 7)
        };

        // Display shape details
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}\n");
        }
    }
}
