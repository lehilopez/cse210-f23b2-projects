//using System;

public class ListingActivity : Activity
{
    private int count;
    private List<string> _prompts = new List<string>();

    //public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    //{

    //}

    public void Run()
    {
        
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}