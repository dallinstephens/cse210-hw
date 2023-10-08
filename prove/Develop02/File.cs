// Reference on how to write and read text files in C#
// https://byui-cse.github.io/cse210-course-2023/unit02/develop.html

// Used so C# will find StreamWriter class
using System.IO;

public class File
{
    public string _filename;

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // The Write() and WriteLine() method are used to add text to the file
            outputFile.WriteLine("This will be the first line in the file.");
        }
    }

    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstWord = parts[0];
            string secondWord = parts[1];
        }
    }
}