using System;

class Word
{
    private string _text;
    private string _originalText;
    private bool _isHidden;


    public Word(string text, bool isHidden = false )
{
    _text = text;
    _originalText = text;
    _isHidden = isHidden; 
}

    
    public void Hide()
    {
        _isHidden = true;
        _text = "_____";
    
    }
    public void Show()
    {
        _isHidden = false;
        _text = _originalText;
        
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {   
        string displayText;
        if (_isHidden)
        {
        displayText = "_____";
        }
        else
        {
            displayText = " " + _text;
        }
        return displayText;
    
    }
}