using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity();
        ReflectingActivity activity2 = new ReflectingActivity();
        ListingActivity activity3 = new ListingActivity();

        int option = -1;

        while (option != 4)
        {
            Console.Clear();

            // Reference on how to generate an indented string for a single line of text:
            // https://stackoverflow.com/questions/15529672/generating-an-indented-string-for-a-single-line-of-text
            // string indent = new('-', 2);
            // Console.WriteLine(indent); output: --
            string indent = new(' ', 2); // Two spaces are stored in the indent string.

            Console.WriteLine("Menu Options");
            Console.WriteLine($"{indent}1. Start breathing activity");
            Console.WriteLine($"{indent}2. Start reflecting activity");
            Console.WriteLine($"{indent}3. Start listing activity");
            Console.WriteLine($"{indent}4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                activity1.RunBreathingActivity();
            }
            else if (option == 2)
            {
                activity2.RunReflectingActivity();
            }
            else if (option == 3)
            {
                activity3.RunListingActivity();
            }

        }

    }
}