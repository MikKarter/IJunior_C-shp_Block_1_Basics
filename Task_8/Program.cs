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
            int oneOurValue = 60;
            Console.WriteLine("Вы пришли в поликлиннику и пытаетесь посчитать сколько времени вы потратите. Сколько человек вы видите в данный момент перед собой?");
            int oldPeopleCounter = Convert.ToInt32(Console.ReadLine());
            int timeCounter = oldPeopleCounter * timeToOnePeople;
            int oursAmount = timeCounter / oneOurValue;
            int minunesAmount = timeCounter % oneOurValue;
            Console.WriteLine("Судя по всему вам придётся проторчать тут не менее " + timeCounter +" минут ");
            Console.WriteLine("Иначе - " + oursAmount + "часа/ов и " + minunesAmount + " минут");
        }
    }
}
