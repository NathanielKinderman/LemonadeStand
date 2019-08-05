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
        List<string> weather;
        int tempature;
            
        
        //constructor
        public Weather()
        {
            tempature = RandomNumber(50, 100);
            weather = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy"};
        }
        
        //random tempature generator
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }



        //member method(can do)
        //if else statement for weather
        //nested if else for the tempature with each weather
        public void DisplayWeather()
        {
            if (Day.Weather == "Sunny")
            {
                Console.WriteLine("Today is Sunny and" +Day.tempature); 
            }
            else if(Day.weather == "Rainy")
            {
                Console.WriteLine("Today is Rainy and" + Day.tempature);
            }
            else if(Day.weather == "Cloudy")
            {
                Console.WriteLine("Today is Cloudy and" + Day.tempature);
            }
            else if(Day.weather == "Hazy")
            {
                Console.WriteLine("Today is Hazy and" + Day.tempature);
            }

        }
    }
}
