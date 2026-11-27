using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.");
        Console.WriteLine(_description);

        while (true)
        {
            Console.Write("How long, in seconds, would you like your session to last? ");
            var input = Console.ReadLine();

            if (input == null)
            {
                _duration = 0;
                return;
            }

            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                _duration = seconds;
                break;
            }

            Console.WriteLine("Please enter a whole number greater than zero.");
        }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);

        Console.WriteLine($"You completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        char[] frames = { '|', '/', '-', '\\' };

        for (int second = 0; second < seconds; second++)
        {
            foreach (char frame in frames)
            {
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int remaining = seconds; remaining > 0; remaining--)
        {
            string number = remaining.ToString();
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write(new string('\b', number.Length));
            Console.Write(new string(' ', number.Length));
            Console.Write(new string('\b', number.Length));
        }
    }
}