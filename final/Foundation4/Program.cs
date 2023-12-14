using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Running running = new Running("01 Jan 2024", 30, 6);
        Cycling cycling = new Cycling("02 Jan 2024", 120, 50);
        Swimming swimming = new Swimming("03 Jan 2023", 20, 10);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }        
    }
}