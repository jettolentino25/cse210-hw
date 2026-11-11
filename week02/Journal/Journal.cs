using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

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
        string json = JsonSerializer.Serialize(_entries);
        File.WriteAllText(file, json);
    }

    public void LoadFromFile(string file)
    {
        string json = File.ReadAllText(file);
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(json)
            ?? throw new JsonException("The file must contain a list of journal entries.");

        _entries = loadedEntries;
    }
}