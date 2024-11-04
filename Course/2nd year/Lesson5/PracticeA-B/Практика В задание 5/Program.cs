using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_В_задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array2 = { 2, 4, 6, 8 };
            int[] mergedArray = MergeArrays(array1, array2);
            Console.WriteLine("Объединенный массив:");
            PrintArray(mergedArray);
            Console.WriteLine("Числа, встречающиеся в обоих массивах:");
            FindCommonNumbers(array1, array2);
        }
        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0;
            for (; i < array1.Length; i++)
            {
                mergedArray[i] = array1[i];
            }
            for (int j = 0; j < array2.Length; j++)
            {
                mergedArray[i++] = array2[j];
            }
            return mergedArray;
        }
        public static void FindCommonNumbers(int[] array1, int[] array2)
        {
            HashSet<int> commonNumbers = new HashSet<int>();
            foreach (int number in array1)
            {
                if (Array.IndexOf(array2, number) != -1)
                {
                    commonNumbers.Add(number);
                }
            }
            foreach (int number in commonNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
