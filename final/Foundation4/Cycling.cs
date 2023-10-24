using System;

public class Cycling : Activity
{
    public Cycling(string date, double length, double distance) : base(date, length)
    {
        _activityType = "Cycling";
        _distance = distance;
        _speed += (_distance / _length) * 60;
        _pace += 60 / _speed;
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