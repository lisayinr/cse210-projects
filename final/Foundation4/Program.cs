using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        _activities.Add(new Running("27 Sep 2024", 30, 3));
        _activities.Add(new Cycling("12 Oct 2024", 120, 10));
        _activities.Add(new Swimming("04 Jun 2024", 15, 8));

        foreach(Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}