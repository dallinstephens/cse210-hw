// Reference for this assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());
        fraction1.SetTop(8);
        fraction1.SetBottom(9);
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        fraction2.SetTop(10);
        fraction2.SetBottom(11);
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        fraction3.SetTop(12);
        fraction3.SetBottom(13);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
    }
}