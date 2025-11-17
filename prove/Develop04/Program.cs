using System;

// To exceed requirements with this program I added a feature that ensures that questions in the 
// Reflection activity are used only once and not repeated. 
class Program
{
    static void Main(string[] args)
    {

        // Display and loop menu options for each activity till user quits
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            int.TryParse(input, out choice);

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
                breathing.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity(
                    "Reflection",
                    "This activity helps you reflect on a time in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many\nthings as you can in a certain area.");
                listing.Run();
            }
            else if (choice == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
