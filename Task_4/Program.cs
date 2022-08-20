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
            string userName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string userAge = Console.ReadLine();
            Console.WriteLine("Подскажите ваш знак зодиака?");
            string userZodiak = Console.ReadLine();
            Console.WriteLine("Вас зовут " + userName + "\nВаш возраст: " + userAge + "\nПо знаку Зодиака вы - " + userZodiak);
        }
    }
}
