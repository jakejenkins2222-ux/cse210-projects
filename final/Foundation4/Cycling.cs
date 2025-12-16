public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        ActivityName = "Cycling"; 
    }

    public override double GetDistance()
    {
        return Math.Round((_speed * GetMinutes()) / 60, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}
