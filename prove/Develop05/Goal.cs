using System;

public abstract class Goal
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    
    
    protected Goal()
    {
        
    }

    public abstract int RecordEvent();
    public abstract Goal ParseGoal(string goalLine);

    public virtual string DisplayGoal()
    {

        string goalDisplay = $"[∅]{_goalType}--{_name}:{_description}|{_points}";
        return goalDisplay;
    }

}