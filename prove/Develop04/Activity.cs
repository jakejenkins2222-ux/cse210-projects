class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    // Welcome statement to each activity and asks how much time for a session
    public void StartActivity()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine(_description);
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
        if (_duration <= 0) _duration = 10;

        Console.WriteLine("");
        Console.WriteLine("Get ready...");
        Spinner(3);
    }
    // Congratulate and display completion of activity + time taken
    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Spinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(3);
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }

    // Countdown timer
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        Console.WriteLine();
    }

    // Spinner animation
    protected void Spinner(int seconds)
    {
        DateTime end = DateTime.Now.AddSeconds(seconds);
        string[] symbols = { "-", "\\", "|", "/" };
        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(symbols[index]);
            index = (index + 1) % symbols.Length;
            Thread.Sleep(300); 
            Console.Write("\b ");
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}