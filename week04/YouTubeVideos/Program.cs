using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Desk Setup Tour", "Alex", 180);
        Console.WriteLine(video1.GetTitle());
    }
}