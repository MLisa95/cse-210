public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity helps you relax by guiding you through slow breathing.")
    {
    }

    public void Start()
    {
        Console.WriteLine(DisplayMessage());
        SetDuration();
        DisplayDurationMessage();

        Console.Clear();
        AnimateGetReady();

        int cycleTime = 7; // Total time per breathe in/out cycle
        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            AnimateBreathing("Breathe in", new string[] { ".  ", "o  ", "O  " });
            AnimateBreathing("Breathe out", new string[] { "O  ", "o  ", ".  " });
            elapsed += cycleTime;
        }

        Console.WriteLine(EndMessage());
    }

    public string EndMessage()
    {
        return $"Well done! You just completed a {GetDuration()} second breathing session. Take this calm with you.";
    }

    private void AnimateBreathing(string action, string[] stages)
    {
        foreach (var stage in stages)
        {
            Console.Write($"\r{action}: {stage}");
            Thread.Sleep(3000); // Adjust for speed/feel
        }
    }
}