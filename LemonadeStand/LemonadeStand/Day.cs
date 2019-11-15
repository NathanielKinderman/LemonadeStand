using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variable(has a)
        //number of customers
        public Weather weather;
        public List<string> actualForecastOption;
        public int actualTempature;
        public List<string> createCustomers;


        //constructor
        public Day()
        {
            actualForecastOption = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy" };
            weather = new Weather();
            actualTempature = weather.GenerateNumberWithinRange(50, 100);
            createCustomers = new List<string>();
        }




        ////member method(can do)
        /// the day need to have customers
        /// day needs to have the weather
        public int RunDay()
        {
            // run the day

            int temperatureShift = weather.GenerateNumberWithinRange(-10, 11);
            actualTempature = weather.GenerateNumberWithinRange(50, 100) + temperatureShift;
            return actualTempature;


            //actualForecastOptions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy" };
            //actualForecast = DisplayWeather();
        }
        public int RandomNumber(int min , int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //How many customers should Visit the lemonade stand
        public List<string> CreateCustomers()
        {
            if(weather.actualTempature <= 59)
            {
                createCustomers = new List<string>(new string[RandomNumber(40, 55)]);
                return createCustomers;

            }
            else if(weather.actualTempature <= 69)
            {
                createCustomers = new List<string>(new string[RandomNumber(50, 65)]);
                return createCustomers;

            }
            else if (weather.actualTempature <= 79)
            {
                createCustomers = new List<string>(new string[RandomNumber(60, 75)]);
                return createCustomers;

            }
            else if (weather.actualTempature <= 89)
            {
                createCustomers = new List<string>(new string[RandomNumber(70, 85)]);
                return createCustomers;

            }
            else
            {
                createCustomers = new List<string>(new string[RandomNumber(80, 95)]);
                return createCustomers;
            }

        }
        
    }
}
