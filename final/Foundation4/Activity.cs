public abstract class Activity
{
    private string _date;
    private int _length;

    /*public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }*/

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}