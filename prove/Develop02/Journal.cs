using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> Entries = new List<Entry>();
    int menuChoice;

    
    public int DisplayMenu()
    {
        string userSelection;
        Console.WriteLine("What would you like to do? Please enter the number of your choice:");
        Console.WriteLine("1. Get a prompt and enter a new journal entry.");
        Console.WriteLine("2. Display the entire journal.");
        Console.WriteLine("3. Save journal to a file.");
        Console.WriteLine("4. Load a journal from a file.");
        Console.WriteLine("5. Quit");
        userSelection = Console.ReadLine();
        menuChoice = int.Parse(userSelection);
        return menuChoice;
    }
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void saveToFile()
    {
        Console.Write("What is the name of the file? Please exclude the ending (.txt or .csv)");
        string fileName = Console.ReadLine();
        fileName = (fileName + ".txt");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine(entry.ToString()); // Assuming you have overridden ToString method in Entry class
            }
        }

        Console.WriteLine("Journal saved to file: " + fileName);
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
