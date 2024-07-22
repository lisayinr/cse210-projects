using System;
public class Cycling : Activity
{
    private double _speed;


    public Cycling(string date, int activityLength, double speed) :base(date, activityLength)
    {
        _speed = speed;
    }


    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * _activityLength) / 60;
    }
    public override double GetPace()
    {
        return 60/_speed;
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_activityLength} min)- {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2}";
    }
}