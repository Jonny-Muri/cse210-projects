using System;
using System.Diagnostics;

public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected float _distance;
    protected float _speed;
    protected float _pace;
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

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();
    
}