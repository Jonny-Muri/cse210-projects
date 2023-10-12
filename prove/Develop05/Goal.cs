using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public  Goal(string name, string description, int points)
    {   
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return _shortName;
    }

    public abstract string GetStringRepresentation();
}
    