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

        public Weather weather1 = new Weather(0);

        public int weatherNewDay()
        {
            weather1.weatherToday = random.Next(0, 2);

            if (weather1.weatherToday == 0)
            {
                Console.WriteLine("Today will be sunny... sell away!");
            }
            if (weather1.weatherToday == 1)
            {
                Console.WriteLine("Today will be rainy.  Perhaps business will be rough today..");
            }
            return weather1.weatherToday;

        }

        // the higher the weather number the harsher the weather
    }
}
    

