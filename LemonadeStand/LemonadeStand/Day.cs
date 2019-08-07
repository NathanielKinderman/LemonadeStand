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
        public Weather weather;


        //constructor
        public Day()
        {
            //TodayWeather = new List<string>() { "Sunny", "Rainy", "Cloudy", "Hazy" };
            weather = new Weather();
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
