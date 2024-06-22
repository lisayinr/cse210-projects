using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator thePromptGenerator = new PromptGenerator();
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
            journal.DisplayAll();
        }
        else if (option == "3")
        {
            SaveJournalToFile();
        }
        else if (option == "4")
        {
            LoadJournalFromFile();
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
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        string journalEntry = Console.ReadLine();
        Entry entry = new Entry(prompt, journalEntry);
        journal.AddEntry(entry);
    }
    static void SaveJournalToFile()
    {
        Console.WriteLine("File name: ");
        string filename = Console.ReadLine();
        Console.WriteLine("Journal saved.");
    }
    static void LoadJournalFromFile()
    {
        Console.WriteLine("File name: ");
        string filename = Console.ReadLine();
        Journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}