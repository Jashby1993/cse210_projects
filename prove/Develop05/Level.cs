//don't know if I'll need this, but it might come in handy
using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Level
{
    private int _levelNumber = 1;
    private string _describer;
    private string _beast;

    
    public Level(int levelNumber, string beast, string descriptor)
    {
        _levelNumber = levelNumber;
        _beast = beast;
        _describer = descriptor
    }
    public void SetLevelNumber(int LevelNumber)
    {
        _levelNumber = LevelNumber;
    }
    public int GetLevelNumber ()
    {
        return _levelNumber
    }

    public string DisplayLevelInfo()
    {
        return $"Level {_levelNumber} {_beast} {_describer}"
    }

    public bool CheckLevelChange(int playerPoints)
    {
        
        int measureLevel;
        for (int=1,int<=500,int++)
        {
            if (playerPoints >= (i * 1000))
            {
                measureLevel = int;
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
    public Level NewLevel(int playerPoints)
    {
        
        List<string>beastLines = new List<string>();
        string[] lines = File.ReadAllLines(@'animals.csv');
        foreach (string line in lines)
        {
            beastLines.Add(line);

        }      
        List<string>descripterLines = new List<string>();
        string[] lines = File.ReadAllLines(@'descriptors.csv');
        foreach (string line in lines)
        {
            descriptorLines.Add(line);

        }      
        List<string>tierBeasts = new List<string>();
        List<string>tierDescripters = new List<string>();
        if (_levelNumber<=10)
        {
           string[] beasts = beastLines[0].Split(',')
           foreach (string beast in beasts)
           {
            tierBeasts.Add(beast)
           }
            string[] descriptors =descripterLines[0].Split(',')
           foreach (string descriptor in descriptors)
           {
            tierDescriptors.Add(descriptor)
           }
        }
        else if (_levelNumber > 10 && _levelNumber <= 25)
        {
            string[] beasts = beastLines[1].Split(',')
            foreach (string beast in beasts)
           {
                tierBeasts.Add(beast)
           }
            string[] descriptors =descripterLines[1].Split(',')
           foreach (string descriptor in descriptors)
           {
            tierDescriptors.Add(descriptor)
            }
        }
        else
        {
            string[] beasts = beastLines[1].Split(',')
            foreach (string beast in beasts)
            {
                tierBeasts.Add(beast)
            }
            string[] descriptors =descripterLines[1].Split(',')
            foreach (string descriptor in descriptors)
            {
                tierDescriptors.Add(descriptor)
            }
        }
        Random random = new Random();
        int randomBeast = random.Next(0,tierBeasts.Count-1)
        int randomDescriptor = random.Next(0, tierDescripters.Count-1)
        string levelBeast = tierBeasts[randomBeast];
        string levelDescriptor = tierDescripters[randomDescriptor];
        int playerLevel;

    }
}