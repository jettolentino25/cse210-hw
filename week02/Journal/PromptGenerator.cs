using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What is one small win I had today?",
        "What did I learn about myself today?",
        "What are the methods I can do to polish my codes?",
        "What skills do I need to enhance to absorb coding?",
        "Why is it that the codes are colorful?"
    };

    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}