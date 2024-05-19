using System;
using System.Globalization;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        int nameChar = _name.Length;
        int consoleWidth = Console.WindowWidth;
        string fillRow = new string('-',consoleWidth);
        string fillSideName = new string('-', ((consoleWidth - nameChar)/2));
        Console.WriteLine($"{fillSideName}{_name}{fillSideName}");
        Console.WriteLine(fillRow);


    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowPauseAnimation(int duration)
    {
        //pull from pauseanimations csv
        string pauseAnimationsFile = "pauseanimations.csv";
        List<string> animations = new List<string>();
        string[] lines = File.ReadAllLines(pauseAnimationsFile);
        //parse into a strings list
        foreach (string line in lines)
        {
            animations.Add(line);
        }
        //picking a random animation
        Random random = new Random();
        int randomAnimationIndex =  random.Next(0,animations.Count);
        string[] animationStrings = animations[randomAnimationIndex].Split(",");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(350);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Length)
            {
                i = 0;
            }
        }




    }

    public void ShowCountDown(int duration)
    {
       for (int i = duration; i > 0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       } 
    }
}   
