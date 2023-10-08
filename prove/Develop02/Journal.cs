// Reference on how to write and read text files in C#
// https://byui-cse.github.io/cse210-course-2023/unit02/develop.html

// Used so C# will find StreamWriter class
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename;

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // The Write() and WriteLine() method are used to add text to the file
            // outputFile.WriteLine("This will be the first line in the file.");
            // outputFile.WriteLine("This will be the second line in the file.");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.DateAndPrompt());
                outputFile.WriteLine(entry._answer);
                outputFile.WriteLine();
            }
        }

    }

    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        Console.ForegroundColor = ConsoleColor.DarkRed;

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.ResetColor();
    }

}