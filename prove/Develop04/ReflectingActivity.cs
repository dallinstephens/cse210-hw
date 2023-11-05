public class ReflectingActivity : Activity
{

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
            },
            // questions
            new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            }
        )
    {

    }

    private void DisplayRandomPrompt()
    {
        int index = ReturnRandomIndexFromPromptsListWithoutRepeating();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayRandomQuestion()
    {
        int index = ReturnRandomIndexFromQuestionsListWithoutRepeating();

        Console.Write($"> {_questions[index]} ");

        Spinner(4);
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