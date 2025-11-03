using System;

// To exceed requirements on this assignment I have added a 'show' feature to unhide any words
// so that the user may restart and see all words again. 

public class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        // Scripture scripture = new Scripture(reference, ""For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        int wordCount = scripture.MakeList();
        int hiddenWordCount = 0;
        string response = "";

        while (response != "end" && hiddenWordCount != wordCount)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Hit enter to hide words, 'show' to unhide all, or 'end' to quit:");
            response = Console.ReadLine();



            if (response == "")
            {
                hiddenWordCount += scripture.HideWords();
            }

            else if (response == "show")
            {
                scripture.UnhideAllWords();
                hiddenWordCount = 0;
            }

            hiddenWordCount = scripture.GetHiddenWordCount();

            if (hiddenWordCount >= wordCount)
            {
                Console.Clear();
                scripture.Display();
                break;
            }
        }


    }

}