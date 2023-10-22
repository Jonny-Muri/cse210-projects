using System;
using System.Diagnostics;

public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected double _minutes;
    protected string _activityType;


    public Activity(string date, double length, float distance)
    {
        _date = date;
        _length = length;
        _distance = distance;

    }

    public string GetSummary()
    {
        string text = $"{_date} {_activityType} ({_length} min): Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} per mile";
        return text;
    }

    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
    
}