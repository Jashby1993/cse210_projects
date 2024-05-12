using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

class Scripture

{
    //attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _hiddenWordCount;

//constructor
    public Scripture(Reference reference, List<Word> words)
    {
       _reference = reference;
       _words = words; 
       _hiddenWordCount = 0;    

    }
    //first display
    public string GetDisplayText()
    {
        string fullScripture = _reference.GetDisplayText();
        

        foreach (Word word in _words)
        {
            fullScripture += word.GetDisplayText();
        }
        
        return fullScripture;
    }

    public void HideRandomWords(int numberToHide)
    {
        //to generate randome numbers
        Random random = new Random();
        //initializing list of integers to be hidden
        List<int> indicesToHide = new List<int>();
        //initializing list of possible indices of words to hide, to not get repeat numbers
        List<int> availableIndices = new List<int>();
        //populating the possible options of indices
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }
        // found the Fisher-Yates shuffle on overstack, and I wanted to see if I could make it work in this program. I kept running into issues
        // where I couldn't keep track of which words were being removed, so I'm trying it this way
        int n =availableIndices.Count;
        while (n>1)
        {
            n--;
            int k = random.Next(n+1);
            int value = availableIndices[k];
            availableIndices[k] = availableIndices[n];
            availableIndices[n] = value;
        }
        for (int i = 0; i < Math.Min(numberToHide, availableIndices.Count); i++)
        {
            _words[availableIndices[i]].Hide();
            _hiddenWordCount++;
        }
        //this didn't work, trying something else up there ^^
       //while (indicesToHide.Count < numberToHide)
       //{
       //    int randomIndex = random.Next(_words.Count);
       //    if (!indicesToHide.Contains(randomIndex))
       //    {
       //        indicesToHide.Add(randomIndex);
       //    }
       //}
       //foreach (int index in indicesToHide)
       //{
       //    if (!_words[index].IsHidden())
       //    {
       //        _words[index].Hide();
       //        _hiddenWordCount++;
       //    }
       //}

    }

    public bool isCompletelyHidden()
    {
        if (_hiddenWordCount == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    

    

}

