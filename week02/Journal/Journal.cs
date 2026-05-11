public class Journal
{
    public List<Entry> _entries = [];

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entry in the Journal, consider adding one.\n");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile(string filename)
    {

        using StreamWriter writer = new(filename);
        foreach (var entry in _entries)
        {
            writer.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
        }

    }

    public void LoadFromFile(string filename)
    {
        Entry entry = new();

        using StreamReader reader = new(filename);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split("~");
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;
            _entries.Add(entry);
        }


    }
}