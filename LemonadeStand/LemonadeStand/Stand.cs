using System;

namespace LemonadeStand
{
    public class Stand 
    {//use repcipe to make lemonade
        //descrease ingredient 
        //make lemonade
        //sell lemonade
        public int lemonsInThePitcher;
        public int sugarInThePitcher;
        public int iceCubesPerCup;
        public int cupsPerPitcher;        
        public int cupsMadeToday;
        public int cupsBoughtToday;
        public double priceOfLemonade;
        public Inventory myInventory;


        public Stand()
        {
            // List<int> Lemonade = new List<int>(Lemonade);
            lemonsInThePitcher = 0;
            sugarInThePitcher = 0;
            iceCubesPerCup = 0;
            priceOfLemonade = 0;
            myInventory = new Inventory();

        }

        public void ShowLemonadeEquation(Player player)
        {
            bool equationMenu = true;
            while (equationMenu)
            {
                DisplayRecipe();
                Console.WriteLine("How would you like to change the recipe? Add lemons, Add sugar, Add ice, or Main menu");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Add lemons":                        
                        HowManyLemons();
                        AddTheLemons();

                        break;                    

                    case "Add sugar":                        
                        HowMuchSugar();
                        PourSomeSugar();
                        break;
                    

                    case "Add ice":
                        HowMuchIce();
                        AddTheIce();
                        CupsOfLemonadeMade();
                        break;                    

                    case "Main menu":                        
                        equationMenu = false;
                        break;

                    default:
                        break;
                }

                
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("There is:" +" "+ lemonsInThePitcher +  "Lemons +" + " "+ sugarInThePitcher+" " + "Sugar +" +" " + iceCubesPerCup + "Ice in the Recipe.");
        }

        public void SetUpPrice()
        {
            double price;
            Console.WriteLine("How much would like to sell your lemonade for? Please set price between: .01 -.99");
            price = Convert.ToDouble(Console.ReadLine());
            priceOfLemonade = price;
        }

        public int HowManyLemons()
        {
            Console.WriteLine("How many lemons would you like to add to the recipe?");
            lemonsInThePitcher = Convert.ToInt32(Console.ReadLine());
            return lemonsInThePitcher;

        }
        public int AddTheLemons()
        {

            myInventory.lemons -= lemonsInThePitcher;
            Console.WriteLine("You've added"+" " + lemonsInThePitcher + " " + "Lemons");
            
            return myInventory.lemons;
        }

        public int HowMuchSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to add to the recipe?");
            sugarInThePitcher = Convert.ToInt32(Console.ReadLine());
            return sugarInThePitcher;
        }
        public int PourSomeSugar()
        {
            myInventory.sugar -= sugarInThePitcher;
            Console.WriteLine("You've added " +" " +sugarInThePitcher + " " + "Sugar" );
            return myInventory.sugar;
        }

        public int HowMuchIce()
        {
            Console.WriteLine("How much ice would you like to add to the recipe? Note: How much Ice that is add reflects how many cups of Lemonade is made per pitcher.");
            iceCubesPerCup = Convert.ToInt32(Console.ReadLine());
            return iceCubesPerCup;

        }
        public int AddTheIce()
        {
            myInventory.ice -= iceCubesPerCup;
            Console.WriteLine("You've added" + " " + iceCubesPerCup+ " " + "Ice Cubes");
            return myInventory.ice;
        }

        public int CupsOfLemonadeMade()
        {
            if (iceCubesPerCup < 3)
            {
                cupsPerPitcher = 8;
                
            }
            else if (iceCubesPerCup >= 3 && iceCubesPerCup < 5)
            {

                cupsPerPitcher = 9;
            }
            else if (iceCubesPerCup >= 5 && iceCubesPerCup < 7)
            {

                cupsPerPitcher = 10;
            }
            else if (iceCubesPerCup >= 7 && iceCubesPerCup <= 9)
            {

                cupsPerPitcher = 11;
            }
            else if (iceCubesPerCup > 9)
            {
                cupsPerPitcher = 12;
            }

            return cupsPerPitcher;
        }

        public void MakeAPitcher()
        {
            AddTheLemons();
            PourSomeSugar();
            AddTheIce();

        }
    }
}