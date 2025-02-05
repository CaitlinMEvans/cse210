using System;
using System.Collections.Generic;
using System.IO;

// Base Goal Class
abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public int GetPoints() => _points;
}

// Simple Goal Class
class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"[ {(IsComplete() ? "X" : " ")} ] {_name} ({_description})";

    public override string GetStringRepresentation() => $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
}

// Eternal Goal Class
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // No completion, just add points.
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[ ] {_name} ({_description})";

    public override string GetStringRepresentation() => $"EternalGoal:{_name},{_description},{_points}";
}

// Checklist Goal Class
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string progressBar = GenerateProgressBar();
        return $"[ {(IsComplete() ? "X" : " ")} ] {_name} ({_description}) - {progressBar} {_amountCompleted}/{_target}";
    }

    private string GenerateProgressBar()
    {
        int progressBlocks = (int)((double)_amountCompleted / _target * 10);
        return new string('#', progressBlocks) + new string('-', 10 - progressBlocks);
    }

    public override string GetStringRepresentation() => $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
}

// Weekly Challenge Class
class WeeklyChallenge
{
    private string _description;
    private Dictionary<string, int> _requirements;
    private int _bonusPoints;
    private Dictionary<string, int> _progress;

    public WeeklyChallenge(string description, Dictionary<string, int> requirements, int bonusPoints)
    {
        _description = description;
        _requirements = requirements;
        _bonusPoints = bonusPoints;
        _progress = new Dictionary<string, int>();

        foreach (var key in requirements.Keys)
        {
            _progress[key] = 0;
        }
    }

    public void RecordProgress(string goalType)
    {
        if (_progress.ContainsKey(goalType))
        {
            _progress[goalType]++;
        }
    }

    public bool IsComplete()
    {
        foreach (var key in _requirements.Keys)
        {
            if (_progress[key] < _requirements[key])
                return false;
        }
        return true;
    }

    public void DisplayChallengeStatus()
    {
        Console.WriteLine($"Weekly Challenge: {_description}");
        foreach (var key in _requirements.Keys)
        {
            Console.WriteLine($"- {key}: {_progress[key]}/{_requirements[key]}");
        }
        Console.WriteLine(IsComplete() ? $"Challenge Complete! Bonus Points: {_bonusPoints}" : "Keep going!");
    }

    public int GetBonusPoints() => IsComplete() ? _bonusPoints : 0;
}

// Goal Manager Class
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private WeeklyChallenge _weeklyChallenge;

    public GoalManager()
    {
        _weeklyChallenge = new WeeklyChallenge("Complete 2 Simple Goals and 1 Checklist Goal", new Dictionary<string, int> { { "SimpleGoal", 2 }, { "ChecklistGoal", 1 } }, 100);

        // Initial goals setup
        CreateGoal(new SimpleGoal("Run a Muddy Girl 5k", "Register and Complete", 1000));
        CreateGoal(new EternalGoal("Read Scriptures", "Daily scripture study", 100));
        CreateGoal(new ChecklistGoal("Visit the Temple", "Attend 10 times", 50, 10, 500));
    }

    public int GoalCount => _goals.Count;

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        var goal = _goals[goalIndex];
        goal.RecordEvent();
        _score += goal.GetPoints();
        _weeklyChallenge.RecordProgress(goal.GetType().Name);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void DisplayWeeklyChallenge()
    {
        _weeklyChallenge.DisplayChallengeStatus();
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Score");
            Console.WriteLine("4. Display Weekly Challenge");
            Console.WriteLine("5. Create a New Goal");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayGoals();
                    break;
                case "2":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to record: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= manager.GoalCount)
                    {
                        manager.RecordEvent(goalIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;
                case "3":
                    manager.DisplayScore();
                    break;
                case "4":
                    manager.DisplayWeeklyChallenge();
                    break;
                case "5":
                    CreateNewGoal(manager);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");

        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points. Returning to menu.");
            return;
        }

        switch (goalType)
        {
            case "1":
                manager.CreateGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.CreateGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target. Returning to menu.");
                    return;
                }

                Console.Write("Enter bonus points: ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus. Returning to menu.");
                    return;
                }

                manager.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Returning to menu.");
                break;
        }

        Console.WriteLine("New goal created successfully!");
    }
}