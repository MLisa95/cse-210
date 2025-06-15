public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you are grateful for.",
        "List people who have helped you recently.",
        "List positive things that happened today.",
        "List your favorite things to do when relaxing.",
        "List your personal strengths."
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you to count your blessings by listing as many responses as you can.")
    {
    }

    public void Start()
    {
        Console.WriteLine(DisplayMessage());
        SetDuration();
        DisplayDurationMessage();
        AnimateGetReady();

        // Get random prompt

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");

        Console.WriteLine("Begin listing. Press Enter after each entry");

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Time is up! You listed {count} items.");
        Console.WriteLine("\nPress Enter to return to the menu");
        Console.ReadLine();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\rStarting in: {i}   ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\rGo!");
    }
}