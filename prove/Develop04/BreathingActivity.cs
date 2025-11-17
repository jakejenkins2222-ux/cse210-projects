class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartActivity();
        int total = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(total);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in..."); 
            Countdown(4);
            Console.Write("Now breathe out...");
            Countdown(6);
            Console.WriteLine("");
        }

        EndActivity();
    }
} 