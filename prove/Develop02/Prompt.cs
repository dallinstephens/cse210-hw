using System;
using System.Collections.Generic;

public class Prompt
{

    // Reference on how to create a C# list:
    // https://www.w3schools.blog/c-sharp-list
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I want to remember about today?"
    };

    public string RandomPrompt()
    {
        // Reference for random number:
        // https://www.w3schools.blog/c-random-number-between-1-and-100
        Random randomNumberGenerator = new Random();
        // Generates a random number between 0-5 (includes 0, excludes 5)
        // int index = randomNumberGenerator.Next(0, 5);
        // Reference to get the number of elements in a list:
        // https://linuxhint.com/c-sharp-list-length/
        // This line of code below makes it so that if I add new prompts to 
        // the list, I don't need to keep changing the right number in .Next
        int index = randomNumberGenerator.Next(0, _prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }

    public void PromptList()
    {
        Console.WriteLine("Please select one:");
        int i = 1;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"{i}. {prompt}");
            i++;
        }
        Console.ResetColor();
    }

    public string ChosenPrompt(int numberChoice)
    {
        int index = numberChoice - 1;
        string chosenPrompt = _prompts[index];
        return chosenPrompt;
    }
}