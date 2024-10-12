using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num= int.Parse(Console.ReadLine());

            int h = num / 100;
            int t = (num % 100) / 100;
            int u = num % 10;
            Console.WriteLine("Сотни:" + h + "Десятки:" + t + "Единицы:" + u);
            Console.ReadKey();
        }
    }
}
