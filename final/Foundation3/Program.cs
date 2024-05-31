using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture event1 = new Lecture ("Programming with Classes","An in depth look into the benefits of programming with classes.","Alan Turing","May 24, 2024","7pm","BYU Marion Center",650);
        Outdoor event2 = new Outdoor("Jack Johnson Live","Jack Johnson performs at the legendary Red Rock natural ampitheater!","May 31,2024","8:30 pm","100 Red Rock Court, South Denver, CO","Slight chance of rain, come prepared!");
        Reception event3 = new Reception("Josh and Katie's Wedding Reception","Josh and Katie are tying the knot!","June 1, 2024","4:30 pm","123 County Park Way","Please sned RSVP to joshandkatie@yahoo.com.");

        List<Event> eventPlanner = new List<Event>();
        eventPlanner.Add(event1);
        eventPlanner.Add(event2);
        eventPlanner.Add(event3);
        foreach (Event day in eventPlanner)
        {
            day.ShortMessage();
            day.StandardMessage();
            day.FullMessage();
        }
    }
}