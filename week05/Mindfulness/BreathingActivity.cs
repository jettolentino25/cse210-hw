public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
            "This activity helps you relax by guiding you through slow breaths in and out.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remaining = GetDuration();
        if (remaining == 0)
        {
            return;
        }

        bool breatheIn = true;

        while (remaining > 0)
        {
            System.Console.Write(breatheIn ? "Breathe in... " : "Breathe out... ");

            int pause = System.Math.Min(breatheIn ? 4 : 6, remaining);
            ShowCountdown(pause);
            System.Console.WriteLine();

            remaining -= pause;
            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}