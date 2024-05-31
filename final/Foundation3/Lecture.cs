using System;

public class Lecture : Event
{
    string _speaker;
    int _capacity;

    public Lecture(string title, string description, string speaker,string date, string time, string address, int capacity)
    {
        _type = "Lecture";
        _title = title;
        _description = description;
        _speaker = speaker;
        _date = date;
        _time = time;
        _address = address;
        _capacity = capacity;
    }

    public override void FullMessage()
    {
        Console.WriteLine($"{_type}\n{_speaker} - {_title}\n{_description}\n{_date} {_time}\n{_address}\n{_capacity}");
    }
}