using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private string _name;
    private string _street;
    private string _city;
    private string _stateProvidence;
    private string _country;
    private string _productName;
    private double _price;
    private int _quantity;
    List<Product> _products = new List<Product>();

    public Order()
    {

    }

    public void DisplayShipping()
    {
        Customer customer = new Customer(_name);
        Address address = new Address(_street, _city, _stateProvidence, _country);
        customer.Display();
        address.Display();
    }

    public void DisplayPacking()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.PackingLable()}");
        }
    }

    public void CreateProduct()
    {
        Console.WriteLine("What is your name?");
        _name = Console.ReadLine();

        Console.WriteLine("Please answer the following questions about your address: ");

        Console.WriteLine("What is your street address? (Ex: 123 Maple Sreet)");
        _street = Console.ReadLine();

        Console.WriteLine("What is the name of the city? ");
        _city = Console.ReadLine();

        Console.WriteLine("What is the name of State/Providence? ");
        _stateProvidence = Console.ReadLine();

        Console.WriteLine("What is the name of the country? (Please type United States, if applicable)");
        _country = Console.ReadLine();

        Customer customer = new Customer(_name);
        Address address = new Address(_street, _city, _stateProvidence, _country);

        int i = 0;
        while (i < 3)
        {
            Console.WriteLine("What is the name of the product? ");
            _productName = Console.ReadLine();
            Console.WriteLine("What is the price of the product? ");
            string priceString = Console.ReadLine();
            _price = double.Parse(priceString);
            Console.WriteLine("What is the quantity of the product? ");
            string quantityString = Console.ReadLine();
            _quantity = int.Parse(quantityString);
            Product product = new Product(_productName, _price, _quantity);
            _products.Add(product);
            i++;
        }

        
        
    }

    public void CalculatePay()
    {
        double total = 0;
        Address address = new Address(_street, _city, _stateProvidence, _country);
        if (_country != "United States")
        {
            foreach (Product product in _products)
            {
                total += product.CalculatePrice();
            }
            total += 35;
        }
        else
        {
            foreach (Product product in _products)
            {
                total += product.CalculatePrice();
            }
            total += 5;
        }
        Console.WriteLine($"Total Price: {Math.Round(total, 2)}");
    }
 
}