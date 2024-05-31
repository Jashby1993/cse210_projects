using System;

public class Outdoor : Event
{ 
    string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
        _type = "Outdoor Event";
    }

      public override void FullMessage()
    {
        Console.WriteLine($"{_type}\n{_title}\n{_description}\n{_date} {_time}\n{_address}\n{_weather}");
    }  
}