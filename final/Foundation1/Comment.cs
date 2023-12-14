public class Comment
{
    private string _user;
    private string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Comment User: {_user}    Text: {_text}");
    }
}