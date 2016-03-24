using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class theDrink : items
    {
        public theDrink(double PriceDrink, int Quantity, int Lemons, int Ice, int Sugar, int Cups)
        {
            priceDrink = PriceDrink;
            quantity = Quantity;
            lemons = Lemons;
            ice = Ice;
            sugar = Sugar;
            cups = Cups;
        }

    }
}
