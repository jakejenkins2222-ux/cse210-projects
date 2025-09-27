using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber, birthYear);
    }



    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int birthYear = int.Parse(Console.ReadLine());

        return birthYear;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
      Console.WriteLine($"{name}, you will turn {2025 - birthYear} this year.");
    }
}


