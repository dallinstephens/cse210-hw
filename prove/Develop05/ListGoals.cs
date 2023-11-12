public class ListGoals : Goals
{
    private string _emptyOrChecked;

    public void RunListGoals()
    {
        Console.WriteLine("The goals are:");

        int i = 1;

        foreach (Goal goal in _goals)
        {
            if (goal.GetIsComplete())
            {
                _emptyOrChecked = "X";
            }
            else
            {
                _emptyOrChecked = " ";
            }
            Console.WriteLine($"{i}. [{_emptyOrChecked}] {goal.Summary()}");
            i++;
        }
    }
}