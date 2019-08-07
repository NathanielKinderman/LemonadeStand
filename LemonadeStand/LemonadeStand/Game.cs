using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variable(has a)
        int dayCount;
        List<Day> days;
        Store store;
        Player player;
        Customer customer;
        

        //constructor

        public Game()
        {
            days = new List<Day>();
            dayCount = 7;
            store = new Store();
            player = new Player();
            customer = new Customer();
        }

        //member method(can do)
        public void RunGame()
        {
            GetDays();
            //display rules
            for (int i =0; i < days.Count; i++)
            {
                ShowGameMenu();
                
            }
        }

        public void ShowGameMenu()
        {
            bool menuActive = true;
            while (menuActive)
            {
                Console.WriteLine("What you like to Do? \n"+" " +"Inventory; Store; Recipe; Set Price; Start Selling.");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "Inventory":
                        Console.WriteLine("Here is your Inventory:");
                        break;

                    case "Store":
                        Console.WriteLine("Here is the Store");
                        store.ShowStoreMenu();
                        break;

                    case "Recipe":
                        Console.WriteLine("Here is your Lemonade Recipe:");
                        // menu to view and modify recipe
                        player.ShowLemonadeEquation();                        
                        break;

                    case "Set Price":
                        Console.WriteLine("Here is the price you are selling at:");
                        player.SetUpPrice();
                        // function to udate lemonade price
                        break;
                    case "Start Selling":
                        Console.WriteLine("Good luck");
                        menuActive = false;
                        //leave menu and start selling
                        break;
                    default:
                        break;



                }
            }

        }

        public void GetDays()
        {
            for (int i = 0; i < dayCount; i++)
            {
                Day day = new Day();
                days.Add(day);

            }
        }


        //let all customers try to buy
        //for each customer
        //customer.DetermineBuying(player.inventory, weather, recipe, price)
        public void DetermingIfBuying()
        { 
             void GetCustomerBaseChanceToBuy()
            {
                Random random = new Random();
                customer.chanceToBuy = random.Next(40, 60);
            }


             void AdjustChanceBasedOnTemperature(Weather weather)
            {
                if (weather.tempature < 50)
                {
                    customer.chanceToBuy -= 10;
                }
                else if (weather.tempature >= 51 && weather.tempature <= 60)
                {
                   customer.chanceToBuy -= 5;
                }
                else if (weather.tempature >= 61 && weather.tempature <= 70)
                {
                    customer.chanceToBuy += 5;
                }
                else if (weather.tempature >= 71 && weather.tempature <= 80)
                {
                    customer.chanceToBuy += 10;
                }
                else if (weather.tempature >= 81 && weather.tempature <= 90)
                {
                    customer.chanceToBuy += 15;
                }
                else
                {
                    customer.chanceToBuy += 20;
                }
            }

             void AdjustChanceBasedOnForecast(Weather weather)
            {
                if (weather.forecast == "Sunny")
                {
                    customer.chanceToBuy += 20;
                }
                else if (weather.forecast == "Hazy")
                {
                    customer.chanceToBuy += 10;
                }
                else if (weather.forecast == "Cloudy")
                {
                    customer.chanceToBuy += 0;
                }
                else if (weather.forecast == "Rainy")
                {
                    customer.chanceToBuy -= 10;
                }
            }








        }

        
        
    }
}
