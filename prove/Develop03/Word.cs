public class Word
{
    private string _word;

    public string RandomWord()
    {
        // Reference for random number:
        // https://www.w3schools.blog/c-random-number-between-1-and-100
        Random randomNumberGenerator = new Random();
        // Generates a random number between 0-5 (includes 0, excludes 5)
        // int index = randomNumberGenerator.Next(0, 5);
        return _word;
    }
}