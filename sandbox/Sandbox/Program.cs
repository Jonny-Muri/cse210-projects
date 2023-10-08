using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        string name = student.GetName();
        string num = student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(num);
    }

    public class Person
    {
        public string GetName()
        {
            return "Johnny";
        }

    }
    public class Student : Person
    {
        public string GetNumber()
        {
            return "058794622";
        }
    }

}
