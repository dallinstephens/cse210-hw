public class ListingActivity : Activity
{
    private List<string> _prompts;

    // This is used to restore the orignal prompts if all prompts have been used.
    private List<string> _promptsOriginal;

    private List<string> _responses;
    private int _numberOfResponses;

    public ListingActivity()
        : base
        (
            // name
            "Listening",
            // description
            "This activity will help you reflect on the good things in " +
            "life by having you list as many things as you can in a " +
            "certain area."
        )
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Reference on how to make a copy of a list without reference:
        // https://stackoverflow.com/questions/13447248/how-to-assign-listt-without-it-being-a-reference-to-the-original-listt
        // This is used to restore the orignal prompts if all prompts have been used.
        _promptsOriginal = new List<string>(_prompts);
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

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");

        // Reference how to remove a string from a list at a particular index:
        // https://stackoverflow.com/questions/23954008/how-to-remove-an-item-from-a-liststring
        // Removing the prompt at the picked index ensures it will not be repeated.           
        _prompts.RemoveAt(index);

        Console.Write("You may begin in: ");
        CountDownTimer(4);
        Console.WriteLine();
    }

    private void WritingResponses()
    {
        _responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }

        _numberOfResponses = _responses.Count();

        Console.WriteLine($"You listed {_numberOfResponses} items!");
    }

    public void RunListingActivity()
    {
        DisplayWelcome();
        DisplayDescription();
        DisplayDurationQuestion();
        GetReady();
        DisplayRandomPrompt();
        WritingResponses();
        WellDone();
    }
}