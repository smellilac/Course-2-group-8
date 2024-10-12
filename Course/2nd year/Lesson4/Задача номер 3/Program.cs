using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_номер_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Исходный массив:");
            PrintArray(num);
            Reverse(num);

            Console.WriteLine("Перевернутый массив:");
            PrintArray(num);
            Console.ReadKey();

        }
        public static void Reverse(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            Console.ReadKey();
        }
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
