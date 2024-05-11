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
        Random random = new Random();
        List<int> indicesToHide = new List<int>();
        while (indicesToHide.Count < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            if (!indicesToHide.Contains(randomIndex))
            {
                indicesToHide.Add(randomIndex);
            }
        }
        foreach (int index in indicesToHide)
        {
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                _hiddenWordCount++;
            }
        }

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

