using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        List<string> promptBank = new List<string>
        {
            "Who was the most intersting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I eat for dinner?",
            "Did I make any progess today on anything?",


        };

        Random randomGenerator = new Random();

        Journal journal = new Journal();

        string filename;
        int promptNumber;
        string currentPrompt;
        Entry currentEntry;
        DateTime today;


        int number = -1;

        while (number != 5)
        {
            Console.WriteLine("What would you like to do?");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                // motivate me to actually write in my journal
                Console.WriteLine("(We have all the journal questions ready, it will only take a few minutes to answer a few as you please!! Easy.)");
            
                today = DateTime.Today;
                

                promptNumber = randomGenerator.Next(0, promptBank.Count);
                currentPrompt = promptBank[promptNumber];
                Console.WriteLine($"{currentPrompt}: ");

                string response = Console.ReadLine();

                currentEntry = new Entry();
                currentEntry._date = today.ToString("MM-dd-yyyy");
                currentEntry._prompt = currentPrompt;
                currentEntry._response = response;
                journal._entries.Add(currentEntry);

            }

            else if (number == 2)
            {
                journal.DisplayJournal();
            }

            else if (number == 3)
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
{
                    string[] parts = line.Split("~");
 
                    string dateFile = parts[0];
                    string promptFile = parts[1];
                    string responseFile = parts[2];

                    currentEntry = new Entry();
                    currentEntry._date = dateFile;
                    currentEntry._prompt = promptFile;
                    currentEntry._response = responseFile;

                    journal._entries.Add(currentEntry);

                    //journal.DisplayJournal();
}
            }

            else if (number == 4)
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal._entries)
                    {

                        outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
                    }
}
            }

            else if (number == 5)
            {
                // Motivate me to come back tomorrow and write more.
                Console.WriteLine("End. See you tomorrow!");

            }
        }



    }
}