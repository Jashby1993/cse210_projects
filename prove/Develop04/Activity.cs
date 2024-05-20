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
    protected int DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have selected the {_name} activity.\n{_description}\nPlease enter the number of seconds you would like to set aside for this activity: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Your activity will start in 10 seconds.");
        int sideSpace = (Console.WindowWidth-1)/2;
        string blankSpace = new string(' ',sideSpace);
        Console.Write(sideSpace);
        ShowPauseAnimation(10);
        return duration;
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations, you have done {_duration} seconds of the {_name} activity.\nConsistent practice of mindfulness exercises like this one have been shown\nto dramatically increase mental health.");
        Console.Write("That being said, it can also be helpful to track emotional states over time. Would you like to take just a few more seconds to write down\na few words, like important thoughts or general emotional state after completing the exercise?\nY or N: ");
        string optForExtra = Console.ReadLine();
        if (optForExtra == "Y")
        {
            ExtraThoughts();
        }
        else
        {
            Console.WriteLine("That's ok, maybe next time!");
        }
    }
    protected void ShowPauseAnimation(int duration)
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

    protected void ShowCountDown(int duration)
    {
       for (int i = duration; i > 0; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       } 
    }

    protected void ExtraThoughts()
    {
        Console.WriteLine("Perfect! Just take a couple seconds to write down... Whatever you want!\nThere is no right or wrong. You could write down some thought that felt important, or just some emotions you are feeling.");
        string extraThoughts = Console.ReadLine();
        DateTime now = DateTime.Now;
        string entryDateTime = now.ToString("MM/dd/yyyy HH:mm");
        using(StreamWriter mindfulnessJournal = new StreamWriter ("mindfulnessjournal.txt",true))
        {
            mindfulnessJournal.WriteLine(_name);
            mindfulnessJournal.WriteLine(extraThoughts);
            mindfulnessJournal.WriteLine($"{entryDateTime}");
            mindfulnessJournal.WriteLine(" ");
        }
    }
}   
