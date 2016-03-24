using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : items
    {
        public Lemons(double IngredientCost, int Quantity)
        {
            ingredientCost = IngredientCost;
            quantity = Quantity;
        }
    }
}
