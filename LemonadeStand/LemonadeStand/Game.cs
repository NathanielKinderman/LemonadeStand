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

        //constructor

        public Game()
        {
            days = new List<Day>();
            dayCount = 7;
            store = new Store();
            player = new Player();
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
        


        
        
    }
}
