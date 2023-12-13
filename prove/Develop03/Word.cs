using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string word;

        if (_isHidden)
        {
            word = new string('_', _text.Length);
        }
        else
        {
            word = _text;
        }
        
        return word;
    }
}