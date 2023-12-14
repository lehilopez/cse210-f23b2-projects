public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details = "";
        return details;
    }
}