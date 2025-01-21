using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected string _animalGuide;
    protected int _duration;

    public Activity(string name, string description, string animalGuide)
    {
        _name = name;
        _description = description;
        _animalGuide = animalGuide;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity, guided by the {_animalGuide}!");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of the activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGreat job! You've completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{_animalGuide} is preparing... {i}");
            Thread.Sleep(1000);
        }
    }
}