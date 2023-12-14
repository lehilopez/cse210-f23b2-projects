public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        bool isComplete = false;
        return isComplete;
    }

    public override string GetDetailsString()
    {
        string details = $"[ ] {GetName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"{GetType()}:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
        return representation;
    }
}