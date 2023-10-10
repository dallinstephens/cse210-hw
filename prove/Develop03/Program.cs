// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit03/develop.html

using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "continue";

        while (userInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            // Waits for the user to press the enter key
            userInput = Console.ReadLine();

            // Clears the console when user presses enter
            Console.Clear();

            string scripture = "Trust in the Lord with all";
            // Reference to split string:
            // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
            // Reference to split string into a list:
            // https://www.techiedelight.com/split-a-delimited-string-into-a-list-in-csharp/
            List<string> scriptureWordList = new List<string>(scripture.Split(' '));

            // Iterates through each word in the scripture word list
            // foreach (string word in scriptureWordList)
            // {
            //     Console.WriteLine(word);
            // }

            Random randomNumberGenerator = new Random();
            // Reference to get the number of elements in a list:
            // https://linuxhint.com/c-sharp-list-length/        
            int index = randomNumberGenerator.Next(0, scriptureWordList.Count);
            Console.WriteLine(scriptureWordList[index]);
        }
    }
}