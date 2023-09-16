using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is the percentage of your grade?: ");
       string num = Console.ReadLine();
       int grade = int.Parse(num);
       string letter = "";

        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
         else if (grade >= 70)
        {
            letter = "C";
        }
         else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your letter grade is: {letter}");
    

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }   
}