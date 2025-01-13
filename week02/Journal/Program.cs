using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // Journal and prompt generator
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice = "";

        // Menu loop to display options until the user chooses to quit
        while (userChoice != "5")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    // Create a new entry with the current date, time, and a random prompt
                    // TODO : Update prompts for my personal use
                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry(date, time, prompt, response);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    // Display all journal entries in a clear format
                    journal.DisplayAll();
                    break;
                case "3":
                    // CREATIVITY ADD: 
                    // Save journal entries to a file 
                    Console.Write("Enter the filename to save to (e.g., journal.json or journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    // CREATIVITY ADD:
                    // Load journal entries from a file
                    Console.Write("Enter the filename to load from (e.g., journal.json or journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Thanks for sharing - Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}