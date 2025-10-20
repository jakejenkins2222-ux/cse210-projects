using System;

//store and loop through entry displays
public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    // better suited in the entry class
    public void DisplayJournal()
    {

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("");
        }
    }

}