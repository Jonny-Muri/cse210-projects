using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;    
    }

    // Should be a String instead of a void
    public string GetDisplayText()
    {
        if(_endVerse == 0)
        {
            return String.Format("{0} {1}:{2}", _book, _chapter.ToString(), _verse.ToString());

        }
        else
        {
            return String.Format("{0} {1}:{2}-{3}", _book, _chapter.ToString(), _verse.ToString(), _endVerse.ToString());
        }
    }
}