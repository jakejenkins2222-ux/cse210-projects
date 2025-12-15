using System;

class Menu
{
    private int _totalPoints = 0;

    private List<Goal>_goals = new List<Goal>();

    public void GetFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        int counter = 0;

        foreach (string line in lines)
        {
            if (counter == 0)
            {
                _totalPoints = int.Parse(line);
                counter = 1;
            }

            else
            {
                string[] parts = line.Split("~");

                if (parts [0] == "EternalGoal")
                {
                    Goal currentGoal = new Goal (parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(currentGoal);
                }
                else if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal currentGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                    _goals.Add(currentGoal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal currentGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(currentGoal);
                }
            }
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

public void MenuFunction()
{
    string choice = "";

    while (choice != "6")
    {
        DisplayMenu();
        choice = Console.ReadLine();

        if (choice == "1")
        {
            CreateGoal();
        }
        else if (choice == "2")
        {
            ListGoals();
        }
        else if (choice == "3")
        {
            SaveFile();
        }
        else if (choice == "4")
        {
            GetFile();
        }
        else if (choice == "5")
        {
            RecordGoal();
        }
        else if (choice == "6")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option. Try again.");
        }
    }
}

private void DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine($"You have {_totalPoints} points");
    Console.WriteLine();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Goals");
    Console.WriteLine("  6. Quit");
    Console.Write("Select a choice from the menu: ");
}

private void CreateGoal()
{
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("  1. Simple goal");
    Console.WriteLine("  2. Eternal goal");
    Console.WriteLine("  3. Checklist goal");
    Console.Write("Which type of goal would you like to create? ");

    int choice = int.Parse(Console.ReadLine());
    Goal newGoal = null;

    if (choice == 1)
    {
        newGoal = new SimpleGoal();
    }
    else if (choice == 2)
    {
        newGoal = new Goal();
    }
    else if (choice == 3)
    {
        newGoal = new ChecklistGoal();
    }

    if (newGoal != null)
    {
        newGoal.GetGoal();
        _goals.Add(newGoal);
    }
}

private void ListGoals()
{
    Console.WriteLine();
    Console.WriteLine("The goals are:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
    }
}

private void RecordGoal()
{
    Console.WriteLine();
    Console.WriteLine("The goals are:");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
    }

    Console.Write("Which goal did you accomplish? ");
    int choice = int.Parse(Console.ReadLine());

    int pointsEarned = _goals[choice - 1].RecordEvent();
    _totalPoints += pointsEarned;

    Console.WriteLine();
    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    Console.WriteLine($"You now have {_totalPoints} points!");
}

}



