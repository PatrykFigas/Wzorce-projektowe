using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pizza
    {
        private List<string> ingredients = new List<string>();

        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }

        public override string ToString()
        {
            return "Pizza z: " + string.Join(", ", ingredients);
        }
    }
}
