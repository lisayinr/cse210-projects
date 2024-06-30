using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Type to quit to exit or enter to continue: ");
            string respone = Console.ReadLine();
            if (respone == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}