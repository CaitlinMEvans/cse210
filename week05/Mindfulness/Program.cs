// Creativity added by adding a progress tracker and a progress saver so it remembered pas submissions. 
using System;

class Program
{
    static void Main(string[] args)
    {
        //  Console.WriteLine("Hello World! This is the Mindfulness Project.")
        Console.WriteLine("Welcome to the Woodland Mindfulness Program!");

        ProgressTracker tracker = new ProgressTracker();
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Breathing Activity (Deer)");
            Console.WriteLine("2. Reflection Activity (Owl)");
            Console.WriteLine("3. Listing Activity (Fox)");
            Console.WriteLine("4. View Progress Tracker");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.Run(tracker);
                    break;
                case "2":
                    var reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run(tracker);
                    break;
                case "3":
                    var listingActivity = new ListingActivity();
                    listingActivity.Run(tracker);
                    break;
                case "4":
                    tracker.DisplayProgress();
                    break;
                case "5":
                    isRunning = false;
                    Console.WriteLine("\nThank you for using the Woodland Mindfulness Program - Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    break;
            }
            System.Threading.Thread.Sleep(1500);
        }
    }
}