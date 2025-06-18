using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("18 June 2025", 45, 1.8),
            new Cycling("18 June 2025", 27, 10.3),
            new Swimming("18 June 2025", 54, 13),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine("****************************"); // separate activities
            Console.WriteLine();
        }
    }
}