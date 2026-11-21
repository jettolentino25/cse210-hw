using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // Split the verse text into Word objects in the programming assignment.
    }

    public void HideRandomWords(int numberToHide)
    {
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}