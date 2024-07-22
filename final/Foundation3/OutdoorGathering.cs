using System;
public class OutdoorGathering : Event
{
    private string _weatherStatement;


    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }


    public override string FullDetails()
    {
        return $"{StandardDetails()}\nWeather Forecast: {_weatherStatement}";
    }
}