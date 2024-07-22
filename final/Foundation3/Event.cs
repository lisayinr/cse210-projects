using System;
public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public string StandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate and Time: {_date} at {_time}\nAddress: {_address.CompleteAddress()}";
    }
    public abstract string FullDetails();
    public string ShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent: {_title}\nDate: {_date}";
    }
}