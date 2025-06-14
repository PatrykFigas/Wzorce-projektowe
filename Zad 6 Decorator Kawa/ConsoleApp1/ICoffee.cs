using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // INTERFEJS ICoffee – definiuje wspólne operacje dla wszystkich napojów
    public interface ICoffee
    {
        double GetCost();              // Zwraca koszt napoju
        string GetDescription();       // Zwraca opis napoju
    }
}
