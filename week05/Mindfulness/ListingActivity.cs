using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base("Listing Activity",
            "This activity helps you reflect on good things in your life by listing as many items as you can.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        if (GetDuration() == 0)
        {
            return;
        }

        Console.WriteLine($"\n{GetRandomPrompt()}");
        Console.Write("You may begin in: ");
        ShowCountdown(3);
        Console.WriteLine();

        Console.WriteLine("Type one item per line. Press Enter to save each item.");
        _count = GetListFromUser().Count;

        Console.WriteLine($"You listed {_count} item(s).");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        StringBuilder currentItem = new StringBuilder();
        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        Stopwatch timer = Stopwatch.StartNew();

        Console.Write("> ");

        while (timer.Elapsed < duration)
        {
            if (!Console.KeyAvailable)
            {
                Thread.Sleep(20);
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
            {
                string response = currentItem.ToString().Trim();
                if (response.Length > 0)
                {
                    responses.Add(response);
                }

                currentItem.Clear();
                Console.Write("\n> ");
            }
            else if (key.Key == ConsoleKey.Backspace && currentItem.Length > 0)
            {
                currentItem.Length--;
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                currentItem.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        }

        Console.WriteLine();
        return responses;
    }
}