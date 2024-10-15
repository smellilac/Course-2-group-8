using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_A_задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, -1, -2 };
           
            int subarrayLength = 3;

  
            int startIndex = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i <= num.Length - subarrayLength; i++)
            {
                int currentSum = 0;
                for (int j = i; j < i + subarrayLength; j++)
                {
                    currentSum += num[j];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                }
            }

           
            Console.WriteLine("Подмассив с максимальной суммой:");
            for (int i = startIndex; i < startIndex + subarrayLength; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
