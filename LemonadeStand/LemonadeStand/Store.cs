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


        Game game; 
        public string Inventory;
        public double lemonPrice;
        public double cupPrice;
        public double icePrice;
        public double sugarPrice;


        //constructor

           
        public Store()
        {
            //game = new Game();
           Inventory = null;
           lemonPrice = 0.25;
           cupPrice = 0;
           icePrice = .04;
           sugarPrice = .30;
        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to purchase? Lemons cost: $0.25" );
            int lemons = int.Parse(Console.ReadLine());
            double cost = lemons * 0.25;
            if (player.moneyToStart >= cost)
            {
                Console.WriteLine("You've bought:" +" "+ lemons +" "+"lemons");
                player.inventory.lemons += lemons;
                player.moneyToStart -= cost;
                player.inventory.DisplayInventory();
            }
            else
            {
                Console.WriteLine("You dont have enough money!");
            }

        }

        public void BuyCups(Player player)
        {
            Console.WriteLine("How many Cups would you like to purchase? 25 cups for $1.15, 50 cups $2.10 or 75 cups for $3.05? Please enter only quantity."  );
            int cups = int.Parse(Console.ReadLine());
            double cost = cups * cupPrice;
            if (cups == 25)
            {
                Console.WriteLine("You've added 25 cups.");
                player.inventory.cups += cups;
                player.moneyToStart -= 1.15;
                player.inventory.DisplayInventory();
            }
            else if(cups == 50)
            {
                Console.WriteLine("You've added 50 cups.");
                player.inventory.cups += cups;
                player.moneyToStart -= 2.10;
                player.inventory.DisplayInventory();
            }
            else if(cups == 100)
            {
                Console.WriteLine("You've added 100 cups.");
                player.inventory.cups += cups;
                player.moneyToStart -= 3.55;
                player.inventory.DisplayInventory();
            }
            else 
            {
                Console.WriteLine("You dont have enough money!");
            }
        }

        public void BuySugar(Player player)
        {
            Console.WriteLine("How much Sugar would you like to purchase? 9 cups for $1.10, 20 cups for $2.40 or 40 cups for $3.90, Please only enter quantity. ");
            int sugar = int.Parse(Console.ReadLine());
            
            if (sugar == 9)
            {
                Console.WriteLine("You've added 9 cups.");
                player.inventory.sugar += sugar;
                player.moneyToStart -= 1.10;
                player.inventory.DisplayInventory();

            }
            else if(sugar == 20)
            {
                Console.WriteLine("You've added 20 cups.");
                player.inventory.sugar += sugar;
                player.moneyToStart -= 2.40;
                player.inventory.DisplayInventory();
            }
            else if (sugar == 40)
            {
                Console.WriteLine("You've added 40 cups.");
                player.inventory.sugar += sugar;
                player.moneyToStart -= 3.90;
                player.inventory.DisplayInventory();
            }

            else
            {
                Console.WriteLine("You dont have enough money!");
            }
        }

        public void BuyIce(Player player)
        {
            Console.WriteLine("How much Sugar would you like to purchase? 100 cubes for $1.20 or 250 cubes for $2.10. Please only enter quantity");
            int ice = int.Parse(Console.ReadLine());
            
            if (ice == 100)
            {
                Console.WriteLine("You've added 100 cubes.");
                player.inventory.ice += ice;
                player.moneyToStart -= 1.20;
                player.inventory.DisplayInventory();
            }
            else if (ice == 250)
            {
                Console.WriteLine("You've added 250 cubes.");
                player.inventory.ice += ice;
                player.moneyToStart -= 2.10;
                player.inventory.DisplayInventory();
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
                Console.WriteLine("You have:$"+ player.moneyToStart);
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
