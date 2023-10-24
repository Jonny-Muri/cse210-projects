using System;

public class Running : Activity
{
    public Running(string date, double length, double distance) : base(date, length)
    {
        _activityType = "Running";
        _distance = distance;
        _pace += _length / _distance;
        _speed += 60 / _pace;
       
    }

    public override void GetDistance()
    {
        Console.WriteLine(_distance);
    }

    public override void GetSpeed()
    {
        Console.WriteLine(_speed);
    }

    public override void GetPace()
    {
        Console.WriteLine(_pace);
    }
}