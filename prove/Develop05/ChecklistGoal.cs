public class ChecklistGoal : Goal
{
    private int _times;
    private int _bonus;
    private int _timesDone;

    public ChecklistGoal() : base()
    {
        _timesDone = 0;
    }

    public ChecklistGoal(string name, string description, int points, int bonus, int times, int timesDone)
        : base(name, description, points)
    {
        _times = times;
        _bonus = bonus;
        _timesDone = timesDone;

        // This is needed when listing goals after loading a file to still show box checked if goal completed.
        if (_timesDone >= _times)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }

    public void QuestionTimes()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
    }

    public void QuestionBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string Summary()
    {
        return $"{_name} ({_description}) -- Currently completed: {_timesDone}/{_times}";
    }
    public override string Format()
    {
        return $"{_name},{_description},{_points},{_bonus},{_times},{_timesDone}";
    }

    public override void IsComplete()
    {
        _timesDone++;

        if (_timesDone >= _times)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }

    public override int GetPoints()
    {
        if (_isComplete)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
}