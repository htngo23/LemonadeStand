using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

      

        Ice ice = new Ice(.05, 0);
        Sugar sugar = new Sugar(.2, 0);
        Lemons lemon = new Lemons(.55, 0);
        PaperCup paperCups = new PaperCup(.10, 0);
        public theDrink lemonade = new theDrink(0, 0, 0, 0, 0, 1);
        Player gucci = new Player(200, "Gucci Mane");




        public double setPrice()
        {
            Console.WriteLine("Set the price for a cup of lemonade");
            lemonade.priceDrink = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" The price of lemonade per cup is:  $" + lemonade.priceDrink);
            return lemonade.priceDrink;
        }
        public void subtractItems()
        {
            paperCups.quantity -= lemonade.cups;
            lemon.quantity -= lemonade.lemons;
            ice.quantity -= lemonade.ice;
            sugar.quantity -= lemonade.sugar;
        }
        public double purchaseMade()
        {
            if ((paperCups.quantity >= lemonade.cups) && (lemon.quantity >= lemonade.lemons) && (ice.quantity >= lemonade.ice) && (sugar.quantity >= lemonade.sugar))
            {
                Console.WriteLine("You have made a sale!");
                gucci.money += lemonade.priceDrink;
                subtractItems();
            }
            else
            {
                Console.WriteLine("Not enough sufficient supplies");
            }
            return gucci.money;
        }

        public void printTotal1()
        {
            Console.WriteLine("The total of Day 1 are : $" + gucci.money);
        }
        public void printTotal2()
        {
            Console.WriteLine("The total of Day 2 are : $" + gucci.money);
        }
        public void printTotal3()
        {
            Console.WriteLine("The total of Day 3 are : $" + gucci.money);
        }
        public void printTotal4()
        {
            Console.WriteLine("The total of Day 4 are : $" + gucci.money);
        }
        public void printTotal5()
        {
            Console.WriteLine("The total of Day 5 are : $" + gucci.money);
        }
        public void printTotal6()
        {
            Console.WriteLine("The total of Day 6 are : $" + gucci.money);
        }
        public void printTotal7()
        {
            Console.WriteLine("The total of Day 7 are : $" + gucci.money);
        }

        public int purchaseGoods()
        {
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("You have $" + gucci.money);

                Console.WriteLine("Press (1) to buy Paper Cups at 10 cents/cup");
                Console.WriteLine("Current have: " + paperCups.quantity + "cups");
                Console.WriteLine("Press (2) to buy Lemons at 55 cents/lemon");
                Console.WriteLine("Current have: " + lemon.quantity + "lemons");
                Console.WriteLine("Press (3) to buy Ice at 5 cents/ice cube");
                Console.WriteLine("Current have: " + ice.quantity + "ice");
                Console.WriteLine("Press (4) to buy Sugar 20 cents/sugar unit");
                Console.WriteLine("Current have: " + sugar.quantity + "sugar");
                Console.WriteLine("Press (5) to exit");
                string inputs = Console.ReadLine();
                switch (inputs)
                {
                    case "1":
                        buyPaperCups();
                        break;
                    case "2":
                        buyLemon();
                        useLemon();
                        break;
                    case "3":
                        buyIce();
                        useIce();
                        break;
                    case "4":
                        buySugar();
                        useSugar();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        return purchaseGoods();
                        
                }
            }
            return 0;
        }

      

        public void buyPaperCups()
        {
            Console.WriteLine("How many paper cups would you like to buy?");
            int amountCups = Convert.ToInt32(Console.ReadLine());
            double cupsTotalCost = amountCups * paperCups.ingredientCost;
            if (gucci.money > cupsTotalCost)
            {
                paperCups.quantity += amountCups;
                gucci.money -= cupsTotalCost;
                Console.WriteLine("You now have: " + paperCups.quantity + " papercups total");
                Console.WriteLine("You have $" + gucci.money + " remaining");
            }
            else
            {
                Console.WriteLine("Not enough money to buy cups...");
            }
        }

        public int buyIce()
        {
            Console.WriteLine("How many ice would you like to buy?");
            int amountIce = Convert.ToInt32(Console.ReadLine());
            double iceTotalCost = amountIce * ice.ingredientCost;
            if (gucci.money > iceTotalCost)
            {
                ice.quantity += amountIce;
                gucci.money -= iceTotalCost;
                Console.WriteLine("You now have: " + ice.quantity + " ice total");
                Console.WriteLine("You have $" + gucci.money + " remaining");
            }
            else
            {
                Console.WriteLine("Not enough money to buy ice...");
            }
            return ice.quantity;
        }

        public int useIce()
        {
            Console.WriteLine("How much ice would you like to use per cup of Lemonade?");
            int amountIce = Convert.ToInt32(Console.ReadLine());
            if(ice.quantity > 0)
            {
                lemonade.ice += amountIce;  
                Console.WriteLine("You will use " + lemonade.ice + " Ice/cup");
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
            double sugarTotalCost = amountSugar * sugar.ingredientCost;
            if (gucci.money > sugarTotalCost)
            {
                sugar.quantity += amountSugar;
                gucci.money -= sugarTotalCost;
                Console.WriteLine("You now have: " + sugar.quantity + " sugar total");
                Console.WriteLine("You have $" + gucci.money + " remaining");
            }
            else
            {
                Console.WriteLine("Not enough money to buy sugar");
            }
        }

        public int useSugar()
        {
            Console.WriteLine("How much sugar would you like to use per cup of Lemonade?");
            int amountSugar = Convert.ToInt32(Console.ReadLine());
            if (sugar.quantity > 0)
            {
                lemonade.sugar += amountSugar;
                Console.WriteLine("You will use " + lemonade.sugar + " sugar/cup");
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
            double lemonTotalCost = amountLemon * lemon.ingredientCost;
            if (gucci.money > lemonTotalCost)
            {
                lemon.quantity += amountLemon;
                gucci.money -= lemonTotalCost;
                Console.WriteLine("You now have: " + lemon.quantity + " lemon total");
                Console.WriteLine("You have $" + gucci.money + " remaining");
            }
            else
            {
                Console.WriteLine("Not enough money to buy lemons....");
            }
        }
        public int useLemon()
        {
            Console.WriteLine("How much lemon would you like to use per cup of Lemonade?");
            int amountLemon = Convert.ToInt32(Console.ReadLine());
            if (lemon.quantity > 0)
            {
                lemonade.lemons += amountLemon;
                Console.WriteLine("You will use " + lemonade.lemons + " lemons/cup");
            }
            else if (lemon.quantity <= 0)
            {
                Console.WriteLine("Go buy more lemon");
            }
            return lemon.quantity;
        }
    }
}
