using System;
using System.Collections.Generic;

// Added Creativity: Added functionality to dynamically "recommend" an activity based on calculated performance trends.
// Base Activity Class
abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date}: {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }

    public string GetTypeName() => this.GetType().Name;
}

// Running Activity
class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / _minutes) * 60;

    public override double GetPace() => _minutes / _distance;
}

// Cycling Activity
class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * _minutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}

// Swimming Activity
class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0 * 0.62;

    public override double GetSpeed() => (GetDistance() / _minutes) * 60;

    public override double GetPace() => _minutes / GetDistance();
}

// Activity Manager with Recommendations
class ActivityManager
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public void DisplayActivities()
    {
        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    public void DisplayRecommendations()
    {
        double totalRunningDistance = 0, totalCyclingDistance = 0, totalSwimmingLaps = 0;
        double totalRunningPace = 0, totalCyclingPace = 0, totalSwimmingPace = 0;
        int runningCount = 0, cyclingCount = 0, swimmingCount = 0;

        // Analyze data
        foreach (var activity in _activities)
        {
            if (activity is Running running)
            {
                totalRunningDistance += running.GetDistance();
                totalRunningPace += running.GetPace();
                runningCount++;
            }
            else if (activity is Cycling cycling)
            {
                totalCyclingDistance += cycling.GetDistance();
                totalCyclingPace += cycling.GetPace();
                cyclingCount++;
            }
            else if (activity is Swimming swimming)
            {
                totalSwimmingLaps += swimming.GetDistance();
                totalSwimmingPace += swimming.GetPace();
                swimmingCount++;
            }
        }

        // Calculate averages
        double avgRunningPace = runningCount > 0 ? totalRunningPace / runningCount : double.MaxValue;
        double avgCyclingPace = cyclingCount > 0 ? totalCyclingPace / cyclingCount : double.MaxValue;
        double avgSwimmingLaps = swimmingCount > 0 ? totalSwimmingLaps / swimmingCount : 0;

        Console.WriteLine("\n--- Activity Recommendations ---");
        if (avgRunningPace > avgCyclingPace)
        {
            Console.WriteLine("Recommendation: Focus on improving your running pace.");
        }
        if (avgSwimmingLaps < totalRunningDistance && avgSwimmingLaps < totalCyclingDistance)
        {
            Console.WriteLine("Recommendation: Consider increasing your swimming laps.");
        }
        else
        {
            Console.WriteLine("Keep up the balanced performance across activities!");
        }
    }
}

// Main Program
class Program
{   
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        ActivityManager manager = new ActivityManager();

        // Add sample activities
        manager.AddActivity(new Running("05 Feb 2025", 30, 3.0));  // 3 miles in 30 mins
        manager.AddActivity(new Cycling("06 Feb 2025", 40, 15.0)); // 15 mph for 40 mins
        manager.AddActivity(new Swimming("07 Feb 2025", 25, 20));  // 20 laps in 25 mins

        // Display activities and recommendations
        Console.WriteLine("--- Activity Summaries ---");
        manager.DisplayActivities();

        manager.DisplayRecommendations();
    }
}
