using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();

            if (DateTime.Now < futureTime)
            {
                Console.Write("Breathe out... ");
                ShowCountdown(4);
                Console.WriteLine();
            }
        }

        DisplayEndingMessage();
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}