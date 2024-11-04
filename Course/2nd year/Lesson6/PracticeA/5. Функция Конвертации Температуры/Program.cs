using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Функция_Конвертации_Температуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в Цельсии:");
            double c = double.Parse(Console.ReadLine());
            double f = Celsius(c);
            Console.WriteLine(c + " градусов Цельсия = " + f + " градусов Фаренгейта");
            Console.ReadKey();
        }

        public static double Celsius(double c)
        {
            return (c * 9 / 5) + 32;
        }

    }
}
