// Reference for this assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis; // Needed to create lists.

class Program
{
    static void Main(string[] args)
    {
        // Instead of using integers, use double so that the average computered
        // later is a decimal.
        List<double> numbers = new List<double>();

        double number = -1; // need some initial number value to enter while loop

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Reference of while loop: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html  
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = double.Parse(Console.ReadLine());
            // When computing the average later, I do not want 0 added to the list.
            // So, I include an if statement so that 0 is not added to the list.
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        double sum = 0; // sum needs to be 0 to start with

        foreach (double num in numbers)
        {
            // example: first time num = 18 and sum = 0
            // second time num = 36 and sum = 18
            sum += num; // same as sum = sum + num
        }

        Console.WriteLine($"The sum is: {sum}");

        // numbers.Count is the count of items (or amount of numbers) in the numbers list
        double avg = sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");
    }
}