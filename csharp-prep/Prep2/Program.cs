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
            Console.Write("Letter Grade: A");
        }
        else if (gradePercentage >= 80)
        {
            Console.Write("Letter Grade: B");
        }
        else if (gradePercentage >= 70)
        {
            Console.Write("Letter Grade: C");
        }
        else if (gradePercentage >= 60)
        {
            Console.Write("Letter Grade: D");
        }
        else
        {
            Console.Write("Letter Grade: F");
        }
    }
}