using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Функция_Обратной_Строки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string STR = Console.ReadLine();
            string reversed = Reverse(STR);
            Console.WriteLine("Обратная строка:"+reversed);
            Console.ReadKey();
        }
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
