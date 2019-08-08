﻿using System;
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
            actualTempature = weather.GenerateNumberWithinRange(50,100);
        }

        public void RunDay()
        {
            // run the day
        }


        ////member method(can do)
        //public override void RandomWeather()
        //{
        //    Random rnd = new Random();
        //    int weatherIndex = rnd.Next(3);

        //    TodayWeather = RandomWeather[weatherIndex];
        //}
    }
}
