using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference refer = new Reference("Proverbs", 3, 5, 6);
        Scripture script = new Scripture(refer, "Trust in the Lord with all thine heart; and lean not unto thine own understanding");
        
        Console.Clear();
        
        string input = "";
        while (input != "quit")
        {
            Console.WriteLine(script.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            input = Console.ReadLine();
            if(input != "quit")
            {
                script.HideRandomWords(3);
            }
            Console.Clear();
        }
        
    }
}