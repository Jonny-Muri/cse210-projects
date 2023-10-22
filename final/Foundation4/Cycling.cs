using System;

public class Cycling : Activity
{
    public Cycling(string date, double length, float distance) : base(date, length, distance)
    {
        _activityType = "Cycling";
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