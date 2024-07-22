using System;
public class Swimming : Activity
{
    private int _laps;
    double _metersPerLap = 50.0;
    double _metersToMiles = 0.000621371;

    public Swimming(string date, int activityLength, int laps) :base(date, activityLength)
    {
        _laps = laps;
    }


    public override double GetSpeed()
    {
        return GetDistance() / (_activityLength / 60.0);
    }
    public override double GetDistance()
    {

        double metersTotal = _laps * _metersPerLap;
        double miles = metersTotal * _metersToMiles;
        return miles;
    }
    public override double GetPace()
    {
        return (_activityLength / 60.0) / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_activityLength} min)- {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2}";
    }
}