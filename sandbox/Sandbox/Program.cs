using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Person p0 = new Person();
        p0.setFirst("Jonathan");
        Console.WriteLine(p0.getFirst());
    }
}
public class Person
{
    private string _firstName;
    public void setFirst(string firstname)
    {
        _firstName = firstname;
    }
    public string getFirst()
    {
        return _firstName;
    }

}