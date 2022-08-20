using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPictureInLine = 3;
            int counterPicture = 52;
            int counterFullPictureLine = counterPicture / countPictureInLine;
            int extraImages = counterPicture % countPictureInLine;
            Console.WriteLine("Количество полностью заполненных рядов = " + counterFullPictureLine);
            Console.WriteLine("Количество оставшихся картинок = " + extraImages);
        }
    }
}
