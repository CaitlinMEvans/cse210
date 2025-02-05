using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Triangle : Shape
{
    private double _base;
    private double _height;

    public Triangle(string color, double baseLength, double height) : base(color)
    {
        _base = baseLength;
        _height = height;
    }

    public override double GetArea()
    {
        return 0.5 * _base * _height;
    }
}

public class Trapezoid : Shape
{
    private double _base1;
    private double _base2;
    private double _height;

    public Trapezoid(string color, double base1, double base2, double height) : base(color)
    {
        _base1 = base1;
        _base2 = base2;
        _height = height;
    }

    public override double GetArea()
    {
        return 0.5 * (_base1 + _base2) * _height;
    }
}

public class Hexagon : Shape
{
    private double _side;

    public Hexagon(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return (3 * Math.Sqrt(3) / 2) * (_side * _side);
    }
}
