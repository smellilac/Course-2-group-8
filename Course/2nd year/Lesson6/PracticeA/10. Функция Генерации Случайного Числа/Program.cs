using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Функция_Генерации_Случайного_Числа
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введит наименьшее число:");
            int lower = int.Parse(Console.ReadLine());
            Console.Write("Введите наибольшее число:");
            int upper = int.Parse(Console.ReadLine());

        
            int randomNumber =Number(lower, upper);


            Console.WriteLine("Случайное число в диапазоне от:" + lower + ",до" + upper + ":" + randomNumber);
            Console.ReadKey();
        }

        
        public static int Number(int lower, int upper)
        {
            Random random = new Random();
            return random.Next(lower, upper + 1);
        }
    }
    
}
