using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        // Dodaje 2 zł do ceny i rozszerza opis
        public override double GetCost() => base.GetCost() + 2.0;
        public override string GetDescription() => base.GetDescription() + ", Milk";
    }
}
