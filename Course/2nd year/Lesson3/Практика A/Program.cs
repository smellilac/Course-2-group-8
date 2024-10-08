using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] F = new int[5];
            string[] f = { "7" + "7" + "7" };
            Console.WriteLine(f[0]); 
            for (int i = 0; i < F.Length; i++)
            {
                Console.WriteLine(F[i]);  
            }
            Console.ReadKey();
        }
    }
}
