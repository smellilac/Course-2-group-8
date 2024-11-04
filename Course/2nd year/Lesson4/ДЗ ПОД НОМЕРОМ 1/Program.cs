using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_ПОД_НОМЕРОМ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5 };
            int[] num2 = new int[] { 6, 7, 8, 9, 10 };
            int[] result = num1.Concat(num2).ToArray();
            Console.WriteLine("Результат:{0}", string.Join(", ", result));
            Console.ReadKey();
        }
    } //Можно и через цикл,но быстрее будет через Concat
}
