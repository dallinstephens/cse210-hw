// Reference for this assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-4.html
// Reference for solution: https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/csharp-prep/Prep4/Program.cs
// Reference for double: https://www.w3schools.com/cs/cs_data_types.php

// Core Requirements
// 1. Compute the sum, or total, of the numbers in the list.
// 2. Compute the average of the numbers in the list.
// 3. Find the maximum, or largest, number in the list.

// Stretch Challenge
// 1. Have the user enter both positive and negative numbers, then 
// find the smallest positive number (the positive number that is 
// closest to zero).

// 2. Sort the numbers in the list and display the new, sorted list. 
// Hint: There are C# libraries that can help you here, try searching 
// the internet for them.

using System;
using System.Collections.Generic; // Needed to create lists.
using System.Diagnostics.CodeAnalysis;

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
            // When computing the average later, I do not want 0 added to the list.
            // So, I include an if statement so that 0 is not added to the list.
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0; // sum needs to be 0 to start with

        foreach (int num in numbers)
        {
            // example: first time num = 18 and sum = 0
            // second time num = 36 and sum = 18
            sum += num; // same as sum = sum + num
        }

        Console.WriteLine($"The sum is: {sum}");

        // numbers.Count is the count of items (or amount of numbers) in the numbers list
        // (double)sum is used so that average will be a decimal.
        // By making sum a double first, the computer knows to do a double division.
        double avg = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        // want a large negative number in case negative numbers are in the numbers list
        int largestNumber = -999999999;

        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        // initially set smallestPositiveNumber to largestNumber
        int smallestPositiveNumber = largestNumber;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositiveNumber)
            {
                smallestPositiveNumber = num;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        // Reference on how to sort a list: https://www.educative.io/answers/how-to-sort-a-list-in-c-sharp
        numbers.Sort(); // Sorts the numbers list in ascending order

        Console.Write("New sorted numbers list: ");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
    }
}