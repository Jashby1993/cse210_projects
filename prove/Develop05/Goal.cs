using System;

public abstract class Goal
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;

    public abstract void RecordEvent();

    public virtual string DisplayGoal()
    {

        string goalDisplay = $"[∅] {_name}: {_description}";
        return goalDisplay;
    }

}