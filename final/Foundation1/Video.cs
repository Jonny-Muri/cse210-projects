using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length; // This will be in seconds
    public List<Comment> _comments = new List<Comment>();
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title} by {_author}\nLength: {_length} Seconds");
        Console.WriteLine("Comment Section: ");
    }

    // public string GetTitle()
    // {
    //     return _title;
    // }
    // public string GetAuthor()
    // {
    //     return _author;
    // }
    // public int GetLength()
    // {
    //     return _length;
    // }
}