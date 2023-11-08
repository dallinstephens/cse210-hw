// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
// Reference for sample solution:
// https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/prepare/Learning05/Shape.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Green", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine();

        Rectangle rectangle = new Rectangle("Red", 6, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Console.WriteLine();

        Circle circle = new Circle("Yellow", 8);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
}