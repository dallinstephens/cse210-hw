using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;

    // Duration is in seconds.
    private int _duration;

    protected List<string> _prompts;

    // This is used to restore the orignal questions if all questions have been used.
    private List<string> _promptsOriginal;

    private int _indexForPromptsList;

    protected List<string> _questions;

    // This is used to restore the orignal questions if all questions have been used.
    private List<string> _questionsOriginal;

    private int _indexForQuestionsList;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected Activity(string name, string description, List<string> prompts)
    {
        _name = name;
        _description = description;
        _prompts = new List<string>(prompts);

        // Reference on how to make a copy of a list without reference:
        // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt
        // This is used to restore the orignal prompts if all prompts have been used.
        _promptsOriginal = new List<string>(prompts);

        _indexForPromptsList = -1;
    }

    protected Activity(string name, string description, List<string> prompts, List<string> questions)
    {
        _name = name;
        _description = description;
        _prompts = new List<string>(prompts);
        _promptsOriginal = new List<string>(prompts);
        _indexForPromptsList = -1;
        _questions = new List<string>(questions);
        _questionsOriginal = new List<string>(questions);
        _indexForQuestionsList = -1;
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

    protected int ReturnRandomIndexFromPromptsListWithoutRepeating()
    {   // The do while loop only repeats when _prompts.Count == 1.
        do
        {
            // This is used to restore the orignal questions if all questions have been used.
            if (_prompts.Count == 0)
            {
                // Reference on how to make a copy of a list without reference:
                // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt            
                _prompts = new List<string>(_promptsOriginal);
                _indexForPromptsList = -1;
            }

            // The statement _prompts.RemoveAt(_index) will produce an error the first time that
            // DisplayRandomQuestion() is ran because a random index has not been picked yet and so
            // _index is -1 as defined in the constructor.
            try
            {
                // Reference how to remove a string from a list at a particular index:
                // https://stackoverflow.com/questions/23954008/how-to-remove-an-item-from-a-liststring
                // Removing the prompt at the picked index ensures it will not be repeated.           
                _prompts.RemoveAt(_indexForPromptsList);
            }
            catch
            {
                // When an error occurs do nothing. 
            }

            // Reference to generate a random number:
            // https://www.w3schools.blog/c-random-number
            Random random = new Random();
            _indexForPromptsList = random.Next(0, _prompts.Count); // 0 inclusive, the number that is _prompts.Count is exclusive

        } while (_prompts.Count == 0);

        return _indexForPromptsList;
    }

    protected int ReturnRandomIndexFromQuestionsListWithoutRepeating()
    {   // The do while loop only repeats when _questions.Count == 1.
        do
        {
            // This is used to restore the orignal questions if all questions have been used.
            if (_questions.Count == 0)
            {
                // Reference on how to make a copy of a list without reference:
                // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt            
                _questions = new List<string>(_questionsOriginal);
                _indexForQuestionsList = -1;
            }

            // The statement _questions.RemoveAt(_index) will produce an error the first time that
            // DisplayRandomQuestion() is ran because a random index has not been picked yet and so
            // _index is -1 as defined in the constructor.
            try
            {
                // Reference how to remove a string from a list at a particular index:
                // https://stackoverflow.com/questions/23954008/how-to-remove-an-item-from-a-liststring
                // Removing the prompt at the picked index ensures it will not be repeated.           
                _questions.RemoveAt(_indexForQuestionsList);
            }
            catch
            {
                // When an error occurs do nothing. 
            }

            // Reference to generate a random number:
            // https://www.w3schools.blog/c-random-number
            Random random = new Random();
            _indexForQuestionsList = random.Next(0, _questions.Count); // 0 inclusive, the number that is _questions.Count is exclusive

        } while (_questions.Count == 0);

        return _indexForQuestionsList;
    }

}