using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> Entries = new List<Entry>();
    

    

    public void AddEntry(string prompt, string dateTime)
    {
        Console.WriteLine(prompt);
        string entryText = Console.ReadLine();
        Entry newEntry = new Entry(prompt, entryText, dateTime);
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }
    public void saveToFile(string fileName)
    {
        
        using(StreamWriter newJournal = new StreamWriter (fileName))
        {
            foreach (Entry entry in Entries)
            {
                var attributes =entry.giveAttribute();
                
                newJournal.WriteLine($"{attributes.prompt}\n{attributes.entry}\n{attributes.dateTime}");
            }
        }
    }

    public void loadFile(string fileName)
    {
        //asking for the filename
        

        List<string> fileContents = new List<string>();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {   
                fileContents.Add(line);
                
            }
        }

    }
}
