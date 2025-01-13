using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");// Greeting and initialization
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        // Example Scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string userInput = "";
        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3); // Hide 3 words at a time
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nThank you for using the Scripture Memorizer Program. Goodbye!");
    }
}