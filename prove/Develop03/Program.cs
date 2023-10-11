// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/develop.html

using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        string scripture = "Trust in the Lord with all";

        // Reference how to split string:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
        // Reference how to split string into a list:
        // https://www.techiedelight.com/split-a-delimited-string-into-a-list-in-csharp/
        List<string> scriptureWordList = new List<string>(scripture.Split(' '));

        // Reference how generate random numbers without repeating:
        // https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c/30014963#30014963
        // Example used from reference:
        // List<int> listNumbers = new List<int>();
        // do
        //     {
        //         int number = rand.Next(1,49);
        //         if(!listNumbers.Contains(number)) 
        //         {
        //             listNumbers.Add(number);
        //         }
        //     } while (listNumbers.Count < 6);


        // Iterates through each word in the scripture word list
        // foreach (string word in scriptureWordList)
        // {
        //     Console.WriteLine(word);
        // }
        List<int> listContainingRandomIndexes = new List<int>();

        // Clears the console initially when the program starts
        Console.Clear();

        // Prints the entire scripture initially
        Console.WriteLine(scripture);

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        // Waits for the user to press the enter key
        string userInput = Console.ReadLine();

        // Clears the console when user presses enter
        Console.Clear();

        do
        {
            Random randomNumberGenerator = new Random();
            // Reference how to get the number of elements in a list:
            // https://linuxhint.com/c-sharp-list-length/        
            int index = randomNumberGenerator.Next(0, scriptureWordList.Count);

            if (!listContainingRandomIndexes.Contains(index))
            {
                listContainingRandomIndexes.Add(index);

                // Prints random word:
                // Console.WriteLine(scriptureWordList[index]);

                // Reference how to replace list item:
                // https://stackoverflow.com/questions/17188966/how-to-replace-list-item-in-best-way
                // Example: scriptureWordList[index] = "Dallin";

                // Reference how to find length of a string:
                // https://www.w3schools.com/cs/cs_strings.php
                // Example: Console.WriteLine(scriptureWordList[index].Length);
                int wordLength = scriptureWordList[index].Length;

                // Reference how to repeat a character x number of times:
                // https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
                // Example: string myString = new String('-', 5); result: -----
                // Alternative shortcut: string MyString = new('-', 5); result: -----

                scriptureWordList[index] = new('_', wordLength);

                // Prints random word replacement with '_': 
                // Console.WriteLine(scriptureWordList[index]);

                foreach (string word in scriptureWordList)
                {
                    Console.Write($"{word} ");
                }

                Console.WriteLine();

                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                // Waits for the user to press the enter key
                userInput = Console.ReadLine();

                // Clears the console when user presses enter
                Console.Clear();
            }
        } while ((listContainingRandomIndexes.Count < scriptureWordList.Count) && userInput != "quit");
    }
}