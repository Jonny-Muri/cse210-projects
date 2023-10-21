using System;

public class Lectures : Event
{
    private string _speaker;
    private double _capacity;

    public Lectures(string title, string description, string date, string time, string speaker, double capacity) : base(title, description, date, time)
    {
        _titleType = "Lectures";
        _speaker = speaker;
        _capacity = capacity;
        
    }

    public string FullDetails()
    {
        Console.WriteLine("\nFull Details: ");
        string text = $"{_titleEvent}: \n{_description}\n{_date} @ {_time}\n{_titleType}: \nSpeaker: {_speaker} (Capacity: {_capacity})";
        return text;
    }

}