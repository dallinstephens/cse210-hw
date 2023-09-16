using System;

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

        if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else if (gradePercentage % 10 >= 7)
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