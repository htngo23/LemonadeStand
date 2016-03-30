using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        Inventory stock;

        public Customer(Inventory Stock)
        {
            stock = Stock;
        }

        public List<CustomerSkeleton> customerList = new List<CustomerSkeleton>();
        
        CustomerSkeleton customer1 = new CustomerSkeleton(1, 1, 1.5);   //need most of tastePreference = 4
        CustomerSkeleton customer2 = new CustomerSkeleton(0, 1, .25);   // 2) tastePreference = 5
        CustomerSkeleton customer3 = new CustomerSkeleton(1, 0, .2);        //3) "" = 3
        CustomerSkeleton customer4 = new CustomerSkeleton(0, 3, .25);       //4) "" = 1
        CustomerSkeleton customer5 = new CustomerSkeleton(1, 3, 1.5);       //5) "" = 0 then they will drink whatever
        CustomerSkeleton customer6 = new CustomerSkeleton(1, 5, 1.25);
        CustomerSkeleton customer7 = new CustomerSkeleton(1, 4, .9);
        CustomerSkeleton customer8 = new CustomerSkeleton(0, 4, .1);
        CustomerSkeleton customer9 = new CustomerSkeleton(0, 3, .25);
        CustomerSkeleton customer10 = new CustomerSkeleton(0, 3, 1.25);
        CustomerSkeleton customer11= new CustomerSkeleton(1, 0, 1.5);
        CustomerSkeleton customer12 = new CustomerSkeleton(0, 0, .25);

        public void addCustomer()
        {
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            customerList.Add(customer6);
            customerList.Add(customer7);
            customerList.Add(customer8);
            customerList.Add(customer9);
            customerList.Add(customer10);
            customerList.Add(customer11);
            customerList.Add(customer12);

        }
            

        public void passOrBuy(theDrink lemonade, Weather weather1)

        {

            
            foreach (CustomerSkeleton x in customerList)
            {
                if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == weather1.weatherToday) && (lemonade.flavorType == 2))
                {
                    stock.purchaseMade();

                }
                else  if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == 1) && (lemonade.flavorType == 2))
                {
                    stock.purchaseMade();

                }
                else if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == weather1.weatherToday) && (x.tastePreference == 0))
                {
                    stock.purchaseMade();

                }
                else if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == 1) && (x.tastePreference == 0))
                {
                    stock.purchaseMade();

                }
                else if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == weather1.weatherToday) && (x.tastePreference == lemonade.flavorType))
                {
                    stock.purchaseMade();

                }
                else if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == 1) && (x.tastePreference == lemonade.flavorType))
                {
                    stock.purchaseMade();

                }

                else
                {
                    Console.WriteLine("No purchase by this customer...");
                }
            }
            
        }

    }
} 
        











