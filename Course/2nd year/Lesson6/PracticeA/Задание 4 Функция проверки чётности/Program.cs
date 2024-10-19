using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_Функция_проверки_чётности
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 10;
            bool isEven = IsEven(number);
            Console.WriteLine(number + " - Четное? " + isEven);
            Console.ReadKey();
        }


        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
