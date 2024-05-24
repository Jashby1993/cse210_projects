using System;

public class SimpleGoal : Goal
{
    private bool _iscomplete = false;
    string _completedGraphic;

    public SimpleGoal(string name, string description, int points)
    {
        _goalType = "Simple goal";
        _name = name;
        _description = description;
        _points = points;
        
    }
    public override void RecordEvent()
    {
        if (!_iscomplete)
        {
            
        }
        else
        {
            Console.WriteLine("You have previously completed this goal. Please either add this goal again, or select a different goal.");
        }
    }
    public override string DisplayGoal()
    {
    
        if (_iscomplete)
        {
            _completedGraphic = "[x]";
        }
        else
        {
            _completedGraphic = "[ ]";
        }
        return $"{_goalType} {_completedGraphic} {_name}: {_description}";
    }
}