using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicles
    {
        public string Name;
        public string Manufacturer;
        public int Id;
        public double Mileage;
        public int Years;
        public void read()
        {
            Console.WriteLine("Wprowadź nazwę auta:");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wprowadź producenta:");
            Manufacturer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wprowadź ID auta:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź przebieg auta:");
            Mileage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wprowadź rok produkcji auta:");
            Years = Convert.ToInt32(Console.ReadLine());

        }
        public void show()
        {
            Console.WriteLine($"Nazwa auta: {Name}\nPochodzenie: {Manufacturer}\nId: {Id}\nPrzebieg: {Mileage}\nRok produkcji {Years}");
            Console.ReadKey();
        }
    }
}
