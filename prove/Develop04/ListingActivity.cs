public class ListingActivity : Activity
{
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
            "certain area.",
            // prompts
            new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            }
        )
    {

    }

    private void DisplayRandomPrompt()
    {
        int index = ReturnRandomIndexFromPromptsListWithoutRepeating();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");

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