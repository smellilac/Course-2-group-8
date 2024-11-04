using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_под_номером_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int rotations = 2;
            for (int i = 0; i < rotations; i++)
            {
                int LE = num[num.Length - 1];
                for (int j = num.Length - 1; j >0; j--)
                {
                    num[j]= num[j-1];
                }
                num[0] = LE;
            }
            Console.WriteLine("Переделанный массив:");
            foreach (int E in num)
            {
                Console.WriteLine(E + "");
            }
            Console.ReadKey();

        }
    }
}
