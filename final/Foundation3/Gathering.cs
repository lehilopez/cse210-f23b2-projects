public class Gathering : Event
{
    private string _forecast;

    public Gathering(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        SetType("Gathering");
        _forecast = forecast;
    }

    public void FullGatheringDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event Type: {GetType()}");
        Console.WriteLine($"Forecast: {_forecast}");
    }
}