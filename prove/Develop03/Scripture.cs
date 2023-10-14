public class Scripture
{
    private string _reference;
    private string _text;

    public Scripture(string reference, string text)
    {
        // Reference to see if a string contains a character:
        // https://www.programiz.com/csharp-programming/library/string/contains#:~:text=Example%201%3A%20C%23%20String%20Contains()&text=Here%2C-,str.,str%20does%20not%20contain%20%22chocolate%22
        bool check = reference.Contains("-");
        if (check == true)
        {
            string[] substrings = reference.Split(':');
            string bookAndChapter = substrings[0];
            string verseRange = substrings[1];
            Reference scriptureReference = new Reference(bookAndChapter, verseRange);
            _reference = scriptureReference.ReturnReference();
        }
        else
        {
            string singleVerse = reference;
            Reference scriptureReference = new Reference(singleVerse);
            _reference = scriptureReference.ReturnReference();
        }

        // Reference how to split string:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
        // Reference how to split string into a list:
        // https://www.techiedelight.com/split-a-delimited-string-into-a-list-in-csharp/
        List<string> scriptureWordList = new List<string>(text.Split(' '));

        _text = text;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(_text);
    }
}