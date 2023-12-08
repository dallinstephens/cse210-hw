public class Activity
{
    private string _date;
    protected int _length; // length of the activity in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        // Reference on how to get 2 decimal places $"{48.485:F2}" - output 48.49:
        // https://stackoverflow.com/questions/2357855/round-double-in-two-decimal-places-in-c
        return $"{_date} {GetType()} ({_length} min) - Distance: {GetDistance():F2} miles, " +
               $"Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}