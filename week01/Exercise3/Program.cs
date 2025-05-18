using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your lucky number?");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Guess lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Guess higher");
            }

            else
            {
                Console.WriteLine("Congratulations you guessed correctly!");
            }
        }
        
    }
}