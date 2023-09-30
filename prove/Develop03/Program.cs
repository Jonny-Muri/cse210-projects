using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference refer = new Reference("Proverbs", 3, 5, 6);
        //string prov = "Trust in the Lord with all thine heart; and lean not unto thine own understanding";
        Scripture script = new Scripture(refer, "Trust in the Lord with all thine heart; and lean not unto thine own understanding");
        
        
        Console.WriteLine(refer.GetDisplayText());
        Console.WriteLine(script.GetDisplayText());
    }
}