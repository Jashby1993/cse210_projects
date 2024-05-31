using System;

class Program
{
    static void Main(string[] args)
    {
        Running workout1 = new Running("May 24, 2024",75, 6.1F);
        StationaryBike workout2 = new StationaryBike("May 25, 2024",35, 8.1F);
        Swim workout3 = new Swim("May 26, 2024", 45, 12);

        List<Workout> exerciseLog = new List<Workout>();
        exerciseLog.Add(workout1);
        exerciseLog.Add(workout2);
        exerciseLog.Add(workout3);

        foreach (Workout session in exerciseLog)
        {
            session.GetSummary();
        }
    }
}