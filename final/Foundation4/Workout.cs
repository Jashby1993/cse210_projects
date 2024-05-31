using System;

public class Workout
{
    //attributes
    protected string _date;
    protected string _type;
    protected int _duration;
    protected float _distance;
    protected float _speed;
    protected float _pace;

// constructor


//methods
protected float GetSpeed()
{
    return (float)Math.Round(_distance / _duration * 60,1);
}
protected float GetPace()
{
    return (float)Math.Round(60 / _speed,1);
}
protected float GetDistance()
{
    return (float)Math.Round(_speed * _duration / 60,1);
}
public virtual void GetSummary()
{

    Console.WriteLine($"{_date} {_type} ({_duration} min) - Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min/km");
}

}