using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_А_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numb = new int[10];
            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = random.Next(1, 101); 
            }


            Array.Sort(numb);

            Console.WriteLine("Отсортированный массив:");
            PrintArray(numb);


            int uniqueCount = 1; 
            for (int i = 1; i < numb.Length; i++)
            {
                if (numb[i] != numb[i - 1])
                {
                    uniqueCount++;
                }
            }
            Console.WriteLine("Количество уникальных элементов: " + uniqueCount);
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
