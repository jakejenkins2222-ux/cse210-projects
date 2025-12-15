using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue, string completed) : base(name, description, pointValue)
    {
        _completed = completed;
    }

    public SimpleGoal(){}

    public override void IsComplete()
    {
        _completed = "X";
    }

    public override int RecordEvent()
    {
        if (_completed != "X")
        {
            _completed = "X";
            return _pointValue;
        }
        return 0; 
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal,{_name},{_description},{_pointValue},{_completed}";
    }
  
}