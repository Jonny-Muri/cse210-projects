using System;
using System.IO;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string descrip, int duration) : base(name, descrip, duration)
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
        Console.Write("Breath in...");
        ShowCountDown(5);
        Console.Write("\nAnd breath out... ");
        ShowCountDown(6);
        Console.Write("\nBreath in... ");
        ShowCountDown(5);
        Console.Write("\nAnd breath out... ");
        ShowCountDown(6);
        Console.WriteLine("\nWell Done!");
        Console.Clear();
        
    }



}