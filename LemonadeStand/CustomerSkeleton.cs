using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerSkeleton
    {
       

        // have a function that calclates chance to buy.  then pass in stance of weather to calculate whether theyll buy.  


       public int weatherPreference;
       public int tastePreference;
       public double pricePreference;

        public CustomerSkeleton(int WeatherPreference, int TastePreference, double PricePreference)
        {
            weatherPreference = WeatherPreference;
            tastePreference = TastePreference;
            pricePreference = PricePreference;
        }
        
        
    }

}
