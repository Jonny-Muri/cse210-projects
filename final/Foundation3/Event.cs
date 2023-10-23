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

    public void AskAddress()
    {
        Console.WriteLine("Please fill out the information on where the event will take place: ");
        Console.WriteLine("What is the name of the street?");
        string street = Console.ReadLine();
        Console.WriteLine("What is the name of the city?");
        string city = Console.ReadLine();
        Console.WriteLine("What is the name of the state?");
        string state = Console.ReadLine();
        Console.WriteLine("What is the zip code?");
        string zip = Console.ReadLine();

        Address address = new Address(street, city, state, zip);
        address.Display();

    }
}