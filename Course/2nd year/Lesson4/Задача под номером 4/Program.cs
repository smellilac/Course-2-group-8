using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Чётные числа в массиве:");
            foreach(int numbr in num)
            {
                if (numbr %2==0)
                {
                    Console.WriteLine(numbr + "");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
