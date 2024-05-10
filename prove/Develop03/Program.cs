using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<string> theGoodBook = new List<string>();
        theGoodBook = compileScriptures("scriptures.txt");
        Random random = new Random();
        int randomScripture = random.Next(0,theGoodBook.Count);
        (string roughReference, string roughText) = parseScripture(theGoodBook, randomScripture);
        Reference myReference = new Reference(roughReference);
        string[] wordsArray = roughText.Split(' ');
        List<Word> wordList = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            Word word = new Word(wordText);
            wordList.Add(word);
            Scripture myScripture = new Scripture(myReference,roughText);
        }


        
        



       
    }














    public static List<string> compileScriptures(string filename)
    {
        List<string> scriptureMastery = new List<string>();
        
        string[] lines = File.ReadAllLines(filename);
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