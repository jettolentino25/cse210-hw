public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void DisplayStartingMessage()
    {
    }

    protected void DisplayEndingMessage()
    {
    }

    protected void ShowSpinner(int seconds)
    {
    }

    protected void ShowCountdown(int seconds)
    {
    }
}