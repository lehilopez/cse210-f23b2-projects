public class Reception : Event
{
    private string _registration;

    public Reception(string title, string description, string date, string time, Address address, string registration) : base(title, description, date, time, address)
    {
        SetType("Reception");
        _registration = registration;
    }

    public void FullReceptionDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event Type: {GetType()}");
        Console.WriteLine($"Registration: {_registration}");
    }
}