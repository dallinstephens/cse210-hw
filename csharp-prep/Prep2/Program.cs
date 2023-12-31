using System;
// Assignment Reference: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-2.html

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercent = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercent);

        string letterGrade;

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        string sign;

        // Modulus Reference: https://www.w3schools.com/cs/cs_operators.php
        if (gradePercentage % 10 < 3 && letterGrade != "F")
        {
            sign = "-";
        }
        else if (gradePercentage % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            sign = "+";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Letter Grade: {letterGrade}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Please try again.");
        }
    }
}