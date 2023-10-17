public class Word
{
    private string _hiddenWord;
    private int _hiddenWordIndex;

    // Reference how to pass list as a parameter:
    // https://stackoverflow.com/questions/13993371/how-to-pass-list-as-parameter-in-function

    public Word()
    {
        _hiddenWord = "";
    }
    public Word(List<string> scriptureWordList)
    {
        Random randomNumberGenerator = new Random();
        // Reference to get the number of elements in a list:
        // https://linuxhint.com/c-sharp-list-length/ 
        _hiddenWordIndex = randomNumberGenerator.Next(0, scriptureWordList.Count);

        // Reference how to find length of a string:
        // https://www.w3schools.com/cs/cs_strings.php
        int wordLength = scriptureWordList[_hiddenWordIndex].Length;

        // Reference how to repeat a character x number of times:
        // https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        // Example: string myString = new String('-', 5); result: -----
        // Alternative shortcut: string MyString = new('-', 5); result: -----
        _hiddenWord = new('_', wordLength);
    }

    public Word(List<string> scriptureWordList, string firstLetter)
    {
        Random randomNumberGenerator = new Random();
        // Reference to get the number of elements in a list:
        // https://linuxhint.com/c-sharp-list-length/ 
        _hiddenWordIndex = randomNumberGenerator.Next(0, scriptureWordList.Count);

        // Reference how to find length of a string:
        // https://www.w3schools.com/cs/cs_strings.php
        int wordLength = scriptureWordList[_hiddenWordIndex].Length;

        // Reference how to repeat a character x number of times:
        // https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        // Example: string myString = new String('-', 5); result: -----
        // Alternative shortcut: string MyString = new('-', 5); result: -----
        string hiddenWordMinusFirstCharater = new('_', wordLength - 1);

        // Reference how to get the first character of a string:
        // https://www.tutorialspoint.com/How-to-find-the-first-character-of-a-string-in-Chash
        string firstCharacter = scriptureWordList[_hiddenWordIndex].Substring(0, 1);

        _hiddenWord = firstCharacter + hiddenWordMinusFirstCharater;
    }

    public string ReturnHiddenWord()
    {
        return _hiddenWord;
    }

    public int ReturnHiddenWordIndex()
    {
        return _hiddenWordIndex;
    }

}