public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base
        (
            // name
            "Breathing",
            // description
            "This activity will help you relax by walking you through " +
            "breathing in and out slowly. Clear your mind and focus on " +
            "your breathing."
        )
    {

    }

    private void BreatheInBreatheOut()
    {
        Console.WriteLine();

        // References on how to display animations:
        // https://byui-cse.github.io/cse210-course-2023/unit04/develop.html
        // https://video.byui.edu/media/t/1_soxhacuf

        DateTime startTime = DateTime.Now;

        // Reference to parse string to double:
        // https://stackoverflow.com/questions/11399439/converting-string-to-double-in-c-sharp
        // Note: .AddSeconds requires parameter to be double.
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");

            CountDownTimer(4);

            Console.WriteLine();
            Console.Write("Now breathe out...");

            CountDownTimer(6);

            Console.WriteLine();
        }
    }

    public void RunBreathingActivity()
    {
        DisplayWelcome();
        DisplayDescription();
        DisplayDurationQuestion();
        GetReady();
        BreatheInBreatheOut();
        WellDone();
    }
}