using System;

class Word
{
private string _text;
private bool _isHidden;

public Word(string text, bool isHidden)
{
    this._text = text;
    this._isHidden = isHidden;

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