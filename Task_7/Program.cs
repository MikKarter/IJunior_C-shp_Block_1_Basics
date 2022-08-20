using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceCrystall = 25;
            int crystallInInventory;
            int goldInInventory;
            int howMuchCrystallWillBuy;
            Console.WriteLine("Welcome, the Traveler. In my shop you can buy the crystalls! How much gold you have?");
            goldInInventory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fine! 1 crystall will cost you " + priceCrystall + ". How much crystalls you wil buying?");
            howMuchCrystallWillBuy = Convert.ToInt32(Console.ReadLine());
            if (goldInInventory < (howMuchCrystallWillBuy*priceCrystall))
                {
                Console.WriteLine("Sorry, you don't have so much gold");
                int offerCrystals = goldInInventory / priceCrystall;
                Console.WriteLine(" I can offer only " + offerCrystals + " for you, will buy? \n Print Yes/No");
                string willBuyCrysstalsToOffer = Console.ReadLine();
                if (willBuyCrysstalsToOffer == "Yes")
                    {
                    crystallInInventory = offerCrystals;
                    goldInInventory = goldInInventory % (crystallInInventory*priceCrystall);
                    Console.WriteLine("SYSTEM MESSAGE \nYou bought " + Convert.ToString(crystallInInventory) + " crystalls" + "\nAfter purchases you have " + Convert.ToString(goldInInventory) + " gold");
                    }
                if (willBuyCrysstalsToOffer == "No")
                    {
                    Console.WriteLine("Sorry, maybe next time...");
                    }
                if (willBuyCrysstalsToOffer != "Yes" & willBuyCrysstalsToOffer != "No")
                    {
                    Console.WriteLine("Sorry, i dont undeststand this message"); 
                    }
                }
            else
                {
                crystallInInventory = howMuchCrystallWillBuy;
                goldInInventory = goldInInventory % (crystallInInventory * priceCrystall);
                Console.WriteLine("SYSTEM MESSAGE \nYou bought " + Convert.ToString(crystallInInventory) + " crystalls" + "\nAfter purchases you have " + Convert.ToString(goldInInventory) + " gold");
            };
        }
    }
}
