using System;
using System.Collections.Generic;
using System.IO;

public class ProgressTracker
{
    private List<string> _completedActivities = new List<string>();
    private int _totalTime;
    private const string ProgressFile = "progress.txt"; // File to save progress

    public ProgressTracker()
    {
        LoadProgress();
    }

    public void LogActivity(string activityName, int duration)
    {
        _completedActivities.Add(activityName);
        _totalTime += duration;
        SaveProgress();
    }

    public void DisplayProgress()
    {
        Console.Clear();
        Console.WriteLine("Progress Tracker:");
        Console.WriteLine("Completed Activities:");
        foreach (string activity in _completedActivities)
        {
            Console.WriteLine($"- {activity}");
        }
        Console.WriteLine($"Total Time Spent: {_totalTime} seconds\n");

        Console.WriteLine("Would you like to:");
        Console.WriteLine("1. Return to the activities menu");
        Console.WriteLine("2. Exit the program");

        string input = Console.ReadLine()?.Trim();
        if (input == "1")
        {
            Console.WriteLine("\nReturning to the activities menu...");
            Thread.Sleep(1000); // Short delay before returning
        }
        else if (input == "2")
        {
            Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("\nInvalid option. Returning to the activities menu...");
            Thread.Sleep(1000);
        }
    }

    private void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter(ProgressFile))
        {
            writer.WriteLine(_totalTime);
            foreach (string activity in _completedActivities)
            {
                writer.WriteLine(activity);
            }
        }
    }

    private void LoadProgress()
    {
        if (File.Exists(ProgressFile))
        {
            using (StreamReader reader = new StreamReader(ProgressFile))
            {
                if (int.TryParse(reader.ReadLine(), out int time))
                {
                    _totalTime = time;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _completedActivities.Add(line);
                }
            }
        }
    }
}