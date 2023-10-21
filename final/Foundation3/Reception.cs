using System;

public class Reception : Event
{
    private string _RSVP;


    public Reception(string title, string description, string date, string time, string RSVP) : base(title, description, date, time)
    {
        _titleType = "Reception";
        _RSVP = RSVP;
    }

    public string FullDetails()
    {
        Console.WriteLine("\nFull Details");
        string text = $"{_titleEvent}: \n{_description}\n{_date} @ {_time}\nPlease RSVP at this email address: {_RSVP}";
        return text;
    }
}