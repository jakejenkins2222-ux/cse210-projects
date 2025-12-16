using System;

public class Activity
{
    private string _date;
    private int _minutes;
    protected string ActivityName; 

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        ActivityName = "Activity"; 
    }

    
    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return GetDate() + " " + ActivityName + " (" + GetMinutes() + " min): " + "Distance " + GetDistance() + " miles, " + "Speed " + GetSpeed() + " mph, " + "Pace: " + GetPace() + " min per mile";
    }
}