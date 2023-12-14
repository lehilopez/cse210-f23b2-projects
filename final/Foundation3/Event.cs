public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public string GetType()
    {
        return _type;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Event title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date and Time: {_date} {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}