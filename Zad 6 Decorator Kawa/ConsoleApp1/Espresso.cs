using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // KLASA ESPRESSO – podstawowa kawa bez dodatków
    public class Espresso : ICoffee
    {
        public double GetCost() => 10.0;                         // Cena bazowa
        public string GetDescription() => "Espresso";           // Opis bazowy
    }
}
