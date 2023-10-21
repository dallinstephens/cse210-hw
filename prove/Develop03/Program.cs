// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/develop.html

// WAYS MY PROGRAM SHOWS CREATIVITY AND EXCEEDS CORE REQUIRMENTS:
// 1. The user can pick a scripture from a list or input a scripture.
// 2. Invalid user input is accounted for.
// 3. The user can pick how many words to disappear each time.
// 4. The user can pick to show the first letter of each word or not.

using System;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Reference on how to have a multiline string:
        // https://ironpdf.com/blog/net-help/csharp-multiline-string/#:~:text=This%20can%20be%20done%20by,in%20C%23%2010.%22%22%22
        string text;

        Scripture scripture = new Scripture();

        InvalidResponse invalid = new InvalidResponse();

        // Clears the console initially when the program starts
        Console.Clear();

        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        int option = -1;

        while (option != 1 && option != 2)
        {
            // Reference on how to handle exception if the user enters a non-numeric responce:
            // https://stackoverflow.com/questions/34486216/c-sharp-how-can-i-create-an-exception-for-non-numeric-on-this-code
            try
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Choose a scripture from a list.");
                Console.WriteLine("2. Input a scripture.");
                Console.Write("> ");
                option = int.Parse(Console.ReadLine());

                Console.Clear();

                if (option == 1)
                {
                    int selection = -1;

                    while (selection != 1 && selection != 2 && selection != 3)
                    {
                        try
                        {
                            Console.WriteLine("Please select one:");
                            Console.WriteLine("1. 1 Nephi 3:7.");
                            Console.WriteLine("2. Alma 37:36-37.");
                            Console.WriteLine("3. Proverbs 3:5-6.");
                            Console.Write("> ");

                            selection = int.Parse(Console.ReadLine());

                            if (selection == 1)
                            {
                                text =
                                "And it came to pass that I, Nephi, said unto my father: " +
                                "I will go and do the things which the Lord hath commanded, " +
                                "for I know that the Lord giveth no commandments unto the children of men, " +
                                "save he shall prepare a way for them that they may accomplish the thing " +
                                "which he commandeth them.";

                                scripture = new Scripture("1 Nephi 3:7", text);
                            }
                            else if (selection == 2)
                            {
                                text =
                                "Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, " +
                                "and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed " +
                                "unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever. " +
                                "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou " +
                                "liest down at night lie down unto the Lord, that he may watch over you in your sleep; and " +
                                "when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these " +
                                "things, ye shall be lifted up at the last day.";

                                scripture = new Scripture("Alma 37:36-37", text);
                            }
                            else if (selection == 3)
                            {
                                text =
                                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                                "In all thy ways acknowledge him, and he shall direct thy paths.";

                                scripture = new Scripture("Proverbs 3:5-6", text);
                            }
                            else
                            {
                                invalid.DisplayInvalidResponse();
                            }
                        }
                        catch (FormatException)
                        {
                            invalid.DisplayInvalidResponse();
                        }
                    }
                }
                else if (option == 2)
                {
                    string reference = "";

                    // Reference to find character in a string:
                    // https://www.programiz.com/csharp-programming/library/string/indexof
                    // IndexOf of -1 is returned if character is not found.

                    while (reference.IndexOf(":") == -1 || reference.IndexOf(" ") == -1)
                    {
                        Console.WriteLine("Please enter a scripture reference:");
                        Console.Write("> ");
                        reference = Console.ReadLine();
                        Console.Clear();
                        if (reference.IndexOf(":") == -1 || reference.IndexOf(" ") == -1)
                        {
                            invalid.DisplayInvalidResponse();
                        }
                    }

                    Console.WriteLine("Please enter the text for the scripture reference:");
                    Console.Write("> ");
                    text = Console.ReadLine();

                    scripture = new Scripture(reference, text);
                }
                else
                {
                    invalid.DisplayInvalidResponse();
                }

            }
            catch (FormatException)
            {
                invalid.DisplayInvalidResponse();
            }
        }

        Console.Clear();

        int numberOfWordsToDisappearEachTime = -1;

        while (numberOfWordsToDisappearEachTime < 1)
        {
            try
            {
                Console.WriteLine("How many words do you want to disappear each time?");
                Console.Write("> ");

                numberOfWordsToDisappearEachTime = int.Parse(Console.ReadLine());

                if (numberOfWordsToDisappearEachTime > 0)
                {
                    scripture.SetNumberOfWordsToDisappearEachTime(numberOfWordsToDisappearEachTime);
                }
                else
                {
                    invalid.DisplayInvalidResponse();
                }
            }
            catch (FormatException)
            {
                invalid.DisplayInvalidResponse();
            }
        }

        Console.Clear();

        string includeFirstLetter = "";

        while (includeFirstLetter != "y" && includeFirstLetter != "n")
        {
            Console.WriteLine("Do you want the first letter of each word to appear (y/n)?");
            Console.Write("> ");
            includeFirstLetter = Console.ReadLine();
            if (includeFirstLetter == "n")
            {
                scripture.IncludeFirstLetter(false);
            }
            else if (includeFirstLetter == "y")
            {
                scripture.IncludeFirstLetter(true);
            }
            else
            {
                invalid.DisplayInvalidResponse();
            }
        }

        Console.Clear();

        string userInput;

        bool allWordsAreHiddenStatus;

        do
        {
            // This is used to exit the program after all words have been hidden.
            allWordsAreHiddenStatus = scripture.AllWordsAreHiddenStatus();

            scripture.DisplayScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            // Waits for the user to press the enter key
            userInput = Console.ReadLine();

            scripture.HideWordsRandomly();

            // Clears the console when user presses enter
            Console.Clear();
        } while (userInput != "quit" && allWordsAreHiddenStatus != true);
    }
}