using System;

class Program
{
    static void Main(string[] args)
    {
        // reference object
        Reference reference = new Reference("Alma", 37, 6, 7);

        string scriptureText = "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise.";

        //scrioture object
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.AreAllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Well done! I hope you've memorized that scripture well!");
                break;
            }
        }
    }
}