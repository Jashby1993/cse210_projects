using System;
using System.Collections.Generic;
using System.IO;


class PromptGenerator
{
    // defining attributes
    
     public List<string> _prompts = new List<string>();
     
     //constructor
     public PromptGenerator()
     {
        //pulling the prompts from the txt file in same folder
        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        
     }
    public string getRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];   
    }
}
    
