using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer testCustomer = new Customer();
            //Weather testWeather = new Weather();

            //testWeather.forecast = "Sunny";

            //testCustomer.AdjustChanceBasedOnTemperature(testWeather);

            Game game = new Game();
            game.RunGame();

            Console.ReadLine();
        }
    }
}
