using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts;
    private readonly List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting Activity",
            "This activity helps you reflect on times when you showed strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "How can you apply what you learned to another situation?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        if (GetDuration() == 0)
        {
            return;
        }

        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[Random.Shared.Next(_prompts.Count)];
    }

    private string GetRandomQuestion(List<string> availableQuestions)
    {
        int index = Random.Shared.Next(availableQuestions.Count);
        string question = availableQuestions[index];
        availableQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\n{GetRandomPrompt()}");
        Console.WriteLine("Take a moment to think about that experience.");
        ShowCountdown(3);
        Console.WriteLine();
    }

    private void DisplayQuestions()
    {
        List<string> availableQuestions = new List<string>(_questions);
        int remaining = GetDuration();

        while (remaining > 0)
        {
            if (availableQuestions.Count == 0)
            {
                availableQuestions.AddRange(_questions);
            }

            Console.Write($"{GetRandomQuestion(availableQuestions)} ");
            int pause = Math.Min(5, remaining);
            ShowSpinner(pause);
            Console.WriteLine();

            remaining -= pause;
        }
    }
}