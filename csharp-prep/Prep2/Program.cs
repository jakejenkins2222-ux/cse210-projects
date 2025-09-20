using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();
        int number = int.Parse(grade_percentage);

        string grade_letter = "";


        if (number >= 90)
        {
            grade_letter = "A";
        }
        else if (number >= 80)
        {
            grade_letter = "B";
        }
        else if (number >= 70)
        {
           grade_letter = "C";
        }
        else if (number >= 60)
        {
            grade_letter = "D";
        }
        else if (number < 60)
        {
            grade_letter = "F";
        }

        Console.WriteLine($"You have an {grade_letter}!");
        
        if (number >= 70)
        {
            Console.WriteLine("You passed. Congrats!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time!");
        }


    }
}