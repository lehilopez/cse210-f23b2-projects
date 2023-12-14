public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
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