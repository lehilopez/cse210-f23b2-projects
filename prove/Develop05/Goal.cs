public abstract class Goal
{
    private string _shortName;
    protected string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details = $"[ ] {_shortName} ({_description})";
        return details;
    }
}