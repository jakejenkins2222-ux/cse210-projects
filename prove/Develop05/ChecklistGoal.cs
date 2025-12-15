using System;

public class ChecklistGoal : Goal
{
    private int _bonusValue;
    private int _timesCompleted;
    private int _targetCompletion;

    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int timesCompleted, int targetCompletion) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesCompleted = timesCompleted;
        _targetCompletion = targetCompletion;

        if (_timesCompleted == targetCompletion)
        {
            _completed = "X";
        }
    }

    public ChecklistGoal(){}

    public override void GetGoal()
    {
        base.GetGoal();

        Console.WriteLine("How many time does thsi goal need to be accomplished for a bonus?");
        _targetCompletion = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusValue = int.Parse(Console.ReadLine());

        _timesCompleted = 0;

    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCompletion)
        {
            _timesCompleted++;

            if (_timesCompleted == _targetCompletion)
            {
                _completed = "X";
                return _pointValue + _bonusValue;
            }
            return _pointValue;
        }
        
        return 0;
    }


    public override string SaveGoal()
    {
        return $"ChecklistGoal,{_name},{_description},{_pointValue},{_bonusValue},{_timesCompleted},{_targetCompletion}";
    }

    public override string Display()
    {
        return $"[{_completed}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_targetCompletion}";
    }
}
