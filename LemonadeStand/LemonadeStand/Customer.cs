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






        //constructor


        public Customer()
        {
            GetCustomerBaseChanceToBuy();   
        }


        //member method(can do)


        public void GetCustomerBaseChanceToBuy()
        {                  
                Random random = new Random();
                chanceToBuy = random.Next(40, 60);
        }
    

        public void AdjustChanceBasedOnTemperature(Weather weather)
        {
            if (weather.tempature < 50)
            { 
                chanceToBuy -= 10;
            }
            else if (weather.tempature >= 51 && weather.tempature <= 60)
            {
                chanceToBuy -= 5;
            }
            else if (weather.tempature >= 61 && weather.tempature <= 70)
            {
                chanceToBuy += 5;
            }
            else if (weather.tempature >= 71 && weather.tempature <= 80)
            {
                chanceToBuy += 10;
            }
            else if (weather.tempature >= 81 && weather.tempature <= 90)
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
            if(weather.forecast == "Sunny")
            {
                chanceToBuy += 20;
            }
            else if(weather.forecast == "Hazy")
            {
                chanceToBuy  += 10;
            }
            else if (weather.forecast == "Cloudy")
            {
                chanceToBuy += 0;
            }
            else if(weather.forecast == "Rainy")
            {
                chanceToBuy -= 10;
            }
        }
    }
}
