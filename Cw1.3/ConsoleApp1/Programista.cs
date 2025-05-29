using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Programista : Employee
    {
        public Programista(string name, int id, double hoursWorked) : base(name, id, hoursWorked)
        {
        }
        public override double ObliczWyplate()
        {
            return HoursWorked * 120;
        }       
    }
}
