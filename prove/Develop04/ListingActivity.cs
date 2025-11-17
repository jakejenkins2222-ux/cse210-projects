class ListingActivity : Activity
{
    // Prompt bank with questions
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are the people you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }; 

    public ListingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        // Show prompt and ask user to list responses
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---");
        Console.Write("You may being in: ");
        Countdown(5);

        Console.Write("> "); 
        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (entry != "") count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}