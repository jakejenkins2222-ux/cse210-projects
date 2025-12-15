using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected string _completed = " ";

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public Goal(){}

    
    public virtual void GetGoal()
    {
 
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        _pointValue = int.Parse(Console.ReadLine());

    }

    
    public virtual int RecordEvent()
    {
        return _pointValue;
    }

    public virtual void IsComplete(){}

    public virtual string Display()
    {
        return $"[{_completed}] {_name} ({_description})";
    }

    public virtual string SaveGoal()
    {
        return $"EternalGoal,{_name},{_description},{_pointValue}";
    }

    public string GetName()
    {
        return _name;
    }
}
