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
        order1.DisplayPacking();
        order1.DisplayShipping();
        order1.CalculatePay();
        Console.WriteLine("Order 2: ");
        order2.DisplayPacking();
        order2.DisplayShipping();
        order2.CalculatePay();

    }
}