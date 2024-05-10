using System;


class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endingVerse;
    private string _reference;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        string _reference = $"{book} {chapter} : {verse} -- ";
    }
    public Reference (string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter; 
        _verse = startingVerse;
        _endingVerse = endingVerse;

        string _reference = $"{_book} {_chapter} : {_verse} - {_endingVerse} --";
    }
    public string GetDisplayText()
    {
        return $"{_reference}";
    }
}