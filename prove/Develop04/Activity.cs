public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    /*public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }*/

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for a session? ");
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int second)
    {

    }
}