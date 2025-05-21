public class PromptGenerator
{
    public List<string> _prompts;
    public Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "What was the best part of your day today?",
            "What are you most grateful for today?",
            "How did you take care of yourself today?",
            "Describe a moment today you want to remember",
            "If today had a theme song, what would it be?",
            "What challenged you today and how did you overcome it?",
            "What goal do you have for tomorrow?",
            "What made you smile today?"
        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index]
;    }
}