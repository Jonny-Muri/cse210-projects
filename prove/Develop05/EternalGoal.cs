using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalType = "Eternal";

    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            _points += _points;
        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}: {_shortName}, {_description}, {_points}";
    }
}