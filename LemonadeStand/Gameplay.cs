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
            patron.addCustomer();
            //patron.customerCheck(stock.lemonade, forecast.weather1, frame);
           
           patron.passOrBuy(stock.lemonade, forecast.weather1);
        }
    }
}
