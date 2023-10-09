// Reference for this assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        fraction.SetTop(8);
        fraction.SetBottom(9);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        fraction = new Fraction(6);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        fraction.SetTop(10);
        fraction.SetBottom(11);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        fraction = new Fraction(6, 7);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        fraction.SetTop(12);
        fraction.SetBottom(13);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
    }
}