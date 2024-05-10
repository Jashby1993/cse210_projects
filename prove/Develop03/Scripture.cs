using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Scripture
{
    Reference _reference;
    List<Word> Words = new List<Word>();

    public Scripture(Reference _reference, string _text)
    {

    }
    
    public static List<Scripture> scriptureMastery = new List<Scripture>();
    string filename = "sciptures.txt";  
    string[] lines = System.IO.ReadAllLines(filename);
    foreach (string line in lines)
    {
        
    }      

}