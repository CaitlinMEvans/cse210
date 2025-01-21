using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List things you are grateful for.",
        "List people who inspire you.",
        "List your personal achievements."
    };

    public ListingActivity() : base(
        "Listing",
        "This activity helps you reflect on positive aspects of your life by listing items related to a prompt, guided by the Fox.",
        "Fox")
    { }

    public void Run(ProgressTracker tracker)
    {
        DisplayStartingMessage();
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Start listing items. Press Enter after each item. Type 'done' when finished.\n");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done") break;
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DisplayEndingMessage();
        tracker.LogActivity(_name, _duration);
    }
}
