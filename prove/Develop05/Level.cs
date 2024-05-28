using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

public class Level
{
    private int _levelNumber = 1;
    private string _describer;
    private string _beast;
    public Level()
    {
        (_levelNumber,_beast,_describer) = NewLevel(0);
    }

    
    public Level(int levelNumber, string beast, string descriptor)
    {
        _levelNumber = levelNumber;
        _beast = beast;
        _describer = descriptor;
    }
    public void SetLevelNumber(int LevelNumber)
    {
        _levelNumber = LevelNumber;
    }
    public int GetLevelNumber ()
    {
        return _levelNumber;
    }

    public string DisplayLevelInfo()
    {
        return $"Level {_levelNumber}:{_beast}-{_describer}";
    }

    public bool CheckLevelChange(int playerPoints)
    {
            
        int measureLevel= _levelNumber;
        for (int i=1;i <=500;i++)
        {
            if (playerPoints >= (i * 1000))
            {
                measureLevel = i;
                
            }
        }
        if (measureLevel > _levelNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public (int LevelNumber, string beast, string descriptor) NewLevel(int playerPoints)
    {
        int levelNumber = 1;

        if (playerPoints > 1000)
        {
            for (int i =1; i<=500;i++)
            {
                if (playerPoints >= (i*1000))
                {
                    levelNumber = i;
                }
            }
        }
        List<string>beastLines = new List<string>();
        string[] lines = File.ReadAllLines("@'animals.csv'");
        foreach (string line in lines)
        {
            beastLines.Add(line);

        }      
        List<string>descriptorLines = new List<string>();
        string[] descriptors = File.ReadAllLines("@'descriptors.csv");
        foreach (string line in descriptors)
        {
            descriptorLines.Add(line);

        }      
        List<string>tierBeasts = new List<string>();
        List<string>tierDescripters = new List<string>();
        if (_levelNumber<=10)
        {
           string[] beasts = beastLines[0].Split(',');
           foreach (string beast in beasts)
           {
            tierBeasts.Add(beast);
           }
            string[] fullDescripterLine =descriptorLines[0].Split(',');
           foreach (string descriptor in descriptors)
           {
            tierDescripters.Add(descriptor);
           }
        }
        else if (_levelNumber > 10 && _levelNumber <= 25)
        {
            string[] beasts = beastLines[1].Split(',');
            foreach (string beast in beasts)
           {
                tierBeasts.Add(beast);
           }
            string[] tier2descriptors =descriptorLines[1].Split(',');
           foreach (string descriptor in descriptors)
           {
            tierDescripters.Add(descriptor);
            }
        }
        else
        {
            string[] beasts = beastLines[1].Split(',');
            foreach (string beast in beasts)
            {
                tierBeasts.Add(beast);
            }
            string[] tier3descriptors =descriptorLines[1].Split(',');
            foreach (string descriptor in descriptors)
            {
                tierDescripters.Add(descriptor);
            }
        }
        Random random = new Random();
        int randomBeast = random.Next(0,tierBeasts.Count-1);
        int randomDescriptor = random.Next(0, tierDescripters.Count-1);
        string levelBeast = tierBeasts[randomBeast];
        string levelDescriptor = tierDescripters[randomDescriptor];
        
        return (levelNumber,levelBeast,levelDescriptor);
        }
}