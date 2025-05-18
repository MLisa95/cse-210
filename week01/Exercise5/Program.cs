using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);

        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program.");
    }
    
    static string PromptUserName(string userName)
    {
        Console.WriteLine("Please enter your name");
        userName = Console.ReadLine();

        return userName;
    }   

    static int PromptUserNumber(int userNum)
    {
        Console.WriteLine("Please enter your favorite number");
        userNum = int.Parse(Console.ReadLine());

        return userNum;    
    }

    static int SquareNumber(int userNum)
    {
        int squareRt = userNum * userNum;

        return squareRt;
    }

    static void DisplayResult (string userName, int squareRt)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareRt}");
    }
    
}