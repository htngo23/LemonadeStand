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

        public void test()
       {   forecast.weatherNewDay();
           stock.setPrice();
           patron.addCustomer(); //this should only be in once 
           stock.purchaseGoods();
            stock.setFlavor();  //setting lemonade.flavortaste here
           patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal1(); // this method should be customized for specific days (7)

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();            
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal2();

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal3();

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal4();

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal5();

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal6();

            Console.ReadLine();

            stock.resetDailySales();
            forecast.weatherNewDay();
            stock.setPrice();
            stock.purchaseGoods();
            stock.setFlavor();
            patron.passOrBuy(stock.lemonade, forecast.weather1);
            stock.printTotal7();

            stock.printWeekly();

        }
    }
}
