using System;

public class StationaryBike : Workout
{
    public StationaryBike(string date, int duration, float speed)
    {
        _date = date;
        _duration = duration;
        _speed = speed;
        _distance = GetDistance();
        _pace = GetPace();
    }
}