public class Reference
{
    private string _book;
    private string _chapter; // string instead of integer because of the "-": Example Proverbs 3:5-6
    private string _verseOrVerses; // string instead of integer because of the "-": : Example Proverbs 3:5-6

    public Reference(string singleVerse)
    {
        // Link how to split a string:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
        // string singleVerse = "John 3:16";
        // string[] substring = singleVerse.Split(' ');
        // Console.WriteLine(substring[0]); result: John
        // Console.WriteLine(substring[1]); result: 3:16

        string[] substrings1 = singleVerse.Split(' ');
        _book = substrings1[0];

        string chapterColonVerse = substrings1[1];
        string[] substrings2 = chapterColonVerse.Split(':');
        _chapter = substrings2[0];

        _verseOrVerses = substrings2[1];
        // _book = book;
        // _chapter = chapter;
        // _verse = verse;
    }

    public Reference(string bookAndChapter, string verseRange)
    {
        string[] substrings = bookAndChapter.Split(' ');
        _book = substrings[0];

        _chapter = substrings[1];

        _verseOrVerses = verseRange;
    }

    public string ReturnReference()
    {
        return $"{_book} {_chapter}:{_verseOrVerses}";
    }

}