public class SaveGoals : Goals
{
    private string _filename;

    private void QuestionFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
    }

    public void SaveFile()
    {
        QuestionFilename();

        // Reference on how to write text file:
        // https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                // Reference on how to get the name of the class for an object - Object.GetType(): 
                // https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0
                outputFile.WriteLine($"{goal.GetType()}:{goal.Format()}");
            }
        }
    }
}