public class Activity
{
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string DisplayMessage()
    {
        return $"Welcome to the {_name} activity.\n\n{_description}\n\nHow long do you want your session to be (in seconds)?\n>  ";
    }

    public void SetDuration()
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int seconds))
        {
            _duration = seconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30;
        }
    }

    public int GetDuration()
    {
        return _duration;
    }


    public void DisplayDurationMessage()
    {
        Console.WriteLine($"Your {_name} will last {_duration} seconds.");
    }

    public void AnimateGetReady()
    {
        string baseMessage = "Get ready";
        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"\r{baseMessage}{new string('.', i)}   ");
            Thread.Sleep(600);
        }
        Console.WriteLine();
    }
}