using System;
using System.Collections.Generic;

public class Manager
{
        public List<Goal> goals = new List<Goal>();
        Level playerLevel = new Level();
        public int playerPoints = 0;
        public string fileName;

        


    public int DisplayMenu()
    {
        Console.WriteLine("1) Display User Info\n2) New goal\n3) Record Event\n4) Save\n 5) Load file\n6) QUIT");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }


    public Goal CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to add?\n1)One time goal (One time completion)\n2)Step Goal (same activity multiple times)\n3)Eternal Goal (Never 'done'.)");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("What is a simple name for your goal? ");
        string name = Console.Readline();
        Console.WriteLine("Please give a simple but sufficiently detailed description of your goal: ");
        description = Console.ReadLine();
        Console.WriteLine("How many points is full completion of this goal worth?");
        pointValue = int.Parse(Console.ReadLine());
        


        switch (goalType)
        {
            
            case 1:

                pointValue = int.Parse(Console.ReadLine());
                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, pointValue);
                return newSimpleGoal;
            
            case 2:
                Console.WriteLine("What is a simple name for your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("Please give a simple but sufficiently detailed description of your goal: ");
                description = Console.ReadLine();
                Console.WriteLine("How many times will you do this goal until it is fully completed?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points is completion of each step this goal worth?");
                stepPointValue = int.Parse(Console.ReadLine());
                
                StepGoal newStepGoal = new StepGoal(name,description, stepPointValue,target,pointValue);
                return newStepGoal;
            case 3:
                EternalGoal newEternalGoal = new EternalGoal(name, description,pointValue);
                return newEternalGoal;
        }
        
    }

    public void RecordEvent()
    {

    }
    public void Save(int playerPoints, string LevelDisplay, List<Goal> GoalList)
    {
        Console.WriteLine("What is the filename? Please do NOT include .fileformat at the end, I'll take care of that!\n");
        string userName = Console.ReadLine();
        fileName = $"{userName}.txt";
        string filePath = $"'@'"{fileName}""
        using (StreamWriter fileSaver = new StreamWriter(filePath,false))
        {
            fileSaver.WriteLine(playerPoints);
            fileSaver.WriteLine(playerLevel.DisplayLevelInfo());
            foreach (Goal goal in goals)
            {
                fileSaver.WriteLine(Goal.DisplayGoal());
            }
        }
        Console.WriteLine("File Saved!");

    }
    public int playerPoints string playerLevel List<Goal> Load()
    {
        Console.Write("What is the filename you would like to load? Exclude .txt at the end. ");
        string userEntry = Console.ReadLine();
        fileName = $"{userEntry}.txt";
        string filePath = $"'@'"{fileName}"";
        string[] fileInfo = File.ReadAllLines(filePath);
        int playerPoints = fileInfo[0];
        string playerLevel = fileInfo[1];
        

    }
    public void Run()
    {
        int userChoice = DisplayMenu();
        bool Play = true;
        List<goals> GoalList = new List<global>();
        Console.WriteLine("Do you have a save file you would like to load? Y or N ")
        string userStart=Console.ReadLine()
        if (userStart == "Y")
        {

        }
        else
        {

        }


        while (Play)
        {
            switch (userChoice)
            {
                case 1:
                    DisplayUserInfo();
                    break;
                case 2:
                    Goal newGoal = CreateGoal();
                    goals.Add(newGoal);
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    saveFile(filename);
                    break;
                case 5:
                    loadFile(filename);
                    break;
                case 6:
                    Console.WriteLine("Escape Message");
                    Play = false;
                    break;
            }
        }
    }
}