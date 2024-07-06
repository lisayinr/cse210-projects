using System;
public class BreathingActivity : Activity
{
    public void Run()
    {
        DisplayStartingMessage();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
   public BreathingActivity() 
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
    }
}