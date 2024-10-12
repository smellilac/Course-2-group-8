using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_номер_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;

            for (int i=0; i<num.Length; i++)    
            {
                sum += num[i];
            }
            Console.WriteLine("Сумма элементов массива:" + sum);
            Console.ReadKey();
        }
    }
}
