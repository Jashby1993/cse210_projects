using System;
using System.Collections.Generic;

public class StepGoal : Goal 
{
    int _timesCompleted = 0;
    int _target;
    int _bonusPoints;
    bool _fullyComplete = false;
    string _completedGraphic;

    public StepGoal(string name, string description, int points, int target, int bonusPoints)
    {
        _goalType = "Step goal";
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonusPoints = bonusPoints;
    }
    public override void RecordEvent()
    {
        
    }
    public override string DisplayGoal()
    {
        if (_fullyComplete)
        {
            _completedGraphic = "[x]";
        }
        else
        {
            _completedGraphic = "[ ]";
        }
        return $"{_goalType} {_completedGraphic} {_name}: {_description} [Completed {_timesCompleted} of {_target}]";
    }
}