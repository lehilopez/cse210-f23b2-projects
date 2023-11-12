public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // Extra functionality
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count());
        return _prompts[number];
    }
}