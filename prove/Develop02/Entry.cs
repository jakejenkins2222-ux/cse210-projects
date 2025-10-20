using System;

public class Entry
{

    // the display journal will display these
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
    
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }
}