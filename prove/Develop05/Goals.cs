using System.ComponentModel;

public class Goals
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _totalPoints;

    public Goals()
    {
        _totalPoints = 0;
    }

    public Goals(List<Goal> goals)
    {
        _goals = goals;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }


    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}