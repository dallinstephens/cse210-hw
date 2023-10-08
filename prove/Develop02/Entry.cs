using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;

    public void DisplayPrompt()
    {
        // Reference on how to change console color:
        // https://www.dotnetperls.com/console-color
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(_prompt);
        // Reference on how to reset console color:
        // https://www.dotnetperls.com/console-color
        Console.ResetColor();
    }

    public string ComputeDate()
    {
        // Reference: https://tecadmin.net/how-to-get-current-date-time-in-c-sharp/
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToString("dddd, MM/dd/yyyy hh:mm:ss tt");
        return _date;
    }

    public string DateAndPrompt()
    {
        string dateAndPrompt = $"Date: {_date} - Prompt: {_prompt}";
        return dateAndPrompt;
    }

    public void DisplayEntry()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(DateAndPrompt());
        Console.WriteLine(_answer);
        Console.WriteLine();
        Console.ResetColor();
    }

}