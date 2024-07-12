using System;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetStringRepresentation()
    {
        return $"{GetType()}|{_shortName}|{_description}|{_points}";
    }
    public virtual string GetDetailsString()
    {
        char tic = IsComplete() ? 'X' : ' ';
        return $"[{tic}] {_shortName} ({_description})";
    }
}