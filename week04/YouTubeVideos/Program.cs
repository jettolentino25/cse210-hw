using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Desk Setup Tour", "Alex", 180);

        video1.AddComment(new Comment("Mia", "I like the monitor stand."));
        video1.AddComment(new Comment("Sam", "The cable setup looks clean."));
        video1.AddComment(new Comment("Jordan", "What keyboard are you using?"));

        Console.WriteLine($"Title: {video1.GetTitle()}");
        Console.WriteLine($"Author: {video1.GetAuthor()}");
        Console.WriteLine($"Length: {video1.GetLengthInSeconds()} seconds");
        Console.WriteLine($"Comments: {video1.GetCommentCount()}");
        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine($"- {comment.GetPersonName()}: {comment.GetComment()}");
        }
    }
}