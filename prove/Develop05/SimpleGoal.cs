public class SimpleGoal : Goal
{
    private bool _isComplete;
    
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
        string representation = "";
        return representation;
    }
}