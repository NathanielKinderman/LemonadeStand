using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variable(has a)
        public double money;
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public Recipe recipe;


        //constructor
        public Inventory()
        {
            money = 25.00;
            lemons = 0;
            sugar = 0;
            ice = 0;
            cups = 0;
            recipe = lemons + ice + sugar + cups;

        }


        //member method(can do)
        public void DisplayInventory()
        {
            Console.WriteLine("Here is your inventory" + lemons + "lemons" + sugar + "sugar" + ice + "ice" + cups + "cups");
        }



        public void ShowLemonadeEquation()
        {
            bool equationMenu = true;
            while (equationMenu)
            {
                Console.WriteLine("How would you like to change the recipe? Add lemons, Remove lemons, Add sugar Remove Sugar, Add ice, Remove sugar or Main menu");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Add lemons":
                        Console.WriteLine("How many lemons would you like to add to the recipe?");
                        

                        break;

                    case "Remove lemons":
                        Console.WriteLine("How many lemons would you like to remove to the recipe?");
                        //inventory.lemons
                        break;

                    case "Add sugar":
                        Console.WriteLine("How many cups of sugar would you like to add to the recipe?");
                        break;

                    case "Remove sugar":
                        Console.WriteLine("How many cups of sugar would you to remove to the recipe?");
                        break;

                    case "Add ice":
                        Console.WriteLine("How much ice would you like to add to the recipe?");
                        break;

                    case "Remove ice":
                        Console.WriteLine("How much ice would you like to remove to the recipe?");
                        break;

                    case "Main menu":
                        equationMenu = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
