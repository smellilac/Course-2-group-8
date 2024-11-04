using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Функция_Расчета_Факториала
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            int factorial = Cosmos(num);
            Console.WriteLine("Факториал:" + num + ",равен:" + factorial);
            Console.ReadKey();
        }
        public static int Cosmos(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n*Cosmos(n-1);
            }
        }

    }
}
