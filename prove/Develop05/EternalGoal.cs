using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points)
    {
        _goalType = "Eternal goal";
        _name = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        
    }
}