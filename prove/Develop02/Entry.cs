public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public string GetPromptText()
    {
        return _promptText;
    }
    public string GetEntryText()
    {
        return _entryText;
    }
}