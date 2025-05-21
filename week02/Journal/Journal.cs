public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //looping through all entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); //space between entries
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("*************");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string date = reader.ReadLine();
                string prompt = reader.ReadLine();
                string entryText = reader.ReadLine();
                reader.ReadLine();

                Entry entry = new Entry(prompt, entryText);
                entry._date = date; //manually set since constructor sets current date already
                _entries.Add(entry);

                Console.WriteLine($"Loaded {_entries.Count} entries from {filename}");
            }
        }
    }

    public void DeleteFromFile(string file)
    {

    }
}   