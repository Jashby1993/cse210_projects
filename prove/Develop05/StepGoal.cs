using System;
using System.Collections.Generic;

public class StepGoal : Goal 
{
    int _timesCompleted = 0;
    int _target;
    int _stepPoints;
    bool _fullyComplete = false;
    string _completedGraphic;
    int _fullyCompletedPoints;

    public StepGoal(string name, string description,int fullyCompletedPoints, int target,int stepPoints)
    {
        _goalType = "Step goal";
        _name = name;
        _description = description;
        _stepPoints = stepPoints;
        _target = target;
        _fullyCompletedPoints = fullyCompletedPoints;
    }
     public StepGoal(bool isComplete, string name, string description,int fullyCompletedPoints, int timesCompleted, int target,int stepPoints)
    {
        _fullyComplete = isComplete;
        _goalType = "Step goal";
        _name = name;
        _description = description;
        _stepPoints = stepPoints;
        _timesCompleted = timesCompleted;
        _target = target;
        _fullyCompletedPoints = fullyCompletedPoints;
    }
    public override int RecordEvent()
    {
        int totalPoints;
        if (_fullyComplete == true)
        {
            Console.WriteLine("You have previously completed this goal. Please either add this goal again, or select a different goal.");
            return 0;   
        }
        else
        {
            _timesCompleted++;
            if (_timesCompleted < _target)
            {
                totalPoints = _stepPoints;
                return totalPoints ;
            }
            else
            {
                Console.WriteLine("Congratulations, you have fully completed your goal, and have earned your completion bonus!");
                _fullyComplete = true;
                totalPoints = _stepPoints + _fullyCompletedPoints;
                return totalPoints;
            }
        }
        
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
        return $"{_completedGraphic}{_goalType}--{_name}:{_description}|{_fullyCompletedPoints}({_timesCompleted}of{_target}){_stepPoints}";
    }
}