using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConcretePizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void AddDough()
        {
            pizza.AddIngredient("ciasto");
        }

        public void AddMeat()
        {
            pizza.AddIngredient("salami");
        }

        public void AddCheese()
        {
            pizza.AddIngredient("ser mozzarella");
        }

        public void AddVegetables()
        {
            pizza.AddIngredient("papryka");
        }

        public void AddSpices()
        {
            pizza.AddIngredient("oregano");
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
