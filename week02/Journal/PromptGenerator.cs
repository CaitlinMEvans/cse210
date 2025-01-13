using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // A list of predefined prompts for journaling
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "Scale of 1-10 how was your day? Talk about it",
        "What challenge did you overcome today?",
        "What is one thing you’re grateful for?",
        "Did you notice anything today that correlated with your prayers?",
        "If you could relive one moment today, what would it be?",
        "How did God show up for you today?",
        "What is one thing you wish you did today?",
        "What is one thing you learned today?",
        "How did you show love and kindness to others today?",
    };

    // Method to retrieve a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}