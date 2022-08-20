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
            crystallInInventory = howMuchCrystallWillBuy;
            goldInInventory = goldInInventory - crystallInInventory * priceCrystall;
            Console.WriteLine("You have " + crystallInInventory + " crystall and " + goldInInventory + " gold");
        }
    }
}
