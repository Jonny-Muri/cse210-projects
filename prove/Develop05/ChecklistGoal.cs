using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return "";
    }
     
    public override string GetStringRepresentation()
    {
        return "";
    }
}