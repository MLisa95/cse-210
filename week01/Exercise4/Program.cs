using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Please enter a number");

            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int total = 0;

        foreach (int num in numbers)
        {
            total += num;
        }

        Console.WriteLine($"Your total is {total}");

        /*foreach (int num in userNumber)
        {
            Console.WriteLine(num);
        }

        
        if (userNumber != 0)
        {

        }


        foreach (string name in names)
        {
            Console.WriteLine(name);
        }*/
    }
}