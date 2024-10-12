using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            Console.WriteLine("Сумма чисел:" + sum);

            Console.ReadKey();

        }
    }
}
