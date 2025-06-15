using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you helped a stranger.",
        "Think of a time you overcame a fear.",
        "Think of a time when you had to be humble.",
        "Think of a time when you made a meaningful sacrifice."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel afterward?",
        "What could you learn from this moment going forward?"
    };

    // constructor 
    public ReflectionActivity()
        : base("Reflection", "This activity helps you reflect on meaningful experiences in your life.")
    {
    }

    public void Start()
    {
        Console.WriteLine(DisplayMessage());
        SetDuration();

        Console.Clear();
        AnimateGetReady();

        Thread.Sleep(2000);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n----- {prompt} -----");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions:");
        Thread.Sleep(3000);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int questionIndex = 0;

        while (DateTime.Now < endTime && questionIndex < _questions.Count)
        {
            Console.Write($"> {_questions[questionIndex]} ");
            ShowSpinner(13);
            questionIndex++;
        }

        Console.WriteLine(EndMessage());
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private void ShowSpinner(int halfSeconds)
    {
        for (int i = 0; i < halfSeconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public string EndMessage()
    {
        return $"Great work! You've spent {GetDuration()} seconds reflecting on personal experiences. Keep growing.";
    }
}