using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string breathStart = "Welcome to the Breathing Activty";
        string breathEnd = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
        string relfectStart = "Welcome to the Reflecting Activity";
        string reflectEnd = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThie will help you recognize the power you have and how you can use it in other aspects of your life";
        string listStart = "Welcome to the Listing Activity.";
        string listEnd = "This activity will help you reflect on the good things in your life by having you list as many things as you can do in a certain area.";
        
        int input = -1;
        string user;
        // BreathingActivity breath = new BreathingActivity(breathStart, breathEnd);
        // ListingActivity listing = new ListingActivity(listStart, listEnd);
        // ReflectingActivity reflect = new ReflectingActivity(relfectStart,reflectEnd);
        while (input != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
            input = int.Parse(user);

            Console.Clear();

            switch (input)
            {

                //Breathing Activity
                case 1:
                BreathingActivity breath = new BreathingActivity(breathStart, breathEnd, input);

                breath.Run();
                break;

                //Reflecting Activity
                case 2:
                ReflectingActivity reflect = new ReflectingActivity(relfectStart,reflectEnd, input);

                reflect.Run();
                break;

                //Listing Activity
                case 3:
                ListingActivity listing = new ListingActivity(listStart, listEnd, input);

                listing.Run();
                break;

                //Quit
                case 4:
                break;
            }
        }
    }
}