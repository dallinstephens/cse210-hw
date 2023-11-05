public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    // This is used to restore the orignal prompts if all prompts have been used.
    private List<string> _promptsOriginal;

    private List<string> _questions;

    // This is used to restore the orignal questions if all questions have been used.
    private List<string> _questionsOriginal;
    private int _index;

    public ReflectingActivity()
        : base
        (
            // name
            "Reflecting",
            // description
            "This activity will help you reflect on times in your life " +
            "when you have shown strength and resilience. This will help " +
            "you recognize the power you have and how you can use it in " +
            "other aspects of your life.",
            // prompts
            new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            }
        )
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Reference on how to make a copy of a list without reference:
        // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt
        // This is used to restore the orignal prompts if all prompts have been used.
        _promptsOriginal = new List<string>(_prompts);

        _questions = new List<string>
        {
            "1Why was this experience meaningful to you?",
            "2Have you ever done anything like this before?",
            "3How did you get started?",
            "4How did you feel when it was complete?",
            "5What made this time different than other times when you were not as successful?",
            "6What is your favorite thing about this experience?",
            "7What could you learn from this experience that applies to other situations?",
            "8What did you learn about yourself through this experience?",
            "9How can you keep this experience in mind in the future?"
        };

        // Reference on how to make a copy of a list without reference:
        // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt
        // This is used to restore the orignal questions if all questions have been used.
        _questionsOriginal = new List<string>(_questions);

        _index = -1;
    }

    private void DisplayRandomPrompt()
    {
        // This is used to restore the orignal prompts if all prompts have been used.
        if (_prompts.Count == 0)
        {
            // Reference on how to make a copy of a list without reference:
            // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt
            _prompts = new List<string>(_promptsOriginal);
        }

        // Reference to generate a random number:
        // https://www.w3schools.blog/c-random-number
        Random random = new Random();
        int index = random.Next(0, _prompts.Count); // 0 inclusive, the number that is _prompts.Count is exclusive            
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine();

        // Reference how to remove a string from a list at a particular index:
        // https://stackoverflow.com/questions/23954008/how-to-remove-an-item-from-a-liststring
        // Removing the prompt at the picked index ensures it will not be repeated.           
        _prompts.RemoveAt(index);

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayRandomQuestion()
    {   // The do while loop only repeats when _questions.Count == 1.
        do
        {
            // This is used to restore the orignal questions if all questions have been used.
            if (_questions.Count == 0)
            {
                // Reference on how to make a copy of a list without reference:
                // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt            
                _questions = new List<string>(_questionsOriginal);
            }

            // The statement _questions.RemoveAt(_index) will produce an error the first time that
            // DisplayRandomQuestion() is ran because a random index has not been picked yet and so
            // _index is -1 as defined in the constructor.
            try
            {
                // Reference how to remove a string from a list at a particular index:
                // https://stackoverflow.com/questions/23954008/how-to-remove-an-item-from-a-liststring
                // Removing the prompt at the picked index ensures it will not be repeated.           
                _questions.RemoveAt(_index);
            }
            catch
            {
                // When an error occurs do nothing. 
            }

            // Reference to generate a random number:
            // https://www.w3schools.blog/c-random-number
            Random random = new Random();
            _index = random.Next(0, _questions.Count); // 0 inclusive, the number that is _questions.Count is exclusive

        } while (_questions.Count == 0);

        Console.Write($"> {_questions[_index]} ");

        Spinner(2);
    }

    private void PonderRandomQuestions()
    {
        Console.WriteLine("Now ponder on each of theh following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDownTimer(4);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayRandomQuestion();
        }
    }

    public void RunReflectingActivity()
    {
        DisplayWelcome();
        DisplayDescription();
        DisplayDurationQuestion();
        GetReady();
        DisplayRandomPrompt();
        PonderRandomQuestions();
        WellDone();
    }

}