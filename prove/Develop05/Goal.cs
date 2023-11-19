// Reference on how to write text files:
// https://byui-cse.github.io/cse210-course-2023/unit05/develop.html
// This is used to find the Streamwriter class for writing text files.
using System.IO;
using System.Runtime.ExceptionServices;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    protected bool _isComplete;

    public Goal()
    {
        _isComplete = false;
    }

    // Constructor used for Loading SimpleGoal
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    // Constructor used for Loading EternalGoal and ChecklistGoal
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void QuestionName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void QuestionDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
    }

    public void QuestionPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string Summary()
    {
        return $"{_name} ({_description})";
    }

    public virtual string Format()
    {
        return "";
    }

    public virtual void IsComplete()
    {
        _isComplete = true;
    }
}