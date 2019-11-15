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
        int lemons;
        int sugar;
        int ice;
        int cups;


        
        public string Inventory;
        public double lemonPrice;
        public double cupPrice;
        public double icePrice;
        public double sugarPrice;


        //constructor

           
        public Store()
        {
           
           Inventory = null;
           lemonPrice = .25;
           cupPrice = .15;
           icePrice = .04;
           sugarPrice = .30;
        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to purchase?" );
            int lemons = int.Parse(Console.ReadLine());
            double cost = lemons * lemonPrice;
            if (player.inventory.moneyToStart >= cost)
            {
                player.inventory.lemons += lemons;
                player.inventory.moneyToStart -= cost;
            }
            else
            {
                Console.WriteLine("You dont have enough money!");
            }

        }

        public void BuyCups(Player player)
        {
            Console.WriteLine("How many Cups would you like to purchase?");
            int cups = int.Parse(Console.ReadLine());
            double cost = cups * cupPrice;
            if (player.inventory.moneyToStart >= cost)
            {
                player.inventory.cups += cups;
                player.inventory.moneyToStart -= cost;
            }
            else
            {
                Console.WriteLine("You dont have enough money!");
            }
        }

        public void BuySugar(Player player)
        {
            Console.WriteLine("How much Sugar would you like to purchase?");
            int sugar = int.Parse(Console.ReadLine());
            double cost = sugar * sugarPrice;
            if (player.inventory.moneyToStart >= cost)
            {
                player.inventory.sugar += sugar;
                player.inventory.moneyToStart -= cost;
            }
            else
            {
                Console.WriteLine("You dont have enough money!");
            }
        }

        public void BuyIce(Player player)
        {
            Console.WriteLine("How much Sugar would you like to purchase?");
            int ice = int.Parse(Console.ReadLine());
            double cost = ice * icePrice;
            if (player.inventory.moneyToStart >= cost)
            {
                player.inventory.ice += ice;
                player.inventory.moneyToStart -= cost;
            }
            else
            {
                Console.WriteLine("You dont have enough money!");
            }
        }






        //member method(can do)

        public void ShowStoreMenu(Player player)
        {
            bool storeMenu = true;
            while (storeMenu)
            {
                Console.WriteLine("What would you like buy? Type: Lemons, Cups, Sugar, Ice or Back to Game Menu");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Lemons":
                         BuyLemons(player);
                                      
                        break;
                    case "Cups":
                        BuyCups(player);
                        break;
                    case "Sugar":
                        BuySugar(player);
                        break;
                    case "Ice":
                        BuyIce(player);
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
