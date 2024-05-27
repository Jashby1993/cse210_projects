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
    public override SimpleGoal ParseGoal(string goalLine)
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
        string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
        string descriptor = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
        int intPoints = int.Parse(goalLine.Substring(pipeIndex + 1));
        SimpleGoal newGoal = new SimpleGoal(isComplete,name,descriptor,intPoints);
        return newGoal;
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