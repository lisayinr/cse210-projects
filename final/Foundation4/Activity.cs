using System;
public abstract class Activity
{
    protected string _date;
    protected int _activityLength;


    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }


    // public virtual double GetSpeed()
    // {
    //     return 0;
    // }
    // public virtual double GetDistance()
    // {
    //     return 0;
    // }
    // public virtual double GetPace()
    // {
    //     return 0;
    // }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_activityLength} min)- {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2}";
    }
}