using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variable(has a)
        //max willingness to pay
        //temp threshhold
        //base number percent to buy, will flex do to weather, temp, price
        // ind x = rng.Next(1-101) chance to buy compare two numbers
        public int chanceToBuy;
        public int numberToCompare;
        string thisPref = "Sweet";
        
        public List<string> tastePrefence;

        Random rng;



        //constructor


        public Customer()
        {
            GetCustomerBaseChanceToBuy();
            // Random pick taste preference from a list
            tastePrefence = new List<string>() { "Sweet","Tart","Smooth"};
            rng = new Random();
        }


        //member method(can do)

        public void DetermineBuy(Weather weather)
        {

            AdjustChanceBasedOnTemperature(weather);
            AdjustChanceBasedOnForecast(weather);
            //the price
         
            // more adjustments

            bool customerWillBuy = CustomerDecision();
            // CustomerDecision based on chance to buy

            // if they do buy add money to player and remove ingredients for the cup
        }

        public bool CustomerDecision()
        {

            if (chanceToBuy < numberToCompare)
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
            chanceToBuy = random.Next(40, 60);
        }

        public void CompareNumberToBuy()
        {
            Random random = new Random();
            numberToCompare = random.Next(1, 100);
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
        public void AdjustChanceBasedOnTasteAndRecipe(int sugar, int lemons, int ice)
        {
            thisPref = tastePrefence[rng.Next(3)];
            switch (thisPref)
            {
                case "Sweet":
                    if (sugar > 5 && lemons < 2 && sugar < 20)
                    {
                        chanceToBuy += 5;
                    }
                    break;
                case "Tart":
                    if (sugar > 2 && lemons < 5 && lemons < 20)
                    {
                        chanceToBuy += 5;
                    }
                    
                    break;

                case "Smooth":
                    if (sugar == lemons) 
                    {
                        chanceToBuy += 5;
                    }
                    break;
                default:
                    break;
            }

        }

        //public void CustomerCanAfford()
        //{//can afford the price will buy
        //customer money = players price
        //    //cant then dont buy

        //}
    }
}
