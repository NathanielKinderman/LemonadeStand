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
        public double moneyToStart;
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public Stand theStand;


        //constructor
        public Inventory()
        {
            
            lemons = 0;
            sugar = 0;
            ice = 0;
            cups = 0;
            //recipe = lemons + ice + sugar + cups;

        }


        //member method(can do)
        public void DisplayInventory()
        {
            Console.WriteLine("Here is your inventory:" + "lemons:" +" "+ lemons +" "+ "sugar:" + " " +sugar +" " + "ice:"+" "+ ice +" "+ "cups:" + cups);
        }



        
    }
}
