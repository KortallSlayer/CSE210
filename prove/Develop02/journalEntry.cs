class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;
    Random random = new Random();


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How Was your day?",
            "Talk about someone you met.",
            "Whats something that made you happy today?",
            "If you could redo one thing today what would it be?"
        };
        _date = DateTime.Now.ToString();
        int index = random.Next(prompts.Length);
        _prompt = prompts[index];
        Console.WriteLine($"{_prompt} ");
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    

    

}