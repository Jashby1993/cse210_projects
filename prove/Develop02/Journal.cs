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
    public void saveToFile()
    {
        Console.Write("What is the name of the file? Please exclude the ending (.txt or .csv)");
        string fileName = Console.ReadLine();
        fileName = (fileName + ".txt");
        using(StreamWriter outputFile = new StreamWriter (fileName))
        {
            //this is where I stopped because brain stopped working. Need to tell program to write each entry into a text file. And make sure that prompt, text, and dateTime stay in separate lines.
        }
    }

    public void loadFile()
    {
        //asking for the filename
        Console.Write("What is the name of the file? It must be a txt file. Please exclude the ending (.txt)");
        string fileName = Console.ReadLine();
        fileName = (fileName + ".txt");

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
