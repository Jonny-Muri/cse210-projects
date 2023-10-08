using System;
using System.IO;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string descrip, double duration) : base(name, descrip, duration)
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
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"You have completed {_duration}0 seconds of the Relfecting Activity");
        Thread.Sleep(4500);
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        _prompts = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

        Random random = new Random();

        Console.WriteLine($"---{_prompts[random.Next(_prompts.Count)]}---");

        return "";
    }
    public string GetRandomQuestions()
    {
        _questions = new List<string>();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        Console.Write($"{_questions[random.Next(_questions.Count)]} ");

        return "";
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        GetRandomPrompt();
        Thread.Sleep(5000);
    }
    public void DisplayQuestions()
    {
        GetRandomQuestions();
        ShowCountDown(5);
        Console.WriteLine();
        GetRandomQuestions();
        ShowCountDown(5);
    }
}