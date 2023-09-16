using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is the percentage of your grade?: ");
       string num = Console.ReadLine();
       int grade = int.Parse(num);

        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("Your letter grade is an A");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("Your letter grade is an B");
        }
         else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine("Your letter grade is an C");
        }
         else if (grade < 70 && grade >= 60)
        {
             Console.WriteLine("Your letter grade is an D");
        }
        else if (grade >= 0 && grade < 60)
        {
            Console.WriteLine("Your letter grade is an F");
        }
        else
        {
            Console.WriteLine("You have entered an incorrect value");
        }
    }
}