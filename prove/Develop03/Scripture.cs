using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

   
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        string[] words = scripture.Split(" ");

        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

        
    public void HideRandomWords() 
    {        
        int number;
        Random randomGenerator = new Random();
        
        // stretch challenge, try to randomly select from only those words that are not already hidden
        do
        {            
            number = randomGenerator.Next(0, _words.Count());
        }
        while (_words[number].IsHidden());

        _words[number].Hide();
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()}";

        foreach(Word word in _words)
        {
            text = text + " ";
            text = text + word.GetDisplayText();
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool IsCompletelyHidden = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                IsCompletelyHidden = false;
            }
        }
        
        return IsCompletelyHidden;
    }
}