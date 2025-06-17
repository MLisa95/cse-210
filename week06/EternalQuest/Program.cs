using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gmanager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to The Eternal Quest");
            Console.WriteLine("---------------------");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Show Total Points");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter 1-7: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                gmanager.AddGoal();
            }
            else if (choice == "2")
            {
                gmanager.ShowGoals();
            }
            else if (choice == "3")
            {
                gmanager.SaveGoals();
            }
            else if (choice == "4")
            {
                gmanager.LoadGoals();
            }
            else if (choice == "5")
            {
                gmanager.RecordGoalEvent();
            }
            else if (choice == "6")
            {
                int total = gmanager.GetTotalPoints();
                Console.WriteLine($"Your total points: {total}");
            }
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
            }

        }
    }
}