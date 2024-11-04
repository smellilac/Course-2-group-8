using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_6
{
    internal class Program
    {
        static int LinearSearch(int[] num, int target)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 5;
            int index = LinearSearch(num, target);
            if (index != -1)
            {
                Console.WriteLine("Элемент:" + target + "найден на индексе:" + index);
            } 
            else
            {
                Console.WriteLine("Элемент" + target + "не найден в массиве");
            }
            Console.ReadKey();
        }
        
    }
}
