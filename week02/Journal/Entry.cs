using System;

public class Entry
{
    // Attributes for storing entry details
    public string Date { get; private set; }
    public string Time { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }

    // Constructor to initialize a new entry
    public Entry(string date, string time, string promptText, string entryText)
    {
        Date = date;
        Time = time;
        PromptText = promptText;
        EntryText = entryText;
    }

    // A method to display the entry details in a readable format
    public void Display()
    {
        Console.WriteLine($"Date: {Date} Time: {Time}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}");
        Console.WriteLine();
    }

    // Parameterless constructor for JSON deserialization
    public Entry() { }
}
