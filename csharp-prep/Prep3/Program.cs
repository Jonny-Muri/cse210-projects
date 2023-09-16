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

        if(guess > magic)
        {
            Console.WriteLine("Lower");
        }
        else if (guess <magic)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed correctly!");
        }

    }
}