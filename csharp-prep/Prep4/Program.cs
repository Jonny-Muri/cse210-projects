using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        
        int input = -1;

        //User Input
        while(input != 0)
        {
            Console.Write("Enter a Number (Type 0 to quit): ");
            string response = Console.ReadLine();
            input = int.Parse(response);

            if(input != 0)
            {
                number.Add(input);
            }
        }

        //Addition
        int sum = 0;
        foreach(int num in number)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
        
        //Average
        float average = ((float)sum) / number.Count;
        Console.WriteLine($"The average is: {average}");

        //Max
        int max = number[0];

        foreach(int num in number)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is; {max}");


    }
}