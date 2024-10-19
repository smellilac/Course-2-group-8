using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_Функция_Максимума
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int num1 = 5;
            int num2 = 10;
            int max = Maximum(num1, num2);
            Console.WriteLine("Максимальное число: " + max);
            Console.ReadKey();
        }

        
        public static int Maximum(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
