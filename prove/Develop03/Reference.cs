using System;


class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endingVerse;
    private string _reference;

    // instead of inputing the individual items, using the roughReference as a parameter, parsing, and making that change
    public Reference(string roughReference)
    {
        //removing the spaces to simplify
        string simpleReference = roughReference.Replace(" ","");
        //getting the book name. it will remove the space between the number and book name, but I don't thing this affects readability.
        int bookEndIndex = 0;
        for (int i=0; i < simpleReference.Length; i++)
        {
            if (char.IsDigit(simpleReference[i]) && (i == 0 || !char.IsDigit(simpleReference[i - 1])))
            {
                bookEndIndex = i;
                break;
            }
        }
        //book name
        _book = simpleReference.Substring(0, bookEndIndex);
        
        //getting chapter number
        int colonIndex = simpleReference.IndexOf(':');
        string chapterString = simpleReference.Substring(_book.Length, colonIndex - _book.Length);
        //chapter number
        _chapter = int.Parse(chapterString);
        //testing if there's one verse or multiple verses
        bool multipleVerses = simpleReference.Contains("-");

        if (!multipleVerses)
        {
            _verse = int.Parse(simpleReference.Substring(colonIndex + 1));
            _reference = $"{_book} {_chapter} : {_verse} -- ";
        }
        else
        {
            int dashIndex = simpleReference.IndexOf("-");
            _verse = int.Parse(simpleReference.Substring(colonIndex + 1, dashIndex - colonIndex - 1));
            _endingVerse = int.Parse(simpleReference.Substring(dashIndex + 1));
            _reference = $"{_book} {_chapter} : {_verse} - {_endingVerse} --";
        }


    }


  //public Reference(string book, int chapter, int verse)
  //{
  //    _book = book;
  //    _chapter = chapter;
  //    _verse = verse;
  //    string _reference = $"{book} {chapter} : {verse} -- ";
  //}
  //public Reference (string book, int chapter, int startingVerse, int endingVerse)
  //{
  //    _book = book;
  //    _chapter = chapter; 
  //    _verse = startingVerse;
  //    _endingVerse = endingVerse;

  //    string _reference = $"{_book} {_chapter} : {_verse} - {_endingVerse} --";
  //}

    
    public string GetDisplayText()
    {
        return $"{_reference}";
    }
}