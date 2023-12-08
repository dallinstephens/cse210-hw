public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(int numberOfLaps, string date, int length)
        : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        // Reference on how to convert integer to double:
        // https://stackoverflow.com/questions/12339868/cast-int-variable-to-double
        // Coverting integer was necessary to get the right result.
        return Convert.ToDouble(_numberOfLaps) * 50 / 1000 * 0.62; // distance in miles
    }

    public override double GetSpeed()
    {
        // speed = (distance / minutes) * 60
        // speed = _distance / _length * 60
        return GetDistance() / _length * 60; // speed in miles per hour (mph)
    }

    public override double GetPace()
    {
        // Pace = minutes / distance
        return _length / GetDistance();
    }
}