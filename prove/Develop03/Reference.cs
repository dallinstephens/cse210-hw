public class Reference
{
    private string _book;
    private int _chapter;
    private string _verseOrVerses; // string instead of integer because of the "-": : Example Proverbs 3:5-6

    public Reference(string singleVerse)
    {
        // Link how to split a string:
        // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0
        // string singleVerse = "3 Nephi 12:6";
        // string[] substring = singleVerse.Split(':');
        // Console.WriteLine(substring[0]); result: 3 Nephi 12
        // Console.WriteLine(substring[1]); result: 6

        string[] substring = singleVerse.Split(':');
        string bookAndChapter = substring[0];

        // Reference how to find the last occurrence/position of a character or string:
        // https://www.programiz.com/csharp-programming/library/string/lastindexof
        // Example: 3 Nephi 12:6
        // bookAndChapter = "3 Nephi 12"
        // We want to get _book = "3 Nephi" using LastIndexOf and Substring.
        // int index = bookAndChapter.LastIndexOf(' '); returns last index of ' ' which is 7.
        int index = bookAndChapter.LastIndexOf(' ');

        // Reference how to get substring from a string:
        // https://www.programiz.com/csharp-programming/library/string/substring
        // Substring(int startIndex, int length)
        // returns "3 Nephi" from "3 Nephi 12"
        // index in this case is 7 which is the length of "3 Nephi"
        _book = bookAndChapter.Substring(0, index);

        // returns 12 from "3 Nephi 12"
        // startIndex = index +  1 = 7 + 1 = 8
        // index + 1 = 7 + 1 = 8 is also the length of the "3 Nephi " (Note: The length 8 includes the space after 3 Nephi)
        // length = bookAndChapter.Length - (index + 1) = 10 - 8 = 2
        _chapter = int.Parse(bookAndChapter.Substring(index + 1, bookAndChapter.Length - (index + 1)));

        _verseOrVerses = substring[1];
    }

    public Reference(string bookAndChapter, string verseRange)
    {
        // Reference how to find the last occurrence/position of a character or string:
        // https://www.programiz.com/csharp-programming/library/string/lastindexof
        // Example: 3 Nephi 12:5-8
        // bookAndChapter = "3 Nephi 12"; verseRange = 5-8
        // We want to get _book = "3 Nephi" using LastIndexOf and Substring.
        // int index = bookAndChapter.LastIndexOf(' '); returns last index of ' ' which is 7.
        int index = bookAndChapter.LastIndexOf(' ');

        // Reference how to get substring from a string:
        // https://www.programiz.com/csharp-programming/library/string/substring
        // Substring(int startIndex, int length)
        // returns "3 Nephi" from "3 Nephi 12"
        // index in this case is 7 which is the length of "3 Nephi"
        _book = bookAndChapter.Substring(0, index);

        // returns 12 from "3 Nephi 12"
        // startIndex = index +  1 = 7 + 1 = 8
        // index + 1 = 7 + 1 = 8 is also the length of the "3 Nephi " (Note: The length 8 includes the space after 3 Nephi)
        // length = bookAndChapter.Length - (index + 1) = 10 - 8 = 2
        _chapter = int.Parse(bookAndChapter.Substring(index + 1, bookAndChapter.Length - (index + 1)));

        _verseOrVerses = verseRange;
    }

    public string ReturnReference()
    {
        return $"{_book} {_chapter}:{_verseOrVerses}";
    }

}