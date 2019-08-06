using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variable(has a)



        //constructor



        //member method(can do)


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

        public void SetUpPrice()
        {
            int price;
            Console.WriteLine("How much would like to sell your lemonade for?");
             price = Int32.Parse(Console.ReadLine());
        }
    }
}
