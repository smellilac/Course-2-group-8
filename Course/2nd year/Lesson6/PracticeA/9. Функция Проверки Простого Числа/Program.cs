using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Функция_Проверки_Простого_Числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            bool FL = F(num);
            if (FL)
            {
                Console.WriteLine(num + "-простое число");
            }
            else
            {
                Console.WriteLine(num + "-непростое число");
            }
            Console.ReadKey();
        }
        public static bool F(int num)
        {
            if (num <= 0)
            {
                return false;
            }
                return true;
           
        }
    }
}
