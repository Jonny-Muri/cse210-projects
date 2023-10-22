using System;

public class Running : Activity
{
    public Running(string date, double length, float distance) : base(date, length, distance)
    {
        _activityType = "Running";
    }

    public override void GetDistance()
    {
        
    }

    public override void GetSpeed()
    {
        
    }

    public override void GetPace()
    {
        
    }
}