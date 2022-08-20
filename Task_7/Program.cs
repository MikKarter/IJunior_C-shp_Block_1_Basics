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
            int counterCrystallInInventory;
            int counterGoldInInventory;
            Console.WriteLine("Welcome, the Traveler. In my shop you can buy the crystalls! How much gold you have?");
            counterGoldInInventory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fine! 1 crystall will cost you " + priceCrystall);
            counterCrystallInInventory = counterGoldInInventory / priceCrystall;
            counterGoldInInventory = counterGoldInInventory % priceCrystall;
            Console.WriteLine("SYSTEM MESSAGE \nYou bought " + Convert.ToString(counterCrystallInInventory) + " crystalls" + "\nAfter purchases you have " + Convert.ToString(counterGoldInInventory) + " gold");
        }
    }
}
