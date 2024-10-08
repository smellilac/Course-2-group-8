using System;
class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int number1 =  int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;
        int dif = number1 - number2;
        int com = number1 * number2;
        double div= number1/ number2;

        Console.WriteLine("Сумма:" + sum);
        Console.WriteLine("Разность:" + dif);
        Console.WriteLine("Умножение:" + com);
        Console.WriteLine("Частное:" + div);
        Console.ReadKey();
    }
}
