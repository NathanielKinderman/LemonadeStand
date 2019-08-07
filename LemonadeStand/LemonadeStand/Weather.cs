using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variable(has a)
        //list for weather type
        
        public List<string> forecastOptions;
        public string forecast;
        public int tempature;
            
        
        //constructor
        public Weather()
        {
            tempature = TodayTempature(50, 100);
            forecastOptions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy"};
        }
        
        //random tempature generator
        public int TodayTempature(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



        //member method(can do)
        //if else statement for weather
        //nested if else for the tempature with each weather
        //private void DisplayWeather()
        //{

        //    if (Day[].weather.TodayWeather == "Sunny")
        //    {
        //        TodayTempature(80, 100);
        //        Console.WriteLine("Today is Sunny and" +Day.TodayTempature); 
        //    }
                
        //    else if(Day[].weather.TodayWeather == "Rainy")
        //    {
        //        TodayTempature(50, 70);
        //        Console.WriteLine("Today is Rainy and" + Day.TodayTempature);
        //    }
        //    else if(Day[].weather.TodayWeather == "Cloudy")
        //    {
        //        TodayTempature(60, 80);
        //        Console.WriteLine("Today is Cloudy and" + Day.TodayTempature);
        //    }
        //    else if(Day[].weather.TodayWeather == "Hazy")
        //    {
        //        TodayTempature(70, 90);
        //        Console.WriteLine("Today is Hazy and" + Day.TodayTempature);
        //    }

        //}
    }
}
