using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {-1, 1, -3, 5, -6, -7, 10,-12};
            int negcount = 0;
            foreach (int numb in num) 
            {
                if (numb < 0) 
                {
                    negcount++;
                }
            }
            Console.WriteLine("Количество отрицательных чисел:" + negcount);
            Console.ReadKey();
        }
    }
}
