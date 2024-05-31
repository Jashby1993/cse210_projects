using System;

public class Running : Workout
{



public Running(string date, int duration, float distance)
{
    _type = "Running";
    _date = date;    
    _duration = duration;
    _distance = distance;
    _speed = GetSpeed();
    _pace = GetPace();
}

}