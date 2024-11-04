using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, -1, -2, -3, -4, 4, 5, 6, 7 };
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 1)
                {
                    num[i] = 0;
                }
            }
            Console.WriteLine("Изменённый массив:");
            foreach (int E in num)
            {
                Console.WriteLine(E + "");
            }
            Console.ReadKey();
        }
    }
}
