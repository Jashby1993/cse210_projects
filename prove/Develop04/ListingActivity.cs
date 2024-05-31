using System;
using System.Runtime.CompilerServices;
using System.IO;

class ListingActivity : Activity

{ 
    List <string> prompts = new List<string>();
    List<string> userEntry = new List<string>();
   

    public ListingActivity()
    {_name = "Listing";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    }
    public void Run()
    {
        populateListingPrompt(prompts);
        _duration = DisplayStartingMessage();
        string prompt = GetRandomListingPrompt(prompts);
        DisplayListingPrompt(prompt);
        DateTime now = DateTime.Now;
        DateTime end =now.AddSeconds(_duration);
        while (now < end)
        {
            string newEntry = Console.ReadLine();
            userEntry.Add(newEntry);
            now = DateTime.Now;
        }
        Console.WriteLine($"Excellent! In {_duration} seconds, you were able to list {userEntry.Count} answers!");
        DisplayEndingMessage();


    }
    private string GetRandomListingPrompt( List<string> prompts)
    {
        Random random = new Random();
        int randomPrompt = random.Next(0,prompts.Count);
        string mindfulnessPrompt = prompts[randomPrompt];
        return mindfulnessPrompt;
    }
    private void DisplayListingPrompt(string prompt)
    {
        int consoleWidth = Console.WindowWidth;
        int promptCharacters = prompt.Length;
        string fillRow = new string ('-', consoleWidth);
        string fillSide = new string(' ', ((consoleWidth - promptCharacters)/2));
        Console.WriteLine(fillRow);
        Console.WriteLine($"{fillSide}{prompt}{fillSide}");
        Console.WriteLine(fillRow);       
    }

    public int listUserEntry(List<string>userEntry)
    {
        int count = 0;
        return count;
    }

    private void populateListingPrompt(List<string> prompts)
    {
        string filePath = @"listing_prompts.txt";
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            prompts.Add(line);

        } 
    }
}