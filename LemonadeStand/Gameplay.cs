using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Gameplay
    {
        Inventory stock = new Inventory();
        WeatherWork forecast = new WeatherWork();
        CustomerSkeleton frame;
        Customer patron;
        public Gameplay()
        {
            patron = new Customer(stock);
            
        }
        public void printIntro()
        {
            Console.WriteLine("You have 50 patrons to cater to... Be mindful of your prices and quanity of items you put into lemonade");
            Console.WriteLine("Cost of item inputs will vary on the daily");
            Console.WriteLine("Find the receipe to knock your customers off their feet!");
        }

        public void core()
        {
            printIntro();
            Console.WriteLine("Press enter");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Sunday");
            forecast.weatherNewDay();
           patron.addCustomer(); //this should only be in once 
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();  //setting lemonade.flavortaste here
           patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal1(); // this method should be customized for specific days (7)

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Monday *sigh*");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal2();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Tuesday");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal3();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hump Day");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal4();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Thursday!!!");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal5();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("It's FRIDAY FRIDAY FRIDAY");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal6();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Saturday... Final Day");
            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.randomizePrice();
            stock.purchaseGoods();
            stock.setPrice();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal7();

            stock.printWeekly();

        }
    }
}
