using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // ABSTRAKCYJNA KLASA DEKORATORA – zawiera referencję do innego obiektu ICoffee
    public abstract class CoffeeDecorator : ICoffee
    {
        // Składany napój (np. Espresso lub inny dekorator)
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        // Domyślnie przekazuje koszt do opakowanego obiektu
        public virtual double GetCost() => _coffee.GetCost();

        // Domyślnie przekazuje opis do opakowanego obiektu
        public virtual string GetDescription() => _coffee.GetDescription();
    }

}
