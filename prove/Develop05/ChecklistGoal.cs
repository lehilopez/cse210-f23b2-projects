public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
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
        string details = "";
        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = "";
        return representation;
    }
}