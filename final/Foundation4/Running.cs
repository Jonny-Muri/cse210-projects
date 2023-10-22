using System;

public class Running : Activity
{
    public Running(string date, double length, float distance) : base(date, length, distance)
    {
        _activityType = "Running";
    }

    public override string GetDistance()
    {
        return _distance.ToString();
    }

    public override string GetSpeed()
    {
        return "";
    }

    public override string GetPace()
    {
        return "";
    }
}