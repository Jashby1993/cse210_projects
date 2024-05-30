using System;
using System.Collections.Generic;

public class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string userName, string commentText)
    {
        _userName = userName;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"User:{_userName}\nComment-\n{_commentText}");
    }
}