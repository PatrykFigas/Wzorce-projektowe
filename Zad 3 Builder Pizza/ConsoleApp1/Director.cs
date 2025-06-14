using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Director
    {
        public void Construct(IPizzaBuilder builder)
        {
            builder.AddDough();
            builder.AddMeat();
            builder.AddCheese();
            builder.AddVegetables();
            builder.AddSpices();
        }
    }
}
