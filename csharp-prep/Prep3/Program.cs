using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string magicnum = Console.ReadLine();
        Console.Write("What is your guess? ");
        string guessnum = Console.ReadLine();

        int magic = int.Parse(magicnum);
        int guess = int.Parse(guessnum);

        while (guess < magic)
        {
            Console.WriteLine("Higher");
            break;
        }
        while (guess > magic)
        {
            Console.WriteLine("Lower");
            break;
        }
        while (guess == magic)
        {
            Console.WriteLine("You guess correctly!");
            break;
        }

    }
}