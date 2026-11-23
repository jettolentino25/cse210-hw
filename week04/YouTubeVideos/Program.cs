using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Desk Setup Tour", "Alex", 180);
        video1.AddComment(new Comment("Mia", "I like the monitor stand."));
        video1.AddComment(new Comment("Sam", "The cable setup looks clean."));
        video1.AddComment(new Comment("Jordan", "What keyboard are you using?"));

        Video video2 = new Video("Packing for a Weekend Trip", "Taylor", 240);
        video2.AddComment(new Comment("Casey", "The packing cubes look handy."));
        video2.AddComment(new Comment("Riley", "How much does the bag weigh?"));
        video2.AddComment(new Comment("Jamie", "I like the separate shoe pocket."));

        Video video3 = new Video("Making Coffee at Home", "Morgan", 210);
        video3.AddComment(new Comment("Avery", "The scale looks easy to read."));
        video3.AddComment(new Comment("Drew", "What grinder are you using?"));
        video3.AddComment(new Comment("Quinn", "I tried this recipe and liked it."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetPersonName()}: {comment.GetComment()}");
            }

            Console.WriteLine();
        }
    }
}