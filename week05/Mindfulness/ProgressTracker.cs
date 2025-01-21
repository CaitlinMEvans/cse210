public class ProgressTracker
{
    private Dictionary<string, int> _completedActivities;
    private int _totalTime;

    public ProgressTracker()
    {
        _completedActivities = new Dictionary<string, int>();
        _totalTime = 0;
    }

    public void LogActivity(string activityName, int duration)
    {
        if (_completedActivities.ContainsKey(activityName))
        {
            _completedActivities[activityName]++;
        }
        else
        {
            _completedActivities[activityName] = 1;
        }

        _totalTime += duration;

        // Save progress after logging
        SaveProgress();
    }

    public void DisplayProgress()
    {
        Console.Clear();
        Console.WriteLine("Progress Tracker:");
        Console.WriteLine("Completed Activities:");

        foreach (var activity in _completedActivities)
        {
            Console.WriteLine($"- {activity.Key}: {activity.Value} times");
        }

        Console.WriteLine($"Total Time Spent: {_totalTime} seconds\n");
    }

    // Save progress to a file
    private void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter("progress.txt"))
        {
            writer.WriteLine(_totalTime);
            foreach (var activity in _completedActivities)
            {
                writer.WriteLine($"{activity.Key}|{activity.Value}");
            }
        }
    }

    // Load progress from a file
    public void LoadProgress()
    {
        if (File.Exists("progress.txt"))
        {
            string[] lines = File.ReadAllLines("progress.txt");
            if (lines.Length > 0)
            {
                _totalTime = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    _completedActivities[parts[0]] = int.Parse(parts[1]);
                }
            }
        }
    }
}