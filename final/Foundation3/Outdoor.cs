using System;

public class Outdoor : Event
{
    private string _weatherStatus;
    public Outdoor(string title, string description, string date, string time, string weatherStatus) : base(title, description, date, time)
    {
        _titleType = "Outdoor Gathering";
        _weatherStatus = weatherStatus;
    }

    public string FullDetails()
    {
        Console.WriteLine("\nFull Details: ");
        string text = $"{_titleEvent}: \n{_description}\n{_date} @ {_time}\n{_titleType}: \nThe weather forecast for this day is: {_weatherStatus}";
        return text;
    }
}