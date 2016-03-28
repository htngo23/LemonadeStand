using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class WeatherWork 
    {
        Random random = new Random();

        Weather weather1 = new Weather(0);

        public int weatherNewDay()
        {
            weather1.weather = random.Next(0, 2);

            if (weather1.weather == 0)
            {
                Console.WriteLine("Today will be sunny... sell away!");
            }
            if (weather1.weather == 1)
            {
                Console.WriteLine("Today will be rainy.  Perhaps business will be rough today..");
            }
            return weather1.weather;

        }

        // the higher the weather number the harsher the weather
    }
}
    

