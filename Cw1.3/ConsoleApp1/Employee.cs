using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {       
        public string Name { get; set; }
        public int Id { get; set; }
        public double HoursWorked { get; set; }

        public Employee(string name, int id, double hoursWorked)
        {
            Name = name;
            Id = id;
            HoursWorked = hoursWorked;
        }
        public virtual double ObliczWyplate()
        {
            return HoursWorked * 100;
        }
        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"ID: {Id}, Imię: {Name}, Godziny: {HoursWorked}");
        }
    }
}
