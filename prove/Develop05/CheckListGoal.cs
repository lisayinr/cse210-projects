using System;
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;


    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _isComplete = false;
    }
    public CheckListGoal(string name, string description, int points, bool isComplete, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _isComplete = isComplete;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points! You earned your bonus and have completed  your goal!");
            _isComplete = true;
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"-- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"{_isComplete}|{_amountCompleted}|{_target}|{_bonus}";
    }
}