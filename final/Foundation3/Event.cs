using System;

public abstract class Event
{
    //attributes
    string _type;
    string _title;
    string _description;
    string _date;
    string _time;
    string _address;

    //methods

    protected abstract void ShortMessage();
    protected abstract void StandardMessage();
    protected abstract void FullMessage();

    
}