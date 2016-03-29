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
        
        CustomerSkeleton customer1 = new CustomerSkeleton(1, 0, 1.5);
        CustomerSkeleton customer2 = new CustomerSkeleton(0, 0, .25);
        CustomerSkeleton customer3 = new CustomerSkeleton(1, 0, .2);
        CustomerSkeleton customer4 = new CustomerSkeleton(0, 0, .25);
        CustomerSkeleton customer5 = new CustomerSkeleton(1, 0, 1.5);
        CustomerSkeleton customer6 = new CustomerSkeleton(1, 0, 1.25);
        CustomerSkeleton customer7 = new CustomerSkeleton(1, 0, .9);
        CustomerSkeleton customer8 = new CustomerSkeleton(0, 0, .1);
        CustomerSkeleton customer9 = new CustomerSkeleton(0, 0, .25);
        CustomerSkeleton customer10 = new CustomerSkeleton(0, 0, 1.25);
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
                if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == 1))
                {
                    stock.purchaseMade();

                }
                else if ((x.pricePreference >= lemonade.priceDrink) && (x.weatherPreference == weather1.weatherToday))
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
        











