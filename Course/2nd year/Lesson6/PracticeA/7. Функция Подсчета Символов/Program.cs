using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Функция_Подсчета_Символов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою строку:");
            string slova = Console.ReadLine();
            Console.WriteLine("Введи определённый символ:");
            char target = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = CountChaR(slova, target);
            Console.WriteLine("Символ:" + target + ",встречается:" + count + "раз в строке.");
            Console.ReadKey();
        }

        public static int CountChaR(string str, char target)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
