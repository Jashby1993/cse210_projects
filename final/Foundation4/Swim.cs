using System;

public class Swim : Workout
{
    int _laps;

    public Swim(string date,int duration, int laps)
    {
        _type = "Swim";
        _date = date;
        _duration = duration;
        _laps = laps;
        _distance = LapsToDistance();
        _speed = GetSpeed();
        _pace = GetPace();
    }
    public float LapsToDistance()
    {
        return (float)Math.Round((double)(_laps * 50) / 1000, 1);
    }
}