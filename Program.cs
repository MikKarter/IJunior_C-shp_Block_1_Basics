using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeToOnePeople = 10;
            Console.WriteLine("Вы пришли в поликлиннику и пытаетесь посчитать сколько времени вы потратите. Сколько человек вы видите в данный момент перед собой?");
            int oldPeopleCounter = Convert.ToInt32(Console.ReadLine());
            int timeCounter = oldPeopleCounter * timeToOnePeople;
            int oursCounter = timeCounter / 60;
            int minunesCounter = timeCounter % 60;
            Console.WriteLine("Судя по всему вам придётся проторчать тут не менее " + timeCounter +" минут ");
            Console.WriteLine("Иначе - " + Convert.ToString(oursCounter) + "часа/ов и " + Convert.ToString(minunesCounter) + " минут");
        }
    }
}
