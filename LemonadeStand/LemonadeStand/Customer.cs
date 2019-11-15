using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        
        public int chanceToBuy;
        public int numberToCompare;
        
        
        

        Random rng;



        //constructor
        //give every customer money to buy product
        //double (5.00) = Customer.wallet;

        public Customer()
        {
            GetCustomerBaseChanceToBuy();
            CompareNumberToBuy();
            CustomerDecision();
            // Random pick taste preference from a list
            //tastePrefence = new List<string>() { "Sweet","Tart","Smooth"};
            //rng = new Random();
        }


        //member method(can do)

        public void DetermineBuy(Weather weather)
        {

            AdjustChanceBasedOnTemperature(weather);
            AdjustChanceBasedOnForecast(weather);
            AdjustChanceOnBuyingOnPrice();




            bool customerWillBuy = CustomerDecision();
            // CustomerDecision based on chance to buy

            // if they do buy add money to player and remove ingredients for the cup
        }

        public bool CustomerDecision()
        {

            if (chanceToBuy > numberToCompare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetCustomerBaseChanceToBuy()
        {
            Random random = new Random();
            chanceToBuy = random.Next(40, 61);
        }

        public void CompareNumberToBuy()
        {
            Random random = new Random();
            numberToCompare = random.Next(1, 101);
        }

       

        public void AdjustChanceBasedOnTemperature(Weather weather)
        {
            if (weather.actualTempature < 50)
            {
                chanceToBuy -= 10;
            }
            else if (weather.actualTempature >= 51 && weather.actualTempature <= 60)
            {
                chanceToBuy -= 5;
            }
            else if (weather.actualTempature >= 61 && weather.actualTempature <= 70)
            {
                chanceToBuy += 5;
            }
            else if (weather.actualTempature >= 71 && weather.actualTempature <= 80)
            {
                chanceToBuy += 10;
            }
            else if (weather.actualTempature >= 81 && weather.actualTempature <= 90)
            {
                chanceToBuy += 15;
            }
            else
            {
                chanceToBuy += 20;
            }
        }

        public void AdjustChanceBasedOnForecast(Weather weather)
        {
            if (weather.forecast == "Sunny")
            {
                chanceToBuy += 20;
            }
            else if (weather.forecast == "Hazy")
            {
                chanceToBuy += 10;
            }
            else if (weather.forecast == "Cloudy")
            {
                chanceToBuy += 0;
            }
            else if (weather.forecast == "Rainy")
            {
                chanceToBuy -= 10;
            }
        }


        public void AdjustChanceOnBuyingOnPrice()
        {
            Random random = new Random();
            int treatyoself = random.Next(1, 3);

            if(treatyoself == 1)
            {
                chanceToBuy += 5;
            }
            else
            {
                chanceToBuy -= 10;
            }
        }
       

    }

        
        
}

        
