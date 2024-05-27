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
    
    public override int RecordEvent()
    {
        return _points;
    }
    public override EternalGoal ParseGoal(string goalLine)
    {
       int doubleDashIndex = goalLine.IndexOf("--"); 
       int colonIndex = goalLine.IndexOf(':');
       int pipeIndex = goalLine.IndexOf('|');
       string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
       string descriptor = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
       int intPoints = int.Parse(goalLine.Substring(pipeIndex + 1));
       EternalGoal newGoal = new EternalGoal(name, descriptor,intPoints);
       return newGoal;
    }
}