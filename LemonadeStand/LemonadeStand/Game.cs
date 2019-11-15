﻿using System;
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
        Day thisDay;
        Store theStore;
        Player player;
        List<Customer> customers;
        public double moneyToStart;
        public double moneyMade;
        Stand theStand;
        Inventory inventory;

        //constructor

        public Game()
        {
            thisDay = new Day();
            dayCount = 7;
            theStore = new Store();
            player = new Player();
            customers = new List<Customer>();
            moneyToStart = 20.00;
            theStand = new Stand();
            inventory = new Inventory();
        }

        //member method(can do)
        public void RunGame()
        {
            ShowGameRules();
           
           

            //GetDays();

            for (int i = 0; i < dayCount; i++)
            {

                ShowGameMenu();

                
               
            }
            
            //GetCustomers();
        }

        public void ShowGameRules()
        {
            Console.WriteLine("Here are the rules." + "\n" + "You have Seven Days to sell lemonade and to make a profit" + "\n"+
         "You can change the recipe of the lemonade and set how much you want to sell it for."+ "\n" +
        "You will have 20 dollars to start. But youll have to go to the store to buy the ingredients." + "\n" +
        //"When making your lemonade, please take in that each customer will have their own taste prefernce. some will like Sweet, Tart or Smooth." 
         "\n" +
         "Also the weather will be a factor on the customers choice on buying so keep that in mind.");
        }

    public void ShowGameMenu() 
        {
            bool menuActive = true;
            while (menuActive)
            {
                Console.WriteLine("What you like to Do?" + "\n" + "Inventory; Store; Recipe; Set Price; Start Selling.");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "Inventory":
                        Console.WriteLine("Here is your Inventory:");
                        inventory.DisplayInventory();
                        break;

                    case "Store":
                        Console.WriteLine("Here is the Store");
                        theStore.ShowStoreMenu(player);
                        break;

                    case "Recipe":
                        Console.WriteLine("Here is your Lemonade Recipe:");
                        theStand.ShowLemonadeEquation();
                        // menu to view and modify recipe
                                               
                        break;

                    case "Set Price":
                        Console.WriteLine("Here is the price you are selling at:");
                        theStand.SetUpPrice();
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

        //public void GetDays()
        //{
        //    for (int i = 0; i < dayCount; i++)
        //    {
        //        Day day = new Day();
        //        day.Add(day);
                
        //    }
        //}

        public void GetCustomers()
        {
            for (int i = 0; i < dayCount; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);

            }
        }
        public void SellLemonade()
        {
            thisDay.CreateCustomers();
            theStand.MakeAPitcher();
            for(int i=0;i < thisDay.createCustomers.Count; i++)
            {
                theStand.cupsBoughtToday++;
                inventory.cups--;
                moneyMade += theStand.priceOfLemonade;
                if(theStand.cupsBoughtToday == theStand.cupsPerPitcher)
                {
                    theStand.MakeAPitcher();
                    theStand.cupsBoughtToday = 0;
                }


            }


        }

    }
}
