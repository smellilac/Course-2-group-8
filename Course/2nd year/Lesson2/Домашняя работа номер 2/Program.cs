using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_работа_номер_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secnum = random.Next(1, 11);
            Console.WriteLine("Я загадал число от 1 до 10");
            int guespopit = 5;
            while (guespopit > 0)
            {
                Console.WriteLine("Введите ваше число:");
                int guess = int.Parse(Console.ReadLine());
                if (guess == secnum)
                {
                    Console.WriteLine("Поздравляю ты угадал число:" + secnum + "за" + guespopit + "попыток");
                    break;
                }
                else if (guess < secnum)
                {
                    Console.WriteLine("Слишком мало,попробуй ещё раз.");
                }
                else
                {
                    Console.WriteLine("Слишком много,попробуй ещё раз.");
                }
                guespopit--;
            }
            if (guespopit == 0)
            {
                Console.WriteLine("У тебя закончились попытки, загадачное число было:" + secnum);
            }
            Console.ReadKey();
        }
    }
}