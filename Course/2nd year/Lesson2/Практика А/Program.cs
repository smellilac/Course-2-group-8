using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_А
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет," + name);

            Console.WriteLine("Введите год вашего рождения:");
            int yourbirthday=int.Parse(Console.ReadLine());
            int currentyear=DateTime.Now.Year;
            int age = currentyear - yourbirthday;
            Console.WriteLine("Вам" + age + "лет");
            Console.ReadKey();
        }
    }
}
