using System;
using System.IO;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string descrip, double duration) : base(name, descrip, duration)
    {
        _name = name;
        _description = descrip;
        _duration = duration;
    }

    public void Run()
    {
        //The name and description of Breathing Activity
        DisplayingStartingMessage(_name);
        Console.WriteLine();
        DisplayingEndingMessage(_description);
        Console.WriteLine();
        //User Input
        Console.Write("How long, in seconds, would you like for your session? > ");
        string duration = Console.ReadLine();
        ShowSpinner(4);
        Thread.Sleep(400);
        //Action of the Activity
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration * 10);


        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.Write("And breath out... ");
            ShowCountDown(6);
            Console.WriteLine();
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.Write("And breath out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        // Console.Write("Breath in...");
        // ShowCountDown(5);
        // Console.Write("And breath out... ");
        // ShowCountDown(6);
        // Console.Write("\nBreath in... ");
        // ShowCountDown(5);
        // Console.Write("\nAnd breath out... ");
        // ShowCountDown(6);
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"You have completed {_duration}0 seconds of the Relfecting Activity");
        Thread.Sleep(4500);
        Console.Clear();
        
    }



}