using System;

public class Entry
{
    private readonly string _date;
    private readonly string _promptText;
    private readonly string _entryText;

    public string Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}