public class EternalGoal : Goal
{

    public EternalGoal() : base()
    {

    }

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {

    }

    public override string Format()
    {
        return $"{_name},{_description},{_points}";
    }

    public override void IsComplete()
    {
        _isComplete = false;
    }
}