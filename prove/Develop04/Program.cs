using System;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        while (input != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string user = Console.ReadLine();
            input = int.Parse(user);

            

            switch (input)
            {
                case 1:
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;
            }



        }
    }
}