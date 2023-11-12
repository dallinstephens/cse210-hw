public class SimpleGoal : Goal
{

    public SimpleGoal() : base()
    {

    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points, isComplete)
    {

    }

    public override string Format()
    {
        return $"{_name},{_description},{_points},{_isComplete}";
    }

}