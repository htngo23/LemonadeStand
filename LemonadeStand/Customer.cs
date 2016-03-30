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
        CustomerSkeleton customer2 = new CustomerSkeleton(0, 1, 2.25);   // 2) tastePreference = 5
        CustomerSkeleton customer3 = new CustomerSkeleton(1, 0, 5.2);        //3) "" = 3
        CustomerSkeleton customer4 = new CustomerSkeleton(0, 3, 2.25);       //4) "" = 1
        CustomerSkeleton customer5 = new CustomerSkeleton(1, 0, 1.5);       //5) "" = 0 then they will drink whatever
        CustomerSkeleton customer6 = new CustomerSkeleton(1, 5, 1.25);
        CustomerSkeleton customer7 = new CustomerSkeleton(1, 4, .9);
        CustomerSkeleton customer8 = new CustomerSkeleton(0, 4, 5.1);
        CustomerSkeleton customer9 = new CustomerSkeleton(0, 3, 3.25);
        CustomerSkeleton customer10 = new CustomerSkeleton(0, 0, 1.25);
        CustomerSkeleton customer11= new CustomerSkeleton(1, 0, 1.5);
        CustomerSkeleton customer12 = new CustomerSkeleton(1, 0, 3.25);
        CustomerSkeleton customer13 = new CustomerSkeleton(1, 5, 5);
        CustomerSkeleton customer14 = new CustomerSkeleton(1, 0, 4);
        CustomerSkeleton customer15 = new CustomerSkeleton(0, 4, 4);
        CustomerSkeleton customer16 = new CustomerSkeleton(1, 3, 5);
        CustomerSkeleton customer17 = new CustomerSkeleton(0, 0, 3.5);
        CustomerSkeleton customer18 = new CustomerSkeleton(1, 5, 3.5);
        CustomerSkeleton customer19 = new CustomerSkeleton(0, 0, 1.25);
        CustomerSkeleton customer20 = new CustomerSkeleton(1, 5, 2.25);
        CustomerSkeleton customer21 = new CustomerSkeleton(1, 4, 1.9);
        CustomerSkeleton customer22 = new CustomerSkeleton(0, 4, 4.1);
        CustomerSkeleton customer23 = new CustomerSkeleton(0, 3, 2.25);
        CustomerSkeleton customer24 = new CustomerSkeleton(0, 3, 3.25);
        CustomerSkeleton customer25 = new CustomerSkeleton(1, 0, 1.5);
        CustomerSkeleton customer26 = new CustomerSkeleton(0, 1, .85);
        CustomerSkeleton customer27 = new CustomerSkeleton(0, 1, 3.1);
        CustomerSkeleton customer28 = new CustomerSkeleton(1, 3, 2.25);
        CustomerSkeleton customer29 = new CustomerSkeleton(0, 0, 1.25);
        CustomerSkeleton customer30 = new CustomerSkeleton(1, 3, 1.5);
        CustomerSkeleton customer31 = new CustomerSkeleton(0, 0, 2.25);
        CustomerSkeleton customer32 = new CustomerSkeleton(1, 5, 1.25);
        CustomerSkeleton customer33 = new CustomerSkeleton(1, 4, 3.9);
        CustomerSkeleton customer34 = new CustomerSkeleton(0, 1, 1.1);
        CustomerSkeleton customer35 = new CustomerSkeleton(0, 3, 3.25);
        CustomerSkeleton customer36 = new CustomerSkeleton(0, 3, 1.25);
        CustomerSkeleton customer37 = new CustomerSkeleton(1, 1, 1.5);
        CustomerSkeleton customer38 = new CustomerSkeleton(0, 0, .25);
        CustomerSkeleton customer39 = new CustomerSkeleton(0, 0, 3.1);
        CustomerSkeleton customer40 = new CustomerSkeleton(1, 0, 2.25);
        CustomerSkeleton customer41 = new CustomerSkeleton(0, 0, 1.25);
        CustomerSkeleton customer42 = new CustomerSkeleton(1, 3, 4.5);
        CustomerSkeleton customer43 = new CustomerSkeleton(0, 0, 2.25);
        CustomerSkeleton customer44 = new CustomerSkeleton(1, 5, 1.25);
        CustomerSkeleton customer45 = new CustomerSkeleton(1, 4, 5.9);
        CustomerSkeleton customer46 = new CustomerSkeleton(0, 1, 2.1);
        CustomerSkeleton customer47 = new CustomerSkeleton(0, 0, 3.25);
        CustomerSkeleton customer48 = new CustomerSkeleton(0, 3, 2.25);
        CustomerSkeleton customer49 = new CustomerSkeleton(1, 0, 3.5);
        CustomerSkeleton customer50 = new CustomerSkeleton(0, 0, .75);


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
            customerList.Add(customer13);
            customerList.Add(customer14);
            customerList.Add(customer15);
            customerList.Add(customer16);
            customerList.Add(customer17);
            customerList.Add(customer18);
            customerList.Add(customer19);
            customerList.Add(customer20);
            customerList.Add(customer21);
            customerList.Add(customer22);
            customerList.Add(customer23);
            customerList.Add(customer24);
            customerList.Add(customer25);
            customerList.Add(customer26);
            customerList.Add(customer27);
            customerList.Add(customer28);
            customerList.Add(customer29);
            customerList.Add(customer30);
            customerList.Add(customer31);
            customerList.Add(customer32);
            customerList.Add(customer33);
            customerList.Add(customer34);
            customerList.Add(customer35);
            customerList.Add(customer36);
            customerList.Add(customer37);
            customerList.Add(customer38);
            customerList.Add(customer39);
            customerList.Add(customer40);
            customerList.Add(customer41);
            customerList.Add(customer42);
            customerList.Add(customer43);
            customerList.Add(customer44);
            customerList.Add(customer45);
            customerList.Add(customer46);
            customerList.Add(customer47);
            customerList.Add(customer48);
            customerList.Add(customer49);
            customerList.Add(customer50);

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
        











