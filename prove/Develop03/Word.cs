using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;

    }

    //This looks like a Setter
    public void Hide()
    {
        _isHidden = true;
        string word = "";
        for(int i = 0; i < _text.Length; i++)
        {
            word += "_";
        }

        _text = word;
    }

    //This looks like a setter
    public void Show()
    {
        _isHidden = false;
    }

    // This is a getter
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }

}