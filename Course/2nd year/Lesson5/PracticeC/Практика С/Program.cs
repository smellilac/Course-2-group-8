using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_С
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] path = { 4, 2, 0, 1, 2, 3, 1, 1, 0 };

            int minSteps = FindMinSteps(path);
            if (minSteps != -1)
            {
                Console.WriteLine("Минимальное количество шагов:"+ minSteps);
            }
            else
            {
                Console.WriteLine("Достичь конца пути невозможно.");
            }
            Console.ReadKey();
        }
        public static int FindMinSteps(int[] path)
        {
            int n = path.Length;
            if (n == 0 || path[0] == 0)
            {
                return -1; 
            }
            int[] minSteps = new int[n];
            minSteps[0] = 1; 

            for (int i = 1; i < n; i++)
            {
                if (path[i] == 0)
                {
                    minSteps[i] = -1; 
                }
                else if (minSteps[i - 1] != -1)
                {
                    minSteps[i] = minSteps[i - 1] + 1; 
                }
                else
                {
                    minSteps[i] = -1;
                }
            }
            return minSteps[n - 1];
        }
    }
}
