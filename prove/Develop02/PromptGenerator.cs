using System;
using System.Collections.Generic;


class PromptGenerator
{
    // defining attributes
    
     public List<string> _prompts = new List<string>();
     
     //constructor
     public PromptGenerator()
     {
        //pulling the prompts from the txt file in same folder
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "prompts.txt");
        string[] lines = File.ReadAllLines(filePath);
        _prompts.AddRange(lines);
     }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];   
    }
}
    
