using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Manager
{
        public List<Goal> GoalList = new List<Goal>();
        public Level playerLevel = new Level();
        public int playerPoints = 0;
        public string fileName;
        public int pointsToAdd;
        bool changeLevelNow = false;

        

    public Manager()
    {
        
    }
    public int DisplayMenu()
    {
        Console.WriteLine("1) Display User Info\n2) New goal\n3) Record Event\n4) Save\n5) Load file\n6) QUIT");
        int userChoice = int.Parse(Console.ReadLine());

        return userChoice;
    }

    public void DisplayUserInfo(List<Goal>GoalList)
    {
        Console.Clear();
        Console.WriteLine($"Player points: {playerPoints}");
        Console.WriteLine(playerLevel.DisplayLevelInfo());
        foreach (Goal goal in GoalList)
        {
            Console.WriteLine(goal.DisplayGoal());

        }
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
            foreach (Goal goal in GoalList)
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
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName); 
        string[] fileInfo = File.ReadAllLines(filePath);
        int playerPoints = int.Parse(fileInfo[0]);
        string playerLevelString = fileInfo[1];
        
        for (int i = 2; i < fileInfo.Count(); i++)
        {
            string goalLine = fileInfo[i];
            Goal newGoal = ParseGoal(goalLine);
            Goals.Add(newGoal);
        }
        Console.WriteLine("File Loaded!");
        return (playerPoints,playerLevelString,Goals);
    }
    public (int levelNumber,string beast, string describer) ParseLevel(string levelDisplay)
    {
        int spaceIndex = levelDisplay.IndexOf(' ');
        int colonIndex = levelDisplay.IndexOf(':');
        int dashIndex = levelDisplay.IndexOf('-');
        int levelNumber = int.Parse(levelDisplay.Substring(spaceIndex + 1, colonIndex- spaceIndex - 1));
        string beast = levelDisplay.Substring(colonIndex + 1, dashIndex - colonIndex - 1);
        string describer = levelDisplay.Substring(dashIndex + 1);
        return (levelNumber,beast,describer);
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
    public void AddPointsAnimation(int pointsToAdd)
    {
        for (int i = 0; i<= pointsToAdd; i++)
        {
            Console.Clear();
            Console.WriteLine($"{playerPoints + i}");
            Thread.Sleep(2);
            i++;
        }
    }
    public void Run()
    {   

        bool Play = true;
        while (Play)
        {
            int userChoice = DisplayMenu();

            switch (userChoice)
            {
                case 1:
                    DisplayUserInfo(GoalList);
                    break;
                case 2:
                    Goal newGoal = CreateGoal();
                    GoalList.Add(newGoal);
                    break;
                case 3:
                    int i = 1;
                    foreach (Goal goal in GoalList)
                    {
                        Console.WriteLine($"{i}){goal.DisplayGoal()}");
                        i++;
                    }
                    int userGoalChoiceIndex = int.Parse(Console.ReadLine()) - 1;
                    pointsToAdd =GoalList[userGoalChoiceIndex].RecordEvent();
                    AddPointsAnimation(pointsToAdd);
                    playerPoints += pointsToAdd;
                    changeLevelNow =playerLevel.CheckLevelChange(playerPoints);
                    if (changeLevelNow)
                    {
                        int playerLevelInt;
                        string beast;
                        string describer;
                        (playerLevelInt, beast, describer) = playerLevel.NewLevel(playerPoints);
                        playerLevel = new Level(playerLevelInt,beast,describer);
                                              
                    }
                    Console.Clear();
                    DisplayUserInfo(GoalList);
                    break;
                case 4:
                    string levelInfo = playerLevel.DisplayLevelInfo();
                    Save(playerPoints,levelInfo,GoalList);
                    Thread.Sleep(3000);
                    Console.Clear();
                    DisplayUserInfo(GoalList);
                    break;
                case 5:
                    string levelString;
                    (playerPoints,levelString,GoalList)=Load();
                    int levelIntParsed;
                    string beastParsed;
                    string describerParsed;
                    (levelIntParsed,beastParsed,describerParsed)= ParseLevel(levelString);
                    playerLevel = new Level(levelIntParsed,beastParsed,describerParsed);
                    Thread.Sleep(2000);
                    Console.Clear();
                    DisplayUserInfo(GoalList);
                    break;
                case 6:
                    Console.WriteLine("Escape Message");
                    Play = false;
                    break;
                default:
                    Console.WriteLine("Not a valid entry, please enter again:");
                    break;
            }
            
        }
    }
}