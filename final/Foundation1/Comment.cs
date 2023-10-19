using System;

public class Comment
{
    List <string> _commentList = new List<string>();
    private string _name;
    private string _comment;

    public Comment()
    {
        
    }

    public void Display()
    {
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("What is your name? ");
            _name = Console.ReadLine();
            _commentList.Add(_name);
            Console.WriteLine("Write your comment: ");
            _comment = Console.ReadLine();
            _commentList.Add(_comment);
        }

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine($"{_commentList[i]}:");
            Console.WriteLine($"\"{_commentList[i+1]}\"");
        }
    }
    public string GetName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _comment;
    }
}