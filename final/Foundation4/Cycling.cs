public class Cycling : Activity
{
    private double _speed; // speed is in miles per hour (mph)

    public Cycling(double speed, string date, int length)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60 * _length; // distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // speed in miles per hour (mph)
    }

    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
}