using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_В
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine("Второй элемент:" + mas[1]);
            mas[2] = 100;
            Console.WriteLine("Длина массива:" + mas.Length);
            Console.ReadKey();
        }
    }
}
