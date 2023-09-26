using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f0 = new Fraction();

        Fraction f1 = new Fraction(5);

        Fraction f2 = new Fraction(6,7);

        Fraction f3 = new Fraction(3,4);

        Fraction f4 = new Fraction();

        //Return Fraction as a string
        Console.WriteLine(f0.GetFractionString());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

        //Return Fraction as a decimal
        Console.WriteLine(f0.GetDecimalValue());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());

        //Testing the Setter and Getter
        f4.SetTop(4);
        f4.SetBottom(5);

        Console.WriteLine(f4.GetTop());
        Console.WriteLine(f4.GetBottom());
        

    }
}