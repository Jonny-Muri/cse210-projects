using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public void GetRandomPrompt()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What am I nervous or anxious about today?");
        _prompts.Add("What were the highlights of my day");

        Random random = new Random();
        random.Next(_prompts.Count);
        Console.WriteLine(_prompts);

    }
}