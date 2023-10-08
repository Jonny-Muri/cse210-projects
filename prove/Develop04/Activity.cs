using System;
using System.IO;

public class Activity
{
    protected string _name;
    protected string _description;
    protected double _duration;

    public Activity(string name, string descrip, double duration)
    {
        _name = name;
        _description = descrip;
        _duration = duration;
    }
    public void DisplayingStartingMessage(string name)
    {
        _name = name;
        Console.WriteLine(name);
    }
    public void DisplayingEndingMessage(string descrip)
    {
        _description = descrip;
        Console.WriteLine(descrip);
    }
    public void ShowSpinner(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        List<string> animationSymbol = new List<string>();
        animationSymbol.Add("|");
        animationSymbol.Add("/");
        animationSymbol.Add("-");
        animationSymbol.Add("\\");
        animationSymbol.Add("|");
        animationSymbol.Add("/");
        animationSymbol.Add("-");
        animationSymbol.Add("\\");  

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationSymbol[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;

            if (i >= animationSymbol.Count)
            {
                i = 0;
            }
        }
        Console.Clear();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();
    }
}