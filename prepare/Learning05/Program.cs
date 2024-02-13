using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("white", 5,3));
        shapes.Add(new Circle("Yellow", 5));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}