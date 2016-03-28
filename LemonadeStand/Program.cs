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

            forecast.weatherNewDay();
            

            Console.ReadLine();
            //stock.buyLemon();
            

        }
    }
}
