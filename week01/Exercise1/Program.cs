 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? >");
        string name = Console.ReadLine();

        Console.WriteLine("What is your surname?");
        string surname = Console.ReadLine();

        Console.WriteLine($"My name is {surname}, {name} {surname}.");
    }
}