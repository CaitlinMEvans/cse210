using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // A list to store all the journal entries
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("New entry added to the journal!");
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("\nYour Journal Entries:");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
    // CREATIVITY ADD - Save and Load the Journals
    // Save the journal to a file, handling both CSV and JSON formats
    public void SaveToFile(string file)
    {
        if (file.EndsWith(".json"))
        {
            // Save as JSON
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file, json);
            Console.WriteLine("Journal saved successfully in JSON format!");
        }
        else if (file.EndsWith(".csv"))
        {
            // Save as CSV
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    // Properly escape commas and quotes for CSV format
                    string escapedPrompt = entry.PromptText.Replace("\"", "\"\"");
                    string escapedResponse = entry.EntryText.Replace("\"", "\"\"");
                    outputFile.WriteLine($"\"{entry.Date}\",\"{entry.Time}\",\"{escapedPrompt}\",\"{escapedResponse}\"");
                }
            }
            Console.WriteLine("Journal saved successfully in CSV format!");
        }
        else
        {
            Console.WriteLine("Invalid file format. Please use .json or .csv.");
        }
    }

    // Load the journal from a file, handling both CSV and JSON formats
    public void LoadFromFile(string file)
    {
        if (file.EndsWith(".json"))
        {
            // Load from JSON
            string json = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal loaded successfully from JSON!");
        }
        else if (file.EndsWith(".csv"))
        {
            // Load from CSV
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("\",\"");
                string date = parts[0].Trim('"');
                string time = parts[1].Trim('"');
                string prompt = parts[2].Trim('"');
                string response = parts[3].Trim('"');
                _entries.Add(new Entry(date, time, prompt, response));
            }
            Console.WriteLine("Journal loaded successfully from CSV!");
        }
        else
        {
            Console.WriteLine("Invalid file format. Please use .json or .csv.");
        }
    }
}