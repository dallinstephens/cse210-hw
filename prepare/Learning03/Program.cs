// Reference for this assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

using System;

class Program
{
    static void Main(string[] args)
    {
        // This is like inputting the whole number 1 since it is the default.
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        // Console.WriteLine(fraction.GetTop());
        // Console.WriteLine(fraction.GetBottom());
        // fraction.SetTop(8);
        // fraction.SetBottom(9);
        // Console.WriteLine(fraction.GetTop());
        // Console.WriteLine(fraction.GetBottom());

        fraction = new Fraction(5);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction = new Fraction(3, 4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction = new Fraction(1, 3);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}