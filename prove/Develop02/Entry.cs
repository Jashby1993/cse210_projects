using System;
using System.ComponentModel.DataAnnotations;

class Entry
{
    private string _dateTime;
    private string _initialPrompt;
        
    private string _entryText;

    public Entry(string prompt, string entryText, string dateTime)
    {
        _initialPrompt = prompt;
        _entryText = entryText;
        _dateTime = dateTime;
    }

    public void Display()
    {
        Console.WriteLine($"{_initialPrompt}\n{_entryText}\n{_dateTime}");

    }
}