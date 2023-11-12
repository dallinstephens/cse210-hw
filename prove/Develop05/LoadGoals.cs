public class LoadGoals : Goals
{
    private string _filename;

    private void QuestionFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
    }

    public void LoadFile()
    {
        QuestionFilename();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            // This else is used for the first line of the file which is the total points.
            // Reference on how to see if a string is an integer:
            // https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number
            int n;
            bool isInteger = int.TryParse(line, out n);

            if (isInteger)
            {
                _totalPoints = int.Parse(line);
            }
            else
            {
                // References on how to split string by first occurrence of the delimiter:
                // https://stackoverflow.com/questions/21519548/split-string-based-on-the-first-occurrence-of-the-character
                // https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-6.0#system-string-split(system-char()-system-int32)
                // This is used in case the user enters for example 6:00am which has a ":".
                string[] sections = line.Split(":", 2);

                // sections[0] = class
                // sections[1] = format

                // Splits format by each comma into individual strings
                string[] parts = sections[1].Split(",");

                if (sections[0] == "SimpleGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (sections[0] == "EternalGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (sections[0] == "ChecklistGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int bonus = int.Parse(parts[3]);
                    int times = int.Parse(parts[4]);
                    int timesDone = int.Parse(parts[5]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, times, timesDone);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}