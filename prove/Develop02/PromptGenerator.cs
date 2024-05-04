using System;
using System.Collections.Generic;
using System.IO;


class PromptGenerator
{
    // defining attributes
    
     List<string> _prompts = new List<string>()
{
    "What conversation had the biggest impact on you today?",
    "What made you smile today, and why was it special?",
    "Did you experience something new today? What was it, and what did you learn?",
    "What task did you accomplish today that you’re proud of?",
    "Describe a moment from today when you felt confident.",
    "Was there a moment today when you felt challenged? How did you handle it?",
    "What was the most peaceful part of your day?",
    "Did you notice any particular feelings repeatedly surfacing today? What might they indicate?",
    "What was your main stressor today? Do you see a pattern in what typically stresses you?",
    "Who did you interact with today and how did those interactions make you feel?",
    "Did you overhear something today that made you think? What was it?",
    "What was the best thing you ate today? Why did you enjoy it?",
    "How much time did you spend outdoors today? How did that affect your mood?",
    "Did you do something kind for someone else today? What was it, and how did it make you feel?",
    "What was the hardest decision you had to make today, and why was it difficult?",
    "Describe how you felt this morning. Did your mood change throughout the day?",
    "What did you read today, and what was your takeaway?",
    "Did you learn something interesting about someone else today? What was it?",
    "How did you care for your physical health today?",
    "What are you looking forward to tomorrow?",
    "Is there something you wish you had done differently today?",
    "How much screen time did you have today, and do you feel it was too much, too little, or just right?",
    "Did anything surprise you today?",
    "How did you take a break today?",
    "What music did you listen to today, and how did it affect your emotions?",
    "Was there a point in the day when you felt bored? What triggered it?",
    "Did you help solve a problem today? What was it, and how did you feel about your contribution?",
    "What time of day do you feel most productive, and was today typical?",
    "Did you take any photos today? What did you capture, and why?",
    "Reflect on your last conversation of the day. How did it end your day on a positive note or otherwise?"
};
     
     //constructor
     public PromptGenerator()
     {
        //pulling the prompts from the txt file in same folder
        //string filename = "prompts.txt";
        //string[] lines = System.IO.File.ReadAllLines(filename);
        //foreach (string line in lines)
        //{
        //    _prompts.Add(line);
        //}
        
     }
    public string getRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];   
    }
}
    
