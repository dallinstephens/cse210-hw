using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercent = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercent);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Letter Grade: A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Letter Grade: B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Letter Grade: C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Letter Grade: D");
        }
        else
        {
            Console.WriteLine("Letter Grade: F");
        }

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