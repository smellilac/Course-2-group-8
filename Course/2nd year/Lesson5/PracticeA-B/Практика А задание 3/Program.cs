using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_А_задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 2, 4, 1, 5, 2, 1, 2 };

            
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int numb in num)
            {
                if (frequency.ContainsKey(numb))
                {
                    frequency[numb]++;
                }
                else
                {
                    frequency[numb] = 1;    
                }
            }

           
            int maxFreq= 0;
            List<int> mostFreqnumb = new List<int>();
            foreach (KeyValuePair<int, int> entry in frequency)
            {
                if (entry.Value > maxFreq)
                {
                    maxFreq = entry.Value;
                    mostFreqnumb.Clear();
                    mostFreqnumb.Add(entry.Key);
                }
                else if (entry.Value == maxFreq)
                {
                    mostFreqnumb.Add(entry.Key);
                }
            }

     
            Console.WriteLine("Числа с максимальной частотой:");
            foreach (int numb in mostFreqnumb)
            {
                Console.WriteLine(numb + " (встречается " + maxFreq + " раз)");
            }
            Console.ReadKey();
        }
    }
}
