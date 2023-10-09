// Reference for this assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

// Reference to sample solution:
// https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/prepare/Learning03/Fraction.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // This is like inputting the whole number 1 since it is the default.
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}