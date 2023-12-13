using System;

// Exceeding requirement
// Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirement
        Reference[] scriptureReference = new Reference[5];
        string[] scriptureText = new string[5];

        scriptureReference[0] = new Reference("Proverbs", 3, 5, 6);
        scriptureText[0] = "Trust in the Lord with all thine heart and learn not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";
        scriptureReference[1] = new Reference("Psalm", 119, 105);
        scriptureText[1] = "Your word is a lamp for my feet, a light on my path.";
        scriptureReference[2] = new Reference("Luke", 24, 2, 3);
        scriptureText[2] = "They found the stone rolled away from the tomb, but when they entered, they did not find the body of the Lord Jesus.";
        scriptureReference[3] = new Reference("2 Nephi", 2, 25);
        scriptureText[3] = "Adam fell that men might be; ane men are, that they might have joy.";
        scriptureReference[4] = new Reference("Alma", 46, 12, 13);
        scriptureText[4] = "In memory of our God, our religion, and freedom, and our peace, our wives, and our children.";

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, scriptureText.Count());

        
        Scripture scripture = new Scripture(scriptureReference[number], scriptureText[number]);

        string input = "";

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords();

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();            
        }
    }
}