public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();


    public int GetTotalPoints()
    {
        int total = 0;
        foreach (Goal goal in _goals)
        {
            total += goal.GetPoints();
        }

        return total;
    }

    public void AddGoal()
    {
        Console.WriteLine("What type of goal would you like to add?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.WriteLine("Enter choice (1-3): ");

        string choice = Console.ReadLine();

        Console.WriteLine("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a short description: ");
        string description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter the bonus points after completion: ");
            int bonus = int.Parse(Console.ReadLine());

            EternalGoals goal = new EternalGoals(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times must this goal be completed? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points after completion: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Goal added successfully!\n");
    }

    // showing goals list

    public void ShowGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.\n");
            return;
        }

        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];

            if (goal is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. {checklist.GetStatus()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. [ ] {goal.GetName()} -- {goal.GetDescription()}");
            }
        }

        Console.WriteLine();

    }

    public void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record yet.\n");
            return;
        }

        Console.WriteLine("Which goal did you complete or make progress on?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter the number: ");
        string input = Console.ReadLine();

        int index;
        bool isValid = int.TryParse(input, out index);

        if (isValid && index >= 1 && index <= _goals.Count) // checks if selection is within range
        {
            Goal selectedGoal = _goals[index - 1];
            int earnedPoints = selectedGoal.RecordEvent();
            Console.WriteLine($"You earned {earnedPoints} points!\n");
        }
        else
        {
            Console.WriteLine("Invalid goal number.\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals (e.g. goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simple)
                {
                    writer.WriteLine($"SimpleGoal:{simple.GetName()}|{simple.GetDescription()}|{simple.GetPoints()}|{simple.IsComplete()}");
                }
                else if (goal is EternalGoals eternal)
                {
                    writer.WriteLine($"EternalGoals:{eternal.GetName()}|{eternal.GetDescription()}|{eternal.GetPoints()}");
                }
                else if (goal is ChecklistGoal checklist)
                {
                    writer.WriteLine($"ChecklistGoal:{checklist.GetName()}|{checklist.GetDescription()}|{checklist.GetPoints()}|{checklist.GetTargetCount()}|{checklist.GetCurrentCount()}|{checklist.GetBonusPoints()}");
                }
            }
        }

        Console.WriteLine("Goals saved successfully!\n");
    }
    
    public void LoadGoals()
{
    Console.Write("Enter filename to load from (e.g., goals.txt): ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.\n");
        return;
    }

    string[] lines = File.ReadAllLines(filename);
    _goals.Clear(); // Clear current list before loading new data

    foreach (string line in lines)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        if (type == "SimpleGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);

            SimpleGoal sg = new SimpleGoal(name, desc, points);
            if (isComplete)
            {
                sg.RecordEvent(); // Mark as completed
            }
            _goals.Add(sg);
        }
        else if (type == "EternalGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            EternalGoals eternalGoals = new EternalGoals(name, desc, points); // bonus ignored
            _goals.Add(eternalGoals);
        }
        else if (type == "ChecklistGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int bonus = int.Parse(parts[5]);
            int current = int.Parse(parts[6]);

            ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);

            // simulate recording events to set current count
            for (int i = 0; i < current; i++)
            {
                cg.RecordEvent();
            }

            _goals.Add(cg);
        }
    }

    Console.WriteLine("Goals loaded successfully!\n");
}
}