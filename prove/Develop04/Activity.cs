using System;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private char [] symbols = new [] {'|', '/', '-', '\\'};


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        for (int _ = 0; _ < seconds; _++)
        {
            foreach (char s in symbols)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}