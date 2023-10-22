using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double length,float distance, int laps) : base(date, length, distance)
    {
        _laps = laps;
        _activityType = "Swimming";
    }

    public override void GetDistance()
    {
        _distance = _laps * 50 / 1000;
        Console.WriteLine(_distance);
    }

    public override void GetSpeed()
    {
        _speed = (_distance / _length) * 60;
        Console.WriteLine(_speed);
    }

    public override void GetPace()
    {
        _pace = _minutes / _distance;
        Console.WriteLine(_pace);
    }
        
}