// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/develop.html

using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Reference on how to have a multiline string:
        // https://ironpdf.com/blog/net-help/csharp-multiline-string/#:~:text=This%20can%20be%20done%20by,in%20C%23%2010.%22%22%22
        string text =
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
        "In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture("Proverbs 3:5-6", text);

        // Clears the console initially when the program starts
        Console.Clear();

        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("How many words do you want to disappear each time?");
        Console.Write("> ");
        int numberOfWordsToDisapperEachTime = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("Do you want the first letter of each word to appear (y/n)?");
        Console.Write("> ");
        string firstLetter = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Choose a scripture from a list.");
        Console.WriteLine("2. Enter your own scripture.");
        Console.Write("> ");
        int option = int.Parse(Console.ReadLine());

        Console.Clear();
        if (option == 2)
        {
            Console.WriteLine("Please enter a scripture reference:");
            Console.Write("> ");
            string reference = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the text for the scripture reference:");
            Console.Write("> ");
            string textForScripture = Console.ReadLine();

            scripture = new Scripture(reference, textForScripture);
        }

        Console.Clear();
        scripture.DisplayScripture();

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        // Waits for the user to press the enter key
        string userInput = Console.ReadLine();

        // Clears the console when user presses enter
        Console.Clear();

        // Reference on how to generate random numbers without repeating:
        // https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c/30014963#30014963
        // Example from reference:
        // List<int> listNumbers = new List<int>();
        // do
        //     {
        //         int number = rand.Next(1,49);
        //         if(!listNumbers.Contains(number)) {
        //             listNumbers.Add(number);
        //         }
        //     } while (listNumbers.Count < 6)

        // This list is empty initially.
        List<int> listContainingRandomIndexes = new List<int>();

        Word word = new Word();

        do
        {
            if (firstLetter == "y")
            {
                word = new Word(scripture.ReturnScriptureWordList(), firstLetter);
                scripture.HideWordInList(word.ReturnHiddenWordIndex(), word.ReturnHiddenWord());
            }
            else
            {
                word = new Word(scripture.ReturnScriptureWordList());
                scripture.HideWordInList(word.ReturnHiddenWordIndex(), word.ReturnHiddenWord());
            }

            if (!listContainingRandomIndexes.Contains(word.ReturnHiddenWordIndex()))
            {
                listContainingRandomIndexes.Add(word.ReturnHiddenWordIndex());

                // Reference on how to use modulus:
                // https://www.w3schools.com/cs/cs_operators.php
                if (listContainingRandomIndexes.Count % numberOfWordsToDisapperEachTime == 0 || listContainingRandomIndexes.Count == scripture.ReturnScriptureWordList().Count)
                {
                    scripture.DisplayScripture();

                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    // Waits for the user to press the enter key
                    userInput = Console.ReadLine();

                    // Clears the console when user presses enter
                    Console.Clear();
                }
            }
        } while ((listContainingRandomIndexes.Count < scripture.ReturnScriptureWordList().Count) && userInput != "quit");
    }
}