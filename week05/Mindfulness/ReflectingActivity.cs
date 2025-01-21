using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you showed courage.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you overcame a challenge."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "How did you feel during this experience?",
        "What did you learn from it?"
    };

    public ReflectingActivity() : base(
        "Reflection",
        "This activity helps you reflect on meaningful moments. Guided by the Owl, you'll gain deeper insights into your strengths.",
        "Owl")
    { }

    public void Run(ProgressTracker tracker)
    {
        DisplayStartingMessage();
        var random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
        tracker.LogActivity(_name, _duration);
    }
}