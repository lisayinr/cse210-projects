using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _isComplete = true;
        return _points;
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"{_isComplete}";
    }

}