public class InvalidResponse
{
    public void DisplayInvalidResponse()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Invalid response. Please enter a valid number.");
        Console.ResetColor();
    }
}