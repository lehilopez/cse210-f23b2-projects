using System;

// This program includes the extra functionality to add new prompts to the prompt generator
// Users can think of new prompts that they would like to include to the prompt list

class Program
{
    static void Main(string[] args)
    {
        // Initialize the prompts
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");                
        
        Journal journal = new Journal();

        int choice = 0;    

        while (choice != 6)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                Entry entry = new Entry();

                Console.WriteLine();
                entry._promptText = prompts.GetRandomPrompt();
                Console.WriteLine(entry._promptText);

                string answer = Console.ReadLine();
                entry._entryText = answer;

                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == 5)   // Extra functionality
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your new journal prompt:");
                string newPrompt = Console.ReadLine();

                prompts._prompts.Add(newPrompt);
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Add new prompt");     // Extra functionality
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
    }
}