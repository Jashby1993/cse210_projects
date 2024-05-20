using System;
using System.IO;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "In this activity, you will be doing guided breathing. 4 seconds in, 3 seconds hold, 5 seconds out, then in again.\nBe in a comfortable, relaxed position, and focus only on your breathing.";


    }
    public void Run()
    {
        _duration = DisplayStartingMessage();
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);

        while (now < end)
        {
            Console.Write($"Breathe IN...");
            ShowCountDown(4);
            Console.WriteLine(' ');
            Console.Write("And HOLD...");
            ShowCountDown(3);
            Console.WriteLine(' ');
            Console.Write("And breathe OUT...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
        ShowPauseAnimation(10);
    }
}