using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();

        Fraction f2 = new Fraction(2);

        Fraction f3 = new Fraction();
        f3.SetTopNumber(3);
        f3.SetBottomNumber(8);

        Console.WriteLine($"Fraction 1: {f1.GetFractiontring()} = {f1.GetDecimal()}");
        Console.WriteLine($"Fraction 2: {f2.GetFractiontring()} = {f2.GetDecimal()}");
        Console.WriteLine($"Fraction 3: {f3.GetFractiontring()} = {f3.GetDecimal()}");
        
    }
}