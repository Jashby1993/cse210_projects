using System;
using System.ComponentModel.DataAnnotations;

class Entry
{
    string _dateTime;
    string _initialPrompt;
    //get prompt
    
    string _entryText;
    public Entry()
    {
        //get datetime
    DateTime currentDateTime = DateTime.Now;
    _dateTime = currentDateTime.ToString("MM-dd-yyyy HH:mm:ss");
    //retrieve prompt
    PromptGenerator promptGenerator = new PromptGenerator();
        _initialPrompt = promptGenerator.getRandomPrompt();
    //get entry from user
    Console.WriteLine(_initialPrompt);
    _entryText =Console.ReadLine();
    
    }

     public override string ToString()
    {
        return $"Prompt: {_initialPrompt}\nEntry: {_entryText}\n\nDate: {_dateTime}";
    }

    public void DisplayEntry()
    {
        Console.WriteLine(this.ToString());
    }
}