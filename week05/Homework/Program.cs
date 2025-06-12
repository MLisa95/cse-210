using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("Lisakhanya", "The Art of Joy");
        Console.WriteLine(assign.GetSummary());

        MathAssignment assign1 = new MathAssignment("Izani", "Reproduction", "7.2", "7.2 - 7.6");
        Console.WriteLine(assign1.GetHomeworkList());
    }
}