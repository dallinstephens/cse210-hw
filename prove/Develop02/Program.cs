// References for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit02/design.html
// https://byui-cse.github.io/cse210-course-2023/unit02/develop.html

// THE FOLLOWING ITEMS SHOW CREATIVITY AND EXCEED REQUIREMENTS
// 1. The terminal displays different colors than just black to show contrast.
// 2. The following options were added when a user chooses "1. Write":
//      a. Choose a random prompt.
//      b. Choose a specific prompt.
//      c. Add a new prompt.
//      d. Go back to main menu.
// 3. The date of each entry is displayed in the following format: example Saturday, 10/07/2023 09:26:29 AM.
// 4. Program addresses if the user enters an invalid response: 
//      a. Exception: file not found.
//      b. Exception: a string was entered by the user instead of an integer.
//      c. An incorrrect integer was entered by the user.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int option = -1;

        // Journal myJournal is initiated here so it can be used in 
        // different if or else if statements.
        Journal myJournal = new Journal();
        Prompt prompt1 = new Prompt();
        InvalidResponse invalid = new InvalidResponse();

        while (option != 5)
        {
            // Reference on how to handle exception if the user enters a non-numeric responce:
            // https://stackoverflow.com/questions/34486216/c-sharp-how-can-i-create-an-exception-for-non-numeric-on-this-code
            try
            {
                Console.WriteLine("Please select one of the following choices:");
                // Reference on how to change console color:
                // https://www.dotnetperls.com/console-color
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                // Reference on how to reset console color:
                // https://www.dotnetperls.com/console-color
                Console.ResetColor();
                Console.Write("What would you like to do? ");

                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    int selection = -1;

                    while (selection != 1 && selection != 2 && selection != 3 && selection != 4)
                    {
                        Entry entry1 = new Entry();
                        entry1._date = entry1.ComputeDate();
                        Console.WriteLine("Please select one:");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("1. Choose a random prompt");
                        Console.WriteLine("2. Choose a specific prompt");
                        Console.WriteLine("3. Add a new prompt");
                        Console.WriteLine("4. Go back to main menu");
                        Console.ResetColor();
                        Console.Write("What would you like to do? ");
                        selection = int.Parse(Console.ReadLine());

                        if (selection == 1)
                        {
                            entry1._prompt = prompt1.RandomPrompt();

                            entry1.DisplayPrompt();
                            Console.Write("> ");
                            entry1._answer = Console.ReadLine();

                            myJournal._entries.Add(entry1);
                        }
                        else if (selection == 2)
                        {
                            int promptChoice;
                            prompt1.PromptList();
                            Console.Write("What prompt would you like to use? ");
                            promptChoice = int.Parse(Console.ReadLine());
                            if (promptChoice > 0 && promptChoice < prompt1._prompts.Count + 1)
                            {
                                entry1._prompt = prompt1.ChosenPrompt(promptChoice);
                                entry1.DisplayPrompt();
                                Console.Write("> ");
                                entry1._answer = Console.ReadLine();

                                myJournal._entries.Add(entry1);
                            }
                            else
                            {
                                invalid.DisplayInvalidResponse();
                            }
                        }
                        else if (selection == 3)
                        {
                            Console.WriteLine("Enter a prompt you would like to add:");
                            Console.Write("> ");
                            prompt1._prompts.Add(Console.ReadLine());
                            Console.WriteLine("Would you like to write an entry for this prompt (y/n)?");
                            Console.Write("> ");
                            string writeNewPrompt = Console.ReadLine();
                            if (writeNewPrompt == "y" || writeNewPrompt == "Y")
                            {
                                // prompt1.ChosenPrompt(prompt1._prompts.Count) will pull the last item in the list prompt1._prompts.
                                entry1._prompt = prompt1.ChosenPrompt(prompt1._prompts.Count);
                                entry1.DisplayPrompt();
                                Console.Write("> ");
                                entry1._answer = Console.ReadLine();

                                myJournal._entries.Add(entry1);
                            }
                        }
                        else if (selection == 4)
                        {
                            // Do nothing. Go back to menu.
                        }
                        else
                        {
                            invalid.DisplayInvalidResponse();
                        }
                    }
                }
                else if (option == 2)
                {
                    myJournal.DisplayEntries();
                }
                else if (option == 3)
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    myJournal.LoadFile(filename);
                }
                else if (option == 4)
                {
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    myJournal._filename = filename;
                    myJournal.SaveFile();
                }
                else if (option == 5)
                {
                    // Do nothing when the user enters 5 to quit.
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
            // Reference for file not found exception:
            // https://rollbar.com/blog/csharp-filenotfoundexception/#:~:text=One%20of%20the%20most%20commonly,mismatch%20in%20the%20file%20name.
            catch (FileNotFoundException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("File not found. Please try again.");
                Console.ResetColor();
            }
        }
    }

}