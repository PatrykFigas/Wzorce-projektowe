using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cars : Vehicles
    {
        public string Color;
        public string Engine;

        public void read1()
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
            Console.WriteLine("Podaj jaki ma silnik:");
            Engine = Console.ReadLine();
            Console.WriteLine("Jaki kolor samochodu?");
            Color = Console.ReadLine();
        }
        public void show1()
        {
            Console.WriteLine($"Nazwa auta: {Name}\nPochodzenie: {Manufacturer}\nId: {Id}\nPrzebieg: {Mileage}\nRok produkcji {Years}\nSilnik: {Engine}\nKolor: {Color}");
            Console.ReadKey();
        }
    }
}
