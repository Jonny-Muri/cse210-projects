using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference refer = new Reference("Proverbs", 3, 5, 6);
        Scripture script = new Scripture(refer, "Trust in the Lord with all thine heart; and lean not unto thine own understanding");
        
        Console.Clear();
        
        Console.WriteLine(script.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        Console.ReadLine();
        
    }
}