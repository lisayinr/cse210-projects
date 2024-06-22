using System.IO;
public class Journal
{
    public List<Entry> _entries;
    _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetDate()}|{entry.GetPromptText()}|{entry.GetEntryText()}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}