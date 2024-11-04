using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int min = num[0];
            int max = num[0];
            for (int i = 1; i < num.Length; i++) 
            {
                if (num[i] < min)
                {
                    min=num[i];
                }
                if (num[i] > max) 
                {
                    max=num[i];
                }
            }
            Console.WriteLine("Минимальное значение:" + min);
            Console.WriteLine("Максимальное значение:" + max);
            Console.ReadKey();
        }
    }
}
