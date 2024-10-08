using System;

class practicaC
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string f = Console.ReadLine();

        int num = int.Parse(f);
        int res = num + 5;

        Console.WriteLine("Результат: " + res);
        Console.ReadKey(); 
    }
}
