using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
        _activityType = "Swimming";
        _distance +=  _laps * 50 / 1000 * 0.62;
        _speed += _distance / _length * 60;
        _pace += _length / _distance;

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