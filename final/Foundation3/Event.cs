using System;

public class Event
{
    protected string _titleEvent;
    protected string _titleType;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time)
    {
        _titleEvent = title;
        _description = description;
        _date = date;
        _time = time;

    }
    

    public string StandardDetail()
    {
        Console.WriteLine("\nStandard Details: ");
        string standard = $"{_titleEvent}: \n{_description}\n{_date} @ {_time}";
        return standard;
    }

    public string ShortDescription()
    {
        Console.WriteLine("\nShort Description: ");
        string description = $"{_titleType}:\n{_titleEvent} on {_date}";
        return description;
    }
}