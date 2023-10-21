using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();
    private Word _myWord = new Word();
    private List<int> _listOfIndexesOfWordsHidden = new List<int>();
    private int _numberOfWordsToDisappearEachTime;
    private bool _includeFirstLetter;

    public Scripture()
    {

    }

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
            _reference = new Reference(bookAndChapter, verseRange);
        }
        else
        {
            string singleVerse = reference;
            _reference = new Reference(singleVerse);
        }

        // Reference how to iterate through each word in a string:
        // https://stackoverflow.com/questions/1442955/how-to-word-by-word-iterate-in-string-in-c
        foreach (string word in text.Split(' '))
        {
            Word _myWord = new Word();
            _myWord.SetWord(word);
            // _myWord.SetHiddenWordStatus(false);
            _wordList.Add(_myWord);
        }
    }

    public void HideWordsRandomly()
    {
        // Reference on how to generate random numbers without repeating:
        // https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c/30014963#30014963
        // Example from reference:
        // List<int> listNumbers = new List<int>();
        // do
        // {
        //     int number = rand.Next(1,49);
        //     if(!listNumbers.Contains(number)) 
        //     {
        //         listNumbers.Add(number);
        //     }
        // } while (listNumbers.Count < 6)

        Random randomNumberGenerator = new Random();

        // This variable is initially set to 0.
        int numberOfWordsToDisappearEachTime = 0;

        do
        {
            // Reference to get the number of elements in a list:
            // https://linuxhint.com/c-sharp-list-length/ 
            int index = randomNumberGenerator.Next(0, _wordList.Count);

            if (!_listOfIndexesOfWordsHidden.Contains(index))
            {
                _listOfIndexesOfWordsHidden.Add(index);

                if (_includeFirstLetter == false)
                {
                    string hiddenWord = _myWord.HideWord(_wordList[index].GetWord());

                    _wordList[index].SetWord(hiddenWord);
                    // _wordList[index].SetHiddenWordStatus(true);
                }
                else if (_includeFirstLetter == true)
                {
                    string hiddenWord = _myWord.HideWordIncludeFirstLetter(_wordList[index].GetWord());

                    _wordList[index].SetWord(hiddenWord);
                    // _wordList[index].SetHiddenWordStatus(true);
                }

                // The do while loop will end when numberOfWordsToDisappearEachTime = 2 for example.
                numberOfWordsToDisappearEachTime++;
            }
            else if (_listOfIndexesOfWordsHidden.Count == _wordList.Count)
            {
                numberOfWordsToDisappearEachTime = _numberOfWordsToDisappearEachTime;
            }

        } while (numberOfWordsToDisappearEachTime != _numberOfWordsToDisappearEachTime);
    }

    public bool AllWordsAreHiddenStatus()
    {
        if (_listOfIndexesOfWordsHidden.Count == _wordList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayScripture()
    {
        _reference.DisplayReference();

        foreach (Word word in _wordList)
        {
            Console.Write($"{word.GetWord()} ");
        }

        // Line breaks
        Console.WriteLine();
        Console.WriteLine();
    }

    public void SetNumberOfWordsToDisappearEachTime(int numberOfWordsToDisappearEachTime)
    {
        _numberOfWordsToDisappearEachTime = numberOfWordsToDisappearEachTime;
    }

    public void IncludeFirstLetter(bool includeFirstLetter)
    {
        _includeFirstLetter = includeFirstLetter;
    }

}