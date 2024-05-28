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
            for (int i = 1; i <= 500; i++)
            {
                if (playerPoints >= (i * 1000))
                {
                    levelNumber = i;
                }
            }
        }

        List<string> beastLines = new List<string>(File.ReadAllLines("animals.csv"));
        List<string> descriptorLines = new List<string>(File.ReadAllLines("descriptors.csv"));

        List<string> tierBeasts = new List<string>();
        List<string> tierDescriptors = new List<string>();

        if (levelNumber <= 10)
        {
            string[] beasts = beastLines[0].Split(',');
            tierBeasts.AddRange(beasts);

            string[] descriptors = descriptorLines[0].Split(',');
            tierDescriptors.AddRange(descriptors);
        }
        else if (levelNumber > 10 && levelNumber <= 25)
        {
            string[] beasts = beastLines[1].Split(',');
            tierBeasts.AddRange(beasts);

            string[] descriptors = descriptorLines[1].Split(',');
            tierDescriptors.AddRange(descriptors);
        }
        else
        {
            string[] beasts = beastLines[2].Split(',');
            tierBeasts.AddRange(beasts);

            string[] descriptors = descriptorLines[2].Split(',');
            tierDescriptors.AddRange(descriptors);
        }

        Random random = new Random();
        int randomBeastIndex = random.Next(0, tierBeasts.Count);
        int randomDescriptorIndex = random.Next(0, tierDescriptors.Count);

        string levelBeast = tierBeasts[randomBeastIndex];
        string levelDescriptor = tierDescriptors[randomDescriptorIndex];

        return (levelNumber, levelBeast, levelDescriptor);
    }

}