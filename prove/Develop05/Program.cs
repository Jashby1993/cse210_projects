using System;

class Program
{
    static void Main(string[] args)
    {
        Manager startManager = new Manager();
        startManager.Run();
        Console.WriteLine("Goodbye!");
    }
}