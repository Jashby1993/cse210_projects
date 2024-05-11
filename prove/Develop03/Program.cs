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
        string fullPath = @"C:\Users\jashb\Documents\School\cse210_projects\prove\Develop03\scriptures.txt";
        theGoodBook = compileScriptures(fullPath);
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
        Console.Write("To start disappearing words, hit the enter key.");
        Console.ReadLine();

        
        



       
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
}