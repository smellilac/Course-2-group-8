using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_под_номером_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 6, 4, 3, 7, 2, 8, 10, 9 };
            Array.Sort(num);
            for (int i=0; i < num.Length; i++) 
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
