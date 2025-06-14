using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Interfejs budowniczego
    interface IPizzaBuilder
    {
        void AddDough();
        void AddMeat();
        void AddCheese();
        void AddVegetables();
        void AddSpices();
        Pizza GetPizza();
    }
}
