using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflecting Activity",
            "This activity helps you reflect on times when you showed strength and resilience.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
    }

    private string GetRandomPrompt()
    {
        return string.Empty;
    }

    private string GetRandomQuestion()
    {
        return string.Empty;
    }

    private void DisplayPrompt()
    {
    }

    private void DisplayQuestions()
    {
    }
}