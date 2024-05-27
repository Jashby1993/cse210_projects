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
            else if (_timesCompleted == _target)
            {
                Console.WriteLine("Congratulations, you have fully completed your goal, and have earned your completion bonus!");
                _fullyComplete = true;
                totalPoints = _stepPoints + _fullyCompletedPoints;
                return totalPoints;
            }
        }
        
    }
    public override Goal ParseGoal(string goalLine)
    {
        bool isComplete = false;
        int openBracketIndex = goalLine.IndexOf('[');
        char completionFlag = goalLine[openBracketIndex + 1];
        if (completionFlag == 'x')
        {
            isComplete = true;
            
        }
        else if (completionFlag == ' ')
        {
            isComplete = false;
        }
        int doubleDashIndex = goalLine.IndexOf("--"); 
        int colonIndex = goalLine.IndexOf(':');
        int pipeIndex = goalLine.IndexOf('|');
        int openParenthesisIndex = goalLine.IndexOf('(');
        int ofIndex = goalLine.IndexOf("of");
        int closeParenthesisIndex = goalLine.IndexOf(')');
        string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
        string description = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
        int fullCompletePoints = int.Parse(goalLine.Substring(pipeIndex + 1, openParenthesisIndex - pipeIndex - 1));
        int stepsCompleted = int.Parse(goalLine.Substring(openParenthesisIndex + 1, ofIndex - openParenthesisIndex - 1));
        int totalSteps = int.Parse(goalLine.Substring(ofIndex + 2, closeParenthesisIndex - ofIndex - 2));
        int stepPoints = int.Parse(goalLine.Substring(closeParenthesisIndex + 1));
        StepGoal newGoal = new StepGoal(isComplete,name,description,fullCompletePoints,stepsCompleted,totalSteps,stepPoints);
        return newGoal;

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