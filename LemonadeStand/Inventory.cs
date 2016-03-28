using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

      

        Ice ice = new Ice(.25, 0);
        Sugar sugar = new Sugar(1, 0);
        Lemons lemon = new Lemons(1.5, 0);
        PaperCup paperCups = new PaperCup(.05, 0);
        theDrink lemonade = new theDrink(0, 0, 0, 0, 0, 0);
        Player gucci = new Player(20.50, "Gucci Mane");




        public double setPrice()
        {
            Console.WriteLine("Set the price for a cup of lemonade");
            lemonade.priceDrink = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" The price of lemonade per cup is:  $" + lemonade.priceDrink);
            return lemonade.priceDrink;
        }


        //public void makeDrink()
        //{             HERE YOU WILL COMBIME ALL OF THE "USE" fuctions in order to make 1 lemonade drink
        //    Console.WriteLine(");
        //}

        public void buyPaperCups()
        {
            Console.WriteLine("How many paper cups would you like to buy?");
            int amountCups = Convert.ToInt32(Console.ReadLine());
            paperCups.quantity += amountCups;
            double cupsTotalCost = amountCups * paperCups.ingredientCost;
            gucci.money -= cupsTotalCost;
            Console.WriteLine("You now have: " + paperCups.quantity + " papercups total");
            Console.WriteLine("You have $" + gucci.money + " remaining");
        }

        public int buyIce()
        {
            Console.WriteLine("How many ice would you like to buy?");
            int amountIce = Convert.ToInt32(Console.ReadLine());
            ice.quantity += amountIce;
            double iceTotalCost = amountIce * ice.ingredientCost;
            gucci.money -= iceTotalCost;
            Console.WriteLine("You now have: " + ice.quantity + " ice total");
            Console.WriteLine("You have $" + gucci.money + " remaining");
            return ice.quantity;
        }

        public int useIce()
        {
            Console.WriteLine("How much ice would you like to use per cup of Lemonade?");
            int amountIce = Convert.ToInt32(Console.ReadLine());
            if(ice.quantity > 0)
            {
                lemonade.ice += amountIce;
                ice.quantity -= amountIce;
                Console.WriteLine("You currently have " + ice.quantity + "remaining");
            }
            else if(ice.quantity <= 0)
            {
                Console.WriteLine("Go buy more ice");
            }
            return ice.quantity;
        }

        public void buySugar()
        {
            Console.WriteLine("How many sugar would you like to buy?");
            int amountSugar = Convert.ToInt32(Console.ReadLine());
            sugar.quantity += amountSugar;
            double sugarTotalCost = amountSugar * sugar.ingredientCost;
            gucci.money -= sugarTotalCost;
            Console.WriteLine("You now have: " + sugar.quantity + " sugar total");
            Console.WriteLine("You have $" + gucci.money + " remaining");
        }

        public int useSugar()
        {
            Console.WriteLine("How much sugar would you like to use per cup of Lemonade?");
            int amountSugar = Convert.ToInt32(Console.ReadLine());
            if (sugar.quantity > 0)
            {
                lemonade.ice += amountSugar;
                ice.quantity -= amountSugar;
                Console.WriteLine("You currently have " + sugar.quantity + "remaining");
            }
            else if (sugar.quantity <= 0)
            {
                Console.WriteLine("Go buy more sugar");
            }
            return sugar.quantity;
        }

        public void buyLemon()
                
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int amountLemon = Convert.ToInt32(Console.ReadLine());
            lemon.quantity += amountLemon;
            double lemonTotalCost = amountLemon * lemon.ingredientCost;
            gucci.money -= lemonTotalCost;
            Console.WriteLine("You now have: " + lemon.quantity + " lemon total");
            Console.WriteLine("You have $" + gucci.money + " remaining");
        }
        public int useLemon()
        {
            Console.WriteLine("How much lemon would you like to use per cup of Lemonade?");
            int amountLemon = Convert.ToInt32(Console.ReadLine());
            if (lemon.quantity > 0)
            {
                lemonade.lemons += amountLemon;
                lemon.quantity -= amountLemon;
                Console.WriteLine("You currently have " + lemon.quantity + "remaining");
            }
            else if (lemon.quantity <= 0)
            {
                Console.WriteLine("Go buy more lemon");
            }
            return lemon.quantity;
        }
    }
}
