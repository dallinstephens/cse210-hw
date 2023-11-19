public class RecordEvent : Goals
{
    private List<int> _goalNumbersComplete = new List<int>();

    // References on how to use strikethrough and color:
    // https://tforgione.fr/posts/ansi-escape-codes/
    // https://stackoverflow.com/questions/5237666/adding-text-decorations-to-console-output
    private string _red = "\x1B[31m";
    private string _strikethrough = "\x1B[9m";
    private string _reset = "\x1B[0m";

    public void RunRecordEvent()
    {
        int goalAccomplished = -1;

        do
        {
            Console.WriteLine("The goals are:");

            int i = 1;

            foreach (Goal goal in _goals)
            {
                if (goal.GetIsComplete() == false)
                {
                    Console.WriteLine($"{i}. {goal.GetName()}");
                }
                // If a goal is complete, a strikethrough will appear.
                else if (goal.GetIsComplete() == true)
                {
                    Console.WriteLine($"{_red}{_strikethrough}{i}. {goal.GetName()}{_reset}");
                    _goalNumbersComplete.Add(i);
                }
                i++;
            }

            Console.Write("What goal did you accomplish? ");
            goalAccomplished = int.Parse(Console.ReadLine());

            // References on how to use list contains:
            // https://stackoverflow.com/questions/18767302/check-if-list-contains-element-that-contains-a-string-and-get-that-element
            // https://stackoverflow.com/questions/17381332/how-to-tell-if-a-list-does-not-contain-an-element
            if (_goalNumbersComplete.Contains(goalAccomplished))
            {
                Console.Clear();
                Console.WriteLine(_red);
                Console.WriteLine("That goal has already been completed!");
                Console.WriteLine("Please pick a different goal.");
                Console.WriteLine(_reset);
            }
        } while (_goalNumbersComplete.Contains(goalAccomplished));

        int index = goalAccomplished - 1;

        _goals[index].IsComplete();

        int pointsEarned = _goals[index].GetPoints();

        Console.Clear();

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");

        // Same thing as totalPoints = totalPoints + pointsEarned
        // Reference: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0054-ide0074
        _totalPoints += pointsEarned;

        Console.WriteLine($"You now have {_totalPoints} points.");

        if (_goals[index].GetIsComplete() == true)
        {
            PersonShoutingHurrayAnimation();
        }
    }

    private void PersonShoutingHurrayAnimation()
    {
        Thread.Sleep(3000);

        Console.Clear();

        Console.Write(_red);

        Console.WriteLine($"Congratulations!!! You completed your goal!");

        Thread.Sleep(2000);

        Console.Clear();

        Console.WriteLine("Let's celebrate!!!");

        Thread.Sleep(3000);

        int seconds = 11;
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();

            if (i % 2 == 0)
            {
                Console.WriteLine("Hurray!!!");
                Console.WriteLine("");
                Console.WriteLine($"\\     /");
                Console.WriteLine($" \\ O /");
                Console.WriteLine($"   |");
                Console.WriteLine($"   |");
                Console.WriteLine($"  / \\");
                Console.WriteLine($" /   \\");
            }
            else if (i != 1) // i != 1 makes it so that "Hurray" is the last one not "Hip Hip".
            {
                Console.WriteLine("Hip Hip...");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"   O  ");
                Console.WriteLine($"---|---");
                Console.WriteLine($"   |");
                Console.WriteLine($"  | |");
                Console.WriteLine($"  | |");
            }
            Thread.Sleep(1000);
        }

        Console.WriteLine(_reset);
        Console.Clear();
    }
}