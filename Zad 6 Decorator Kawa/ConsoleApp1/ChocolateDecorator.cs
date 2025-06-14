using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // DODATEK: Czekolada
    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        // Dodaje 3 zł do ceny i rozszerza opis
        public override double GetCost() => base.GetCost() + 3.0;
        public override string GetDescription() => base.GetDescription() + ", Chocolate";
    }

}
