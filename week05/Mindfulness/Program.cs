using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program.");
            Console.WriteLine("Please select an activity.");
            Console.WriteLine("1. Breathing Activity.");
            Console.WriteLine("2. Reflecting Activity.");
            Console.WriteLine("3. Listing Activity.");
            Console.WriteLine("4. Quit.");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Start();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }

            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Start();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.Start();
        
            }

        }









    }
}