using System;
using System.Collections.Generic;

public class StepGoal : Goal 
{
    int _timesCompleted = 0;
    int _target;
    int _stepPoints;
    bool _fullyComplete = false;
    string _completedGraphic;

    public StepGoal(string name, string description, int stepPoints, int target, int fullCompletionPoints)
    {
        _goalType = "Step goal";
        _name = name;
        _description = description;
        _stepPoints = points;
        _target = target;
        _fullCompletionPoints = bonusPoints;
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