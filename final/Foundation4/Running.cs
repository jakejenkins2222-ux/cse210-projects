public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
        ActivityName = "Running"; 
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / GetMinutes()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / _distance, 2);
    }
}
