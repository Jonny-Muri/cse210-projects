using System;
using System.IO;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string descrip, double duration) : base(name, descrip, duration)
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
        // Console.ReadLine();
        ShowCountDown(6);
        Thread.Sleep(200);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration * 10);


        while(DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"You have completed {_duration}0 seconds of the Relfecting Activity");
        Thread.Sleep(4500);
        Console.Clear();



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
        List<string> answer = new List<string>();
        Console.Write("> ");
        string input = Console.ReadLine();
        answer.Add(input);
        Console.WriteLine($"You have listed {answer.Count} times");

        return "";
    }

}