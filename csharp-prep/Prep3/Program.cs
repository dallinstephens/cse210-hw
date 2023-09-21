// Reference for this assignment: https://byui-cse.github.io/cse210-course-2023/unit01/csharp-3.html

using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference for random number: https://www.w3schools.blog/c-random-number-between-1-and-100
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 101); // returns random number between 1-101 (includes 1 & 100, excludes 101)

        int guess;

        int howManyGuesses = 1;

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

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
                Console.WriteLine($"Number of guesses: {howManyGuesses}");
            }
            howManyGuesses++; // This is same as howManyGuesses = howManyGuesses + 1;
        } while (guess != magicNumber);
    }
}