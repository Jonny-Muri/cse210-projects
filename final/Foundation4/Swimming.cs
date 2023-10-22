using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double length,float distance, int laps) : base(date, length, distance)
    {
        _laps = laps;
        _activityType = "Swimming";
    }

    public override string GetDistance()
    {
        _distance = _laps * 50 / 1000;
        return _distance.ToString();
        
    }

    public override string GetSpeed()
    {
        _speed = _distance / ((float)_length) * 60;
        return _speed.ToString();
        
    }

    public override string GetPace()
    {
        _pace = ((float)_length) / _distance;
        return _pace.ToString();
        
    }
        
}