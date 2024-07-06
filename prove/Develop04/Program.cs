using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
        }
    }
    static void Menu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start relecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        string option = Console.ReadLine();
        Console.WriteLine();

        if (option == "1")
        {
            BreathingActivity newBreathingActivity = new BreathingActivity();
            newBreathingActivity.Run();
        }
        else if (option == "2")
        {
            ReflectionActivity newReflectionActivity = new ReflectionActivity();
            newReflectionActivity.Run();
        }
        else if (option == "3")
        {
            ListingActivity newListingActivity = new ListingActivity();
            newListingActivity.Run();
        }
        else if (option == "4")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Please try again.");
        }
    }
}