using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base("Listing Activity",
            "This activity helps you reflect on good things in your life by listing as many items as you can.")
    {
        _prompts = new List<string>();
    }

    public void Run()
    {
        _count = GetListFromUser().Count;
    }

    private string GetRandomPrompt()
    {
        return string.Empty;
    }

    private List<string> GetListFromUser()
    {
        return new List<string>();
    }
}