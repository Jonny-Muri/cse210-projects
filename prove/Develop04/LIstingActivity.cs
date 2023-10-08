using System;
using System.IO;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string descrip, int duration) : base(name, descrip, duration)
    {
        _name = name;
        _description = descrip;
        _duration = duration;
    }

    public void Run()
    {
        DisplayingStartingMessage(_name);
        Console.WriteLine();
        DisplayingEndingMessage(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? > ");
        string duration = Console.ReadLine();
        ShowSpinner(4);
        Thread.Sleep(400);
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.ReadLine();
        // ShowSpinner(6);

    }
    public string GetRandomPrompt()
    {
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();

        Console.WriteLine($"---{_prompts[random.Next(_prompts.Count)]}---");

        return "";
    }
    public string GetListFromUser()
    {
        return "";
    }

}