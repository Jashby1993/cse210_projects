using System;

public class Reception : Event
{
    string _rsvpEmail;

        public Reception(string title, string description, string date, string time, string address, string rsvpEmail)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _rsvpEmail = rsvpEmail;
        _type = "Reception";
    }
          public override void FullMessage()
    {
        Console.WriteLine($"{_type}\n{_title}\n{_description}\n{_date} {_time}\n{_address}\n{_rsvpEmail}");
    } 
}