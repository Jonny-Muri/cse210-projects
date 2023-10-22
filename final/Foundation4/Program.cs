using System;

class Program
{
    static void Main(string[] args)
    {
        int i = -1;
        while (i != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Running\n2. Cycling\n3. Swimming\n4. Quit");
            Console.Write("What activity would you like to record? ");
            string user = Console.ReadLine();
            i = int.Parse(user);

            switch(i)
            {
                // Running
                case 1:
                break;
                // Cycling
                case 2:
                break;
                // Swimming
                case 3:
                Console.WriteLine("What is the date of the activity? (Ex: 03 Nov 2022)");
                string date = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString = Console.ReadLine();
                double length = double.Parse(lengthString);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString = Console.ReadLine();
                float distance = float.Parse(distanceString);
                Console.WriteLine("How many laps did you swim? (Ex: 6)");
                string lapString = Console.ReadLine();
                int lap = int.Parse(lapString);
                Swimming swim = new Swimming(date, length, distance, lap);
                Console.WriteLine(swim.GetSummary());
                swim.GetDistance();
                swim.GetSpeed();
                swim.GetPace();
                break;
                //Quit
                case 4:
                break;
            }
        }
    }
}