public class Word
{
    private string _word;

    public string RandomWord(string scripture)
    {
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
        return scriptureWordList[index];
    }
}