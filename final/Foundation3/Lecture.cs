public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        SetType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullLectureDetails()
    {
        StandardDetails();
        Console.WriteLine($"Event Type: {GetType()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}