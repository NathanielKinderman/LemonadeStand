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
        public int actualTempature;
            
        
        //constructor
        public Weather()
        {
            int temperatureShift = GenerateNumberWithinRange(-10, 11);
            actualTempature = GenerateNumberWithinRange(50, 100) + temperatureShift;
             forecastOptions = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy"};
            forecast = DisplayWeather();
        }
        
        //random tempature generator
        public int GenerateNumberWithinRange(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



        //member method(can do)
      
        public string DisplayWeather()
        {
            int actualTempature = GenerateNumberWithinRange(50, 100);
            int outsideWeather = GenerateNumberWithinRange(0, 4);
            string weatherResult = forecastOptions[outsideWeather];
            Console.WriteLine("Today is " + weatherResult + " and " + actualTempature);
            return weatherResult;


            

        }
    }
}
