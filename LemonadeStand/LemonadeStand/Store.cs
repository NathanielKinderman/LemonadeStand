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



        //constructor



        //member method(can do)

        public void ShowStoreMenu()
        {
            bool storeMenu = true;
            while (storeMenu)
            {
                Console.WriteLine("What would you like buy? Type: Lemons, Cups, Sugar, Ice or Back to Game Menu");
                switch (choice)
                {
                    case "Lemons":
                        Console.WriteLine("How many Lemons would you like to buy?");
                        break;
                    case "Cups":
                        Console.WriteLine("How many Cups would you like to buy?");
                        break;
                    case "Sugar":
                        Console.WriteLine("How many cups of Sugar would you like to buy?");
                        break;
                    case "Ice":
                        Console.WriteLine("How much Ice would you like to buy?");
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
