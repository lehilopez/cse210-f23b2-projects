public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {
        int count = 0;

        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        
        foreach (Goal goal in _goals)
        {
            count++;
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        //Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string input = Console.ReadLine();
        int choice = int.Parse(input);

        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of goals associated with this goal? ");
        string inputPoints = Console.ReadLine();
        int points = int.Parse(inputPoints);

        if (choice == 1)        
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string inputTarget = Console.ReadLine();
            int target = int.Parse(inputTarget);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string inputBonus = Console.ReadLine();
            int bonus = int.Parse(inputBonus);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }        
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {

    }
}