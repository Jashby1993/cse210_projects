using System;

class Word
{
private string _text;

    private bool _isHidden;


    public Word(string text, bool isHidden = false )
{
    _text = text;
    _isHidden = isHidden;
        

}

    public override string ToString()
    {
        return _text;
    }
    public void Hide()
{
    if (_isHidden == true)
    {
        _text = "_____";
    }
}
public void Show()
{
    if (_isHidden == false)
    {
        
    }
}
public bool IsHidden()
{
    return false;
}
public string GetDisplayText()
{
    return "";
}
}