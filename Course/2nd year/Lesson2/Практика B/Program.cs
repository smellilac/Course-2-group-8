using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите телефонный номер:");
            string phonnum = Console.ReadLine();
            Console.WriteLine("Имя:" + name + " Телефон:" + phonnum);
            Console.ReadKey();

            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Больше:" + num1 + "Меньше:" + num2);
            }
            else
            {
                Console.WriteLine("Больше:" + num2 + "Меньше:" + num1);
            }
            Console.ReadKey();
        }
    }
}
