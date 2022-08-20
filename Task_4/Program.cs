using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мы ради приветствовать нового пользователя. Представьтесь, пожалуйста.");
            string newUserName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string newUserAge = Console.ReadLine();
            Console.WriteLine("Подскажите ваш знак зодиака?");
            string newUserZodiak = Console.ReadLine();
            Console.WriteLine("Вас зовут " + newUserName + "\nВаш возраст: " + newUserAge + "\nПо знаку Зодиака вы - " + newUserZodiak);

        }
    }
}
