using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        while (input != 5)
        {
            Console.WriteLine("Please select one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            Console.Write("> ");
            string user = Console.ReadLine();
            input = int.Parse(user);
            string file;

            Journal journal = new Journal();
            Entry newEntry = new Entry();


            switch (input)
            {
                case 1:
                journal.AddEntry(newEntry);
                break;

                case 2:
                journal.DisplayAll();
                break;

                case 3:
                Console.WriteLine("Load");
                Console.WriteLine("What do you want to name filename?");
                file = Console.ReadLine();
                journal.LoadFromFile(file);
                break;

                case 4:
                Console.WriteLine("What do you want to name filename?");
                file = Console.ReadLine();
                journal.SaveToFile(file);
                break;

                case 5:
                break;
            }
        } 
        
        





    }
}