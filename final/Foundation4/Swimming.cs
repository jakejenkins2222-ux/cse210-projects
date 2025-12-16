public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        ActivityName = "Swimming";
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000.0 * 0.62, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetMinutes()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 2);
    }
}
