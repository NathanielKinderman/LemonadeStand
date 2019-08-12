using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variable(has a)
        //player can only have forecast
        public Inventory inventory;
        public double money;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            money = 25.00;
        }

        //member method(can do)


      

        public void SetUpPrice()
        {
            int price;
            Console.WriteLine("How much would like to sell your lemonade for?");
             price = Int32.Parse(Console.ReadLine());
        }
    }
}
