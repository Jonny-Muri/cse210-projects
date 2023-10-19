using System;

public class Video
{
    private string _title;
    private string _author;
    // Length will be in seconds
    private int _length;
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title} by {_author}\nLength: {_length} Seconds");
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
}