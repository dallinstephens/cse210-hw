using System.Collections.Concurrent;
using System.Threading.Tasks.Dataflow;

public class Word
{
    private string _word;
    // private bool _hidden;

    public Word()
    {
        _word = "";
    }

    public string HideWord(string _word)
    {
        // Reference how to find length of a string:
        // https://www.w3schools.com/cs/cs_strings.php
        int wordLength = _word.Length;

        // Reference how to repeat a character x number of times:
        // https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        // Example: string myString = new String('-', 5); result: -----
        // Alternative shortcut: string MyString = new('-', 5); result: -----
        _word = new('_', wordLength);

        return _word;
    }

    public string HideWordIncludeFirstLetter(string _word)
    {
        // Reference how to find length of a string:
        // https://www.w3schools.com/cs/cs_strings.php
        int wordLength = _word.Length;

        // Reference how to repeat a character x number of times:
        // https://stackoverflow.com/questions/3754582/is-there-an-easy-way-to-return-a-string-repeated-x-number-of-times
        // Example: string myString = new String('-', 5); result: -----
        // Alternative shortcut: string MyString = new('-', 5); result: -----
        string hiddenWordMinusFirstCharater = new('_', wordLength - 1);

        // Reference how to get the first character of a string:
        // https://www.tutorialspoint.com/How-to-find-the-first-character-of-a-string-in-Chash
        string firstCharacter = _word.Substring(0, 1);

        _word = firstCharacter + hiddenWordMinusFirstCharater;

        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    // public void SetHiddenWordStatus(bool trueOrFalse)
    // {
    //     _hidden = trueOrFalse;
    // }

    // public bool GetHiddenWordStatus()
    // {
    //     return _hidden;
    // }

}