// Reference for this assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis; // Needed to create lists.

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1; // need some initial number value to enter while loop

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Reference of while loop: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html  
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = 0; // sum needs to be 0 to start with

        foreach (int num in numbers)
        {
            // example: first time num = 18 and sum = 0
            // second time num = 36 and sum = 18
            sum += num; // same as sum = sum + num
        }

        Console.Write($"The sum is: {sum}");
    }
}