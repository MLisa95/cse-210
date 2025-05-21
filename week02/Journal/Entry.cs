public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    //Constructor, giving it the parts of the journal 
    //and it puts them together
    public Entry(string prompt, string entryText)
    {
        _prompt = prompt;
        _entryText = entryText;
        _date = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
    }

    public void Display()
    {
        Console.WriteLine($"[{_date}] Prompt: {_prompt}");
        Console.WriteLine($"Your Thoughts: {_entryText}");
    }
}