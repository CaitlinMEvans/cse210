public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by guiding you through slow, deep breathing. Clear your mind and focus on your breathing.",
        "Deer")
    { }

    public void Run(ProgressTracker tracker)
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
        tracker.LogActivity(_name, _duration);
    }
}