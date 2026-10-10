class Journal

{
    public string _save;
    public string _load;
    public List<JournalEntry> _entries = new List<JournalEntry>();
    

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    
    public void SaveJournal()
    {
        Console.WriteLine("what would you like to save it as?");
        Console.WriteLine("> ");
        _save = Console.ReadLine();
        string filename = _save;
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach(JournalEntry entry in _entries)
        {
            outputFile.WriteLine(entry);
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("what would you like to load?");
        Console.WriteLine("> ");
        _load = Console.ReadLine();
        string filename = _load;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
            {
                JournalEntry newEntry = new JournalEntry();
                _entries.Add(newEntry);
            }
    }
}