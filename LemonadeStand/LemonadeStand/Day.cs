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


        //constructor
        public Day()
        {
            actualForecastOption = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy" };
            weather = new Weather();
            actualTempature = weather.GenerateNumberWithinRange(50, 100);
        }

       


        ////member method(can do)
        /// the day need to have customers
        /// day needs to have the weather
        //public int RunDay()
        //{
        //    // run the day

        //    int temperatureShift = GenerateNumberWithinRange(-10, 11);
        //    actualTempature = GenerateNumberWithinRange(50, 100) + temperatureShift;
        //    return = actualTempature;

        //}


        //public override void RandomWeather()
        //{
        //    Random rnd = new Random();
        //    int weatherIndex = rnd.Next(3);

        //    TodayWeather = RandomWeather[weatherIndex];
        //}
    }
}
