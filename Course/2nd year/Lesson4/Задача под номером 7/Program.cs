using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12 };
            Console.WriteLine("Элементы на нечётных позициях:");
            for (int i = 0; i < num.Length; i+=2)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
