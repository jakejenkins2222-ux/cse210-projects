class ReflectionActivity : Activity
{
    // Prompt bank with ponder statements
    private string[] _prompts =
    {
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _unusedQuestions;

    // Prompt bank with reflection questions
    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "

    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _unusedQuestions = new List<string>(_questions);
    }


    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        // Show user random prompt
        Console.WriteLine("Consider the following prompt:\n ");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---");

        // Pause here until the user presses enter.
        // After the user presses enter, the activity will continue.
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();

        // Ask to ponder each question for a period of time
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("");

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            // Make sure each question is used only once
            if (_unusedQuestions.Count == 0)
                _unusedQuestions = new List<string>(_questions);

            int index = rand.Next(_unusedQuestions.Count);
            string question = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);

            Console.WriteLine($"> {question}");
            Spinner(15);
        }

        EndActivity();
    }
}