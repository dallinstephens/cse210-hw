public class InvalidResponse
{
    public void DisplayInvalidResponse()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Invalid response. Please enter a valid response.");
        Console.ResetColor();
    }
}