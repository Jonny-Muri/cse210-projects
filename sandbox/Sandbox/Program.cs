using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        SalaryEmployee salary = new SalaryEmployee();
        HourlyEmployee hourly = new HourlyEmployee();
        Console.WriteLine(salary.CalculatePay());
        Console.WriteLine(hourly.CalculatePay());
    }
    public abstract class Employee
    {
        protected string _name;
        public abstract float CalculatePay();
    }
    public class SalaryEmployee : Employee
    {
        private float _salary = 1000f;
        public override float CalculatePay()
        {
            return _salary;
        }
    }
    public class HourlyEmployee : Employee
    {
        private float _rate = 9f;
        private float _hours = 100f;
        public override float CalculatePay()
        {
            return _rate * _hours;
        }
    }
}
