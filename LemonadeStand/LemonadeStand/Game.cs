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
        //sotre will be call to sell lemons
        

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
            // days list example:
            //var test = days[0].weather.tempature;
            //customers[0].AdjustChanceBasedOnTasteAndRecipe();

            GetDays();
            
            for (int i =0; i < days.Count; i++)
            {

                ShowGameMenu();

                //////
                days[i].RunDay();

            }
            for (int i = 0; i < days.Count; i++)
            {
                //DetermineBuy(); 
            }
        }

        //public string ShowGameRules
        //{
        //    Console.WriteLine("Here are the rules." "\n" + "You have......");
        //}
            
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
                        //RunDay();
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
    }
}
