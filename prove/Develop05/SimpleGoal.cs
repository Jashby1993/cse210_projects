using System;
using System.Collections.Concurrent;

public class SimpleGoal : Goal
{
    private bool _iscomplete = false;
    string _completedGraphic;

    public SimpleGoal(bool isComplete, string name, string description, int points)
    {
        _iscomplete = isComplete;
        _goalType = "Simple goal";
        _name = name;
        _description = description;
        _points = points;
        
    }
    public SimpleGoal(string name, string description, int points)
    {
        
        _goalType = "Simple goal";
        _name = name;
        _description = description;
        _points = points;
        
    }
    public override int RecordEvent()
    {
        if (!_iscomplete)
        {
            _iscomplete = true;
            return _points;
        }
        else
        {
            Console.WriteLine("You have previously completed this goal. Please either add this goal again, or select a different goal.");
            return 0;
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
        return $"{_completedGraphic}{_goalType}--{_name}: {_description}|{_points}";
    }
}