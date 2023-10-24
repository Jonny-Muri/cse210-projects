using System;
using System.Diagnostics;

public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _activityType;


    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        string text = $"{_date} {_activityType} ({_length} min): Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
        return text;
    }

    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
    
}