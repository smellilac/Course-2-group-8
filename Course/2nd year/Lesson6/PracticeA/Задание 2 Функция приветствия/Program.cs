using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_Функция_приветствия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
                string Usn = Console.ReadLine();
            User(Usn);
        }
        static void User(string name)
        {
            Console.WriteLine("Привет," + name); // удобно использовать интерполяцию строк - это когда в строку можно вставлять например переменные
            // Console.WriteLine($"Привет: {name}");
            Console.ReadKey();
        }
    }
}
