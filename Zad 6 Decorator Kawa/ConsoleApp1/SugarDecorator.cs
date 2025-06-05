using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // DODATEK: Cukier
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        // Dodaje 1 zł do ceny i rozszerza opis
        public override double GetCost() => base.GetCost() + 1.0;
        public override string GetDescription() => base.GetDescription() + ", Sugar";
    }
}
