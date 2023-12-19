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

    public override int GetBonus()
    {
        return 0;
    }
    
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {        
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"{GetType()}:{GetName()}:{GetDescription()}:{GetPoints()}:{_isComplete}";
        return representation;
    }
}