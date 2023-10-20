using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvidence;
    private string _country;
 

    public Address(string street, string city, string stateProvidence, string country)
    {
        _street = street;
        _city = city;
        _stateProvidence = stateProvidence;
        _country = country;
    }

    public void Display()
    {
        string text = $"Address: \n{_street}, {_city}, {_stateProvidence}, {_country}";
        Console.WriteLine(text);
    }

    public bool IsNotForeign()
    {
        return true;
    }
        
}