using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        
        int choice = 0;
        
        while (choice != 6)
        {
            //Console.Clear();
            goalManager.Start();
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                goalManager.CreateGoal();
            }
            else if (choice == 2)
            {
                goalManager.ListGoalDetails();
            }
            else if (choice == 3)
            {
                goalManager.SaveGoals();
            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
        }
        
    }
}