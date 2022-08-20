using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Филлипенко";
            string userSurname = "Алла";
            Console.WriteLine("Вас зовут " + userName + " и фамилия ваша - " + userSurname);
            Console.WriteLine("\nКажется мы что то напутали, минуточку...");
            string bufferString;
            bufferString = userName;
            userName = userSurname;
            userSurname = bufferString;
            Console.WriteLine("\nТеперь порядок, ваше Имя - " + userName + " ,а ваша фамилия - " + userSurname);
        }
    }
}
