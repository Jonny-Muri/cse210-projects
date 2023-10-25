using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Order order2 = new Order();
        Console.WriteLine("Fill information for Order 1");
        order1.CreateProduct();
        Console.WriteLine("\nFill information for Order 2");
        order2.CreateProduct();

        Console.WriteLine("Order 1: ");
        Console.WriteLine("Packing Label:");
        order1.DisplayPacking();
        Console.WriteLine("Shipping Label:");
        order1.DisplayShipping();
        order1.CalculatePay();

        Console.WriteLine();
        
        Console.WriteLine("Order 2: ");
        Console.WriteLine("Packing Label:");
        order2.DisplayPacking();
        Console.WriteLine("Shipping Label:");
        order2.DisplayShipping();
        order2.CalculatePay();

    }
}