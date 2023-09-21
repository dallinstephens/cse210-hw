// Reference for this assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumberString = Console.ReadLine();
        // Reference for int.Parse() function: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-2.html
        int magicNumber = int.Parse(magicNumberString);

        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}