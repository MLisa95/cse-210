using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade?");

        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("You got an A.");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("You got a B.");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("You got a C.");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("You got a D.");
        }

        else
        {
            Console.WriteLine("You got an F.");
        }
    }
}