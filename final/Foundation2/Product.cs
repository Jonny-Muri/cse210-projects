using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private double _totalPrice;
    private int _quantity;
 
    public Product(string name, double price, int quantity)
    {
        _name = name;
        _productID = GenerateRandomID();
        _price = price;
        _quantity = quantity;
    }
    public double CalculatePrice()
    {
        return _totalPrice = _price * _quantity;
    }
    
    public string GenerateRandomID()
    {
        string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
        int length = 8;
        Random random = new Random();

        char[] productArray = new char[length];
        for (int i = 0; i < length; i++)
        {
            int randomIndex = random.Next(0, characters.Length);
            productArray[i] = characters[randomIndex];
        }

        string randomID = new string(productArray);
        return randomID;
    }
    public string PackingLable()
    {
        string text = $"Product Name: {_name}\nProduct ID: {_productID}";
        return text;
    }

}