using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string Username = PromptUserName();
        int FavNumber = PromptUserNumber();
        int square = SquareNumber(FavNumber);
        DisplayResult(Username, square);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favorite = Console.ReadLine();
        int num = int.Parse(favorite);

        return num;
    }

    static int SquareNumber(int num)
    {
        int square = num * num;

        return square;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}