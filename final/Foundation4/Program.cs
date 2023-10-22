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
                Console.WriteLine("What is the date of the activity? (Ex: 03 Nov 2022)");
                string date0 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString0 = Console.ReadLine();
                double length0 = double.Parse(lengthString0);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString0 = Console.ReadLine();
                float distance0 = float.Parse(distanceString0);

                Running running = new Running(date0, length0, distance0);
                running.GetSummary();

                break;
                // Cycling
                case 2:
                Console.WriteLine("What is the date of the activity? (Ex: 03 Nov 2022)");
                string date1 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString1 = Console.ReadLine();
                double length1 = double.Parse(lengthString1);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString1 = Console.ReadLine();
                float distance1 = float.Parse(distanceString1);

                Cycling cycling = new Cycling(date1, length1, distance1);
                cycling.GetSummary();

                break;
                // Swimming
                case 3:
                Console.WriteLine("What is the date of the activity? (Ex: 03 Nov 2022)");
                string date2 = Console.ReadLine();
                Console.WriteLine("How long was it for in minutes? (Ex: 30)");
                string lengthString2 = Console.ReadLine();
                double length2 = double.Parse(lengthString2);
                Console.WriteLine("How far was the distance in miles? (Ex: 3.0)");
                string distanceString2 = Console.ReadLine();
                float distance2 = float.Parse(distanceString2);
                Console.WriteLine("How many laps did you swim? (Ex: 6)");
                string lapString2 = Console.ReadLine();
                int lap2 = int.Parse(lapString2);
                Swimming swim = new Swimming(date2, length2, distance2, lap2);
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