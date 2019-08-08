using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variable(has a)
        double lemon;
        int sugar;
        int ice;
        int cups;


        //constructor
        //set price for items
        //lemon = .45;


        //member method(can do)

        public void ShowStoreMenu()
        {
            bool storeMenu = true;
            while (storeMenu)
            {
                Console.WriteLine("What would you like buy? Type: Lemons, Cups, Sugar, Ice or Back to Game Menu");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Lemons":
                        Console.WriteLine("How many Lemons would you like to buy?");
                        //lemons .45 per lemon
                        break;
                    case "Cups":
                        Console.WriteLine("How many Cups would you like to buy?");
                        //cups cost 2.05 per package of cups
                        break;
                    case "Sugar":
                        Console.WriteLine("How many cups of Sugar would you like to buy?");
                        //sugar cost .50 per cups of sugar
                        break;
                    case "Ice":
                        Console.WriteLine("How much Ice would you like to buy?");
                        //ice cost 1.75 per bag of ice
                        break;
                    case "Back to Game Menu":
                        storeMenu = false;
                        break;
                    default:
                        break;
                        
                

                } 
            }
        }
    }
}
