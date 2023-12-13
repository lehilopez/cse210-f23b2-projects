using System;

class Program
{
    static void Main(string[] args)
    {
                
        int choice = 0;
        int duration = 0;    

        while (choice != 4)
        {  
            Console.Clear();
            DisplayMenu();
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                Console.Clear();
                breathingActivity.DisplayStartingMessage();
                input = Console.ReadLine();
                duration = int.Parse(input);
                
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("2. Start reflecting activity");
            }
            else if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine("3. Start listing activity");  
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");        
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}