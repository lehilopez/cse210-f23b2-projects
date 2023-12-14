public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
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
        string representation = $"{GetType()}:{GetName()},{GetDescription()},{GetPoints()}";
        return representation;
    }
}