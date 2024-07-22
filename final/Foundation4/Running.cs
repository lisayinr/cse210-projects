using System;
public class Running : Activity
{
    private double _distance;
    

    public Running(string date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }


    public override double GetSpeed()
    {
        return (_distance / _activityLength) * 60;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _activityLength / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_activityLength} min)- {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2}";
    }
}
