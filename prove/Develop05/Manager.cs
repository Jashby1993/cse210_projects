using System;
using System.Collections.Generic;

public class Manager
{
        public List<Goal> goals = new List<Goal>();
        Level playerLevel;
        public int playerPoints = 0;
        public string fileName;

        


    public int DisplayMenu()
    {
        Console.WriteLine("1) Display User Info\n2) New goal\n3) Record Event\n4) Save\n 5) Load file\n6) QUIT");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Player points: {playerPoints}");
        Console.WriteLine(Level.Disp)
    }


    public Goal CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to add?\n1)One time goal (One time completion)\n2)Step Goal (same activity multiple times)\n3)Eternal Goal (Never 'done'.)");
        int goalType = int.Parse(Console.ReadLine());
        Console.WriteLine("What is a simple name for your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Please give a simple but sufficiently detailed description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is full completion of this goal worth?");
        int pointValue = int.Parse(Console.ReadLine());
        


        switch (goalType)
        {
            
            case 1:

                pointValue = int.Parse(Console.ReadLine());
                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, pointValue);
                return newSimpleGoal;
                
            
            case 2:

                Console.WriteLine("How many times will you do this goal until it is fully completed?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many points is completion of each step this goal worth?");
                int stepPointValue = int.Parse(Console.ReadLine());
                
                StepGoal newStepGoal = new StepGoal(name,description, stepPointValue,target,pointValue);
                return newStepGoal;
            case 3:
                EternalGoal newEternalGoal = new EternalGoal(name, description,pointValue);
                return newEternalGoal;
            default: 
                throw new ArgumentException("Invalid entry");
                
        }
        
    }

    public void RecordEvent()
    {

    }
    public void Save(int playerPoints, string LevelDisplay, List<Goal> GoalList)
    {
        Console.WriteLine("What is the filename? Please do NOT include .fileformat at the end, I'll take care of that!\n");
        string userName = Console.ReadLine();
        string fileName = $"{userName}.txt";  // Correct file name construction
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);  // Properly combine paths

        using (StreamWriter fileSaver = new StreamWriter(filePath, false))
        {
            fileSaver.WriteLine(playerPoints);
            fileSaver.WriteLine(LevelDisplay);  // Assuming levelDisplay contains the display info
            foreach (Goal goal in goals)
            {
                fileSaver.WriteLine(goal.DisplayGoal());  // Write each goal's info
            }
        }
        Console.WriteLine("File Saved!");
    }
    public (int, string, List<Goal>) Load()
    {
        List<Goal>Goals = new List<Goal>();
        Console.Write("What is the filename you would like to load? Exclude .txt at the end. ");
        string userEntry = Console.ReadLine();
        fileName = $"{userEntry}.txt";        
        string[] fileInfo = File.ReadAllLines(fileName);
        int playerPoints = int.Parse(fileInfo[0]);
        string playerLevel = fileInfo[1];
        for (int i = 2; i < fileInfo.Count(); i++)
        {
            string goalLine = fileInfo[i];
            Goal newGoal = ParseGoal(goalLine);
            Goals.Add(newGoal);
        }
        return (playerPoints,playerLevel,Goals);
    }
    public Goal ParseGoal(string goalLine)
    {
        if (goalLine.Contains("Eternal"))
        {
            int doubleDashIndex = goalLine.IndexOf("--"); 
            int colonIndex = goalLine.IndexOf(':');
            int pipeIndex = goalLine.IndexOf('|');
            string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
            string descriptor = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
            int intPoints = int.Parse(goalLine.Substring(pipeIndex + 1));
            EternalGoal newGoal = new EternalGoal(name, descriptor,intPoints);
            return newGoal;
        }
        else if (goalLine.Contains("Simple"))
        {
            bool isComplete = false;
            int openBracketIndex = goalLine.IndexOf('[');
            char completionFlag = goalLine[openBracketIndex + 1];
            if (completionFlag == 'x')
            {
                isComplete = true;
                
            }
            else if (completionFlag == ' ')
            {
                isComplete = false;
            }
            int doubleDashIndex = goalLine.IndexOf("--"); 
            int colonIndex = goalLine.IndexOf(':');
            int pipeIndex = goalLine.IndexOf('|');
            string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
            string descriptor = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
            int intPoints = int.Parse(goalLine.Substring(pipeIndex + 1));
            SimpleGoal newGoal = new SimpleGoal(isComplete,name,descriptor,intPoints);
            return newGoal;
            }
            else if (goalLine.Contains("Step"))
            {
                bool isComplete = false;
        int openBracketIndex = goalLine.IndexOf('[');
        char completionFlag = goalLine[openBracketIndex + 1];
        if (completionFlag == 'x')
        {
            isComplete = true;
            
        }
        else if (completionFlag == ' ')
        {
            isComplete = false;
        }
        int doubleDashIndex = goalLine.IndexOf("--"); 
        int colonIndex = goalLine.IndexOf(':');
        int pipeIndex = goalLine.IndexOf('|');
        int openParenthesisIndex = goalLine.IndexOf('(');
        int ofIndex = goalLine.IndexOf("of");
        int closeParenthesisIndex = goalLine.IndexOf(')');
        string name = goalLine.Substring(doubleDashIndex+2,colonIndex - doubleDashIndex - 2);
        string description = goalLine.Substring(colonIndex +1, pipeIndex - colonIndex - 1);
        int fullCompletePoints = int.Parse(goalLine.Substring(pipeIndex + 1, openParenthesisIndex - pipeIndex - 1));
        int stepsCompleted = int.Parse(goalLine.Substring(openParenthesisIndex + 1, ofIndex - openParenthesisIndex - 1));
        int totalSteps = int.Parse(goalLine.Substring(ofIndex + 2, closeParenthesisIndex - ofIndex - 2));
        int stepPoints = int.Parse(goalLine.Substring(closeParenthesisIndex + 1));
        StepGoal newGoal = new StepGoal(isComplete,name,description,fullCompletePoints,stepsCompleted,totalSteps,stepPoints);
        return newGoal;
        }
        else
        {
            Console.WriteLine("Error Message");
            return null;
        }
    }
    public void Run()
    {   
        string userStart;
        int userChoice = DisplayMenu();
        bool Play = true;
        List<Goal> GoalList = new List<Goal>();
        Console.WriteLine("Do you have a save file you would like to load? Y or N ");
        userStart = Console.ReadLine();
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
                    string levelInfo = playerLevel.DisplayLevelInfo();
                    Save(playerPoints,levelInfo,goals);
                    break;
                case 5:
                    Load();
                    break;
                case 6:
                    Console.WriteLine("Escape Message");
                    Play = false;
                    break;
            }
        }
    }
}