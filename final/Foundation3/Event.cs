using System;

public abstract class Event
{
    //attributes
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    //methods

    public virtual void ShortMessage()
    {
        Console.WriteLine($"Event: {_title}-{_type}\n{_address}");
    }
    public virtual void StandardMessage()
    {
        Console.WriteLine($"Event: {_title}\n{_description}\nDate:{_date} Time:{_time}\n{_address}");
    }
    public abstract void FullMessage();

    
}