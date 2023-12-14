public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        bool isComplete = false;
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"{GetType()}:{GetName()}:{GetDescription()}:{GetPoints()}:{_isComplete}";
        return representation;
    }
}