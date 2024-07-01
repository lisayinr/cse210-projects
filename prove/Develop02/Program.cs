using System;

class Program
{
    static Journal theJournal = new Journal();
    static PromptGenerator thePromptGenerator = new PromptGenerator();
    static void Main(string[] args)
    {

        while (true)
        {
            Menu();
        }
    }
    static void Menu()
    {
        Console.WriteLine("MENU: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        string option = Console.ReadLine();

        if (option == "1")
        {
            WriteEntry();
        }
        else if (option == "2")
        {
            theJournal.DisplayAll();
        }
        else if (option == "3")
        {
            LoadJournalFromFile();
        }
        else if (option == "4")
        {
            SaveJournalToFile();
        }
        else if (option == "5")
        {
            return;
        }
        else
        {
            Console.WriteLine("Please try again");
        }
    }
    static void WriteEntry()
    {
        string prompt = thePromptGenerator.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        string journalEntry = Console.ReadLine();
        Entry entry = new Entry(prompt, journalEntry);
        theJournal.AddEntry(entry);
    }
    static void SaveJournalToFile()
    {
        Console.WriteLine("File name: ");
        string filename = Console.ReadLine();
        theJournal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }
    static void LoadJournalFromFile()
    {
        Console.WriteLine("File name: ");
        string filename = Console.ReadLine();
        theJournal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}