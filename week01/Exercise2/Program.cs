using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a random number. ");
        float number_one = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter a second random number. ");
        float number_two = float.Parse(Console.ReadLine());

        if (number_one > number_two)
        {
            Console.WriteLine("Your first number is greater than your second number.");
        }
        else
        {
            Console.WriteLine("Your second number is greater than you first number. ");
        }
    }
}