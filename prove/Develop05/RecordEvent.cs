public class RecordEvent : Goals
{

    public void RunRecordEvent()
    {
        Console.WriteLine("The goals are:");

        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }

        Console.Write("What goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine());

        int index = goalAccomplished - 1;

        _goals[index].IsComplete();

        int pointsEarned = _goals[index].GetPoints();

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");

        // Same thing as totalPoints = totalPoints + pointsEarned
        // Reference: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0054-ide0074
        _totalPoints += pointsEarned;

        Console.WriteLine($"You now have {_totalPoints} points.");
    }
}