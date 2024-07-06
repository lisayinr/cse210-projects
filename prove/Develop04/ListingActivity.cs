using System;
public class ListingActivity : Activity
{
    private string [] _prompts = new string []
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private Random _rng = new ();

    public string GetRandomPrompt()
    {
        return _prompts[_rng.Next(_prompts.Length)];
    }
    public List<string> GetListFromUser()
    {
        return [];
    }
    public void Run()
    {
        int count = 0;
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompts: ");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.ReadLine();
            Console.WriteLine();
            count += 1;
        }
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }
   public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}