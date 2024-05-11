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

//constructor
    public Scripture(Reference reference, List<Word> words)
    {
       _reference = reference;
       _words = words;     

    }
    //first display
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            scriptureText += " " + word.ToString();
        }
        return scriptureText;
    }
    
    

    

}

