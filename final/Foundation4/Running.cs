public class Running : Activity
{
    private double _distance; // distance is in miles

    public Running(double distance, string date, int length)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance; // distance in miles
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60; // speed in miles per hour (mph)
    }

    public override double GetPace()
    {
        // Pace = minutes / distance
        return _length / _distance;
    }
}