//stretch: Having the scripture list pull from txt file. Reads specific key presses to do different things. Enter to hide text. Spacebar to add a new scripture to the list.
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //start by always clearing the console
        Console.Clear();
        //pull the list of scriptures
        List<string> theGoodBook = new List<string>();
        string filePath = @"..\..\..\scriptures.txt";
        theGoodBook = compileScriptures(filePath);
        //pick a random scripture
        Random random = new Random();
        int randomScripture = random.Next(0,theGoodBook.Count);
        //get raw data, and split the reference and text
        (string roughReference, string roughText) = parseScripture(theGoodBook, randomScripture);
        //create the reference
        Reference myReference = new Reference(roughReference);
        //create the text
        string[] wordsArray = roughText.Split(' ');
        //create the lest of Word objects, and populate
        List<Word> scriptureText = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            Word Word = new Word(wordText);
            scriptureText.Add(Word);          
        }
        //create the Scripture Object
        Scripture focusScripture = new Scripture(myReference,scriptureText);
        //Call the full scripture
        Console.WriteLine(focusScripture.GetDisplayText());
        Console.WriteLine("To disappear words, hit the enter key.\nTo add a new scripture, hit the spacebar.");
        bool memorized = focusScripture.isCompletelyHidden();
        
    
        while (!memorized)
        {
        // Continuously read key presses
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
                
                // Check which key was pressed
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    
                    int numberToHide = random.Next(1,5);
                    focusScripture.HideRandomWords(numberToHide); 
                    Console.Clear();
                    Console.WriteLine(focusScripture.GetDisplayText());
                    Console.WriteLine("To disappear words, hit the enter key.");
                    if (focusScripture.isCompletelyHidden())
                    {
                        memorized = true;
                        break;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    addToScripture(filePath);
                }
            }
        }
        Console.WriteLine("Congratulations, you've memorized the scripture");

        
        



       
    }














    public static List<string> compileScriptures(string filePath)
    {
        List<string> scriptureMastery = new List<string>();

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            scriptureMastery.Add(line);

        }      
        return scriptureMastery;
    }
    public static (string,string) parseScripture(List<string> scriptureMastery,int scriptureLine)
    {
        
        string[] parts = scriptureMastery[scriptureLine].Split("|");
        string reference = parts[0];
        string text= parts[1];
        
        return (reference, text);
    }

        public static void addToScripture(string filePath)
    {
        string newScripture;
        Console.WriteLine("Please type in the scripture in the following format: Book Chapter: StartVerse - EndVerse | ScriptureText");
        newScripture = Console.ReadLine();
        using (StreamWriter s = File.AppendText(filePath))
        {
            
            s.WriteLine(newScripture);

        }
        Console.WriteLine("That scripture has been added to the list.");
    }
}