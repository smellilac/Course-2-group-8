using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Функция_суммы_задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 10;
            int c = 5;
            int result = Sum(d, c);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int Sum(int x, int y) 
        {
            return x + y;
            
        }
        // можно сделать метод Sum чуть красивее static int Sum(int x, int y) => x + y;
      
    }
}
