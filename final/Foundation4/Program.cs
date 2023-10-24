using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        int i = -1;
        while (i != 5)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Running\n2. Cycling\n3. Swimming\n4. Get Summary of Activies\n5. Quit");
            Console.Write("What activity would you like to record? ");
            string user = Console.ReadLine();
            i = int.Parse(user);

            switch(i)
            {
                // Running
                case 1:
                // Try using 6.0 Distance in 60 minutes
                Console.WriteLine("What is the date of the activity? (Ex: 03 Oct 2023)");
                string date0 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString0 = Console.ReadLine();
                double length0 = double.Parse(lengthString0);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString0 = Console.ReadLine();
                float distance0 = float.Parse(distanceString0);

                Running running = new Running(date0, length0, distance0);
                _activities.Add(running);
                // Console.WriteLine(running.GetSummary());
                break;

                // Cycling
                case 2:
                // Try using 15.0 in 60 minutes
                
                Console.WriteLine("What is the date of the activity? (Ex: 03 Oct 2023)");
                string date1 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString1 = Console.ReadLine();
                double length1 = double.Parse(lengthString1);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString1 = Console.ReadLine();
                float distance1 = float.Parse(distanceString1);

                Cycling cycling = new Cycling(date1, length1, distance1);
                _activities.Add(cycling);
                // Console.WriteLine(cycling.GetSummary());
                break;

                // Swimming
                case 3:
                // Try using 40 or 50 laps in 60 mins
                Console.WriteLine("What is the date of the activity? (Ex: 03 Oct 2023)");
                string date2 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString2 = Console.ReadLine();
                double length2 = double.Parse(lengthString2);
                Console.WriteLine("How many laps did you swim? (Ex: 6)");
                string lapString2 = Console.ReadLine();
                int lap2 = int.Parse(lapString2);
                Swimming swim = new Swimming(date2, length2, lap2);
                _activities.Add(swim);
                // Console.WriteLine(swim.GetSummary());
                // swim.GetDistance();
                // swim.GetSpeed();
                // swim.GetPace();
                break;

                // GetSummary()
                case 4:
                Console.WriteLine();
                foreach (Activity activity in _activities)
                {
                    
                    Console.WriteLine(activity.GetSummary());
                }
                Console.WriteLine();
                break;
                // Quit
                case 5:
                break;
            }
        }
    }
}