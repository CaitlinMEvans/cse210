Class Diagram Journal:

Attributes:
_entries : List<Entry>
Behaviors:
AddEntry(newEntry : Entry) : void
DisplayAll() : void
SaveToFile(file : string) : void
LoadFromFile(file : string) : void
Entry:

Attributes:
_date : string
_promptText : string
_entryText : string
Behaviors:
Display() : void
PromptGenerator:

Attributes:
_prompts : List<string>
Behaviors:
GetRandomPrompt() : string

<!-- Journal.CS -->
using System;
using System.Collections.Generic;

public class Journal
{
    // List to store journal entries
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save entries to a file (to be implemented later)
    public void SaveToFile(string file)
    {
        // Stub for saving entries to a file
    }

    // Load entries from a file (to be implemented later)
    public void LoadFromFile(string file)
    {
        // Stub for loading entries from a file
    }
}

<!-- Entry.cs -->
using System;

public class Entry
{
    // Member variables for entry details
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor to initialize an entry
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}

<!-- promptGenerator.cs -->
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // List of prompts
    private List<string> _prompts = new List<string>
    <!-- When I complete this project I want to add more prompts that are meaningful and useful to use for myself -->
    {
        "What made you happy today?",
        "What is one thing you learned today?",
        "Describe your ideal day.",
        "What are you grateful for today?"
    };

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}


<!-- Program.cs -->
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Caitlin's Journal Program!");

        // Create a new journal
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Example of adding entries
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string prompt = promptGenerator.GetRandomPrompt();
        string entryText = "Today, I learned about abstraction in programming.";

        Entry entry1 = new Entry(date, prompt, entryText);
        journal.AddEntry(entry1);

        // Display the journal
        journal.DisplayAll();
    }
}
