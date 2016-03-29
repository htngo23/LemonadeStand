using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory stock = new Inventory();
            WeatherWork forecast = new WeatherWork();
            Customer patron = new Customer(stock);
            Gameplay gameplay = new Gameplay();

            //stock.setPrice();
            //forecast.weatherNewDay();
            //patron.passOrBuy(stock.lemonade, forecast.weather1);

            gameplay.test();

            

            Console.ReadLine();
            //stock.buyLemon();
            

        }
    }
}
