using System;
using System.Collections.Generic;

public class Video
{
    string _title;
    string _author;
    string _length;
    string _summary;
    List<Comment> CommentsSection;

    public Video (
        string title, 
        string author, 
        string length, 
        string summary)
    {
        _title = title;
        _author = author;
        _length = length;
        _summary = summary;
        CommentsSection = new List<Comment>();
    }
    public void AddComment()
    {
        Console.Write("What is your username? ");
        string userName = Console.ReadLine();
        Console.Write("Comment: ");
        string commentText = Console.ReadLine();
        Comment uploadComment = new Comment(userName,commentText);
        CommentsSection.Add(uploadComment);
    }
    public void DisplayCommentsSection()
    {
        int i = 1;
        foreach (Comment comment in CommentsSection)
        {
            Console.Write($"{i})");
            comment.DisplayComment();
            i++;
        }
    }
    public int CommentCounter()
    {
        return CommentsSection.Count();
    }
    public void DisplayFullDetails()
    {
        int commentsCounter = CommentCounter();
        Console.WriteLine($"Title:{_title}\nAuthor:{_author}\nLength:{_length}\nSummary:{_summary}\nComments Section--{commentsCounter} comments");
        DisplayCommentsSection();
    }
        public void AddComment(Comment comment)
    {
        CommentsSection.Add(comment);
    }
}