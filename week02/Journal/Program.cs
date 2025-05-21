using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator generator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Welcome to your journal:");
            Console.WriteLine();
            Console.WriteLine("What would you like to do today? Please type in 1 - 5: ");
            Console.WriteLine();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Load journal from file");
            Console.WriteLine(); //extra space to separate menu from choice

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine("Share your thoughts: ");
                string response = Console.ReadLine();

                Entry entry = new Entry(prompt, response);
                journal._entries.Add(entry);

                Console.WriteLine("Thank you for your entry");
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                journal.SaveToFile("journal.txt");
            }

            else if (choice == "4")
            {
                journal.LoadFromFile("journal.txt");
                journal.DisplayAll();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye. Come back soon.");
            }

            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
    }
    }

    

}