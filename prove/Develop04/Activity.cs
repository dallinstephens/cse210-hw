using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;

    // Duration is in seconds.
    private int _duration;
    private List<string> _prompts;

    protected Activity(string name, string description, List<string> prompts)
    {
        _name = name;
        _description = description;
        _prompts = prompts;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
    }

    protected void DisplayDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    protected void DisplayDurationQuestion()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void GetReady()
    {
        Console.Clear();
        Console.Write("Get ready");
        DotsAppearingAnimation();
        Console.WriteLine();
        Spinner(4);
    }

    protected void WellDone()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(4);
    }

    // References on how to build a count down timer:
    // https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
    // https://video.byui.edu/media/t/1_soxhacuf
    protected void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // backspace, insert space, then backspace again
        }
    }

    // References on how to display dots appearing animation:
    // https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
    // https://video.byui.edu/media/t/1_soxhacuf   

    private void DotsAppearingAnimation()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }

    // References on how to create a spinner animation:
    // https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
    // https://video.byui.edu/media/t/1_soxhacuf
    protected void Spinner(int numberOfSeconds)
    {
        // Clockwise: -\|/-\|/
        List<string> spinnerCharacters = new List<string>();

        // Reference to dublicate line easily in Visual Studio Code:
        // https://stackoverflow.com/questions/38727047/duplicate-line-in-visual-studio-code
        // Shift + Alt + Down
        spinnerCharacters.Add("-");
        spinnerCharacters.Add("\\");
        spinnerCharacters.Add("|");
        spinnerCharacters.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(numberOfSeconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerCharacters[i]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // backspace, insert space, then backspace again

            i++;

            if (i == spinnerCharacters.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

}