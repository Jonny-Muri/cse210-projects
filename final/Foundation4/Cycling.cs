using System;

public class Cycling : Activity
{
    public Cycling(string date, double length, float distance) : base(date, length, distance)
    {
        _activityType = "Cycling";
    }

    public override string GetDistance()
    {
        return "";
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