using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 20, 15, 34, 10, 14 };
            int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                } 
            }
            Console.WriteLine("Максимальное значение массива:" + max);
            Console.ReadKey();
        }
    }
}
