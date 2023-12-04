// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

class PomodoroTimer
{
    static void Main()
    {
        Console.WriteLine("Welcome to Pomodoro Timer!");

        while (true)
        {
            Console.WriteLine("\n--- Pomodoro Cycle ---");
            Work(25);
            Break(5); 
        }
    }

    static void Work(int minutes)
    {
        Console.WriteLine($"\nWork for {minutes} minutes starts now.");
        Thread.Sleep(minutes * 60 * 1000); 
        Console.WriteLine("\nWork complete! Take a break.");
    }

    static void Break(int minutes)
    {
        Console.WriteLine($"\nBreak for {minutes} minutes starts now.");
        Thread.Sleep(minutes * 60 * 1000); 
        Console.WriteLine("\nBreak complete! Get ready for the next work session.");
    }
}
