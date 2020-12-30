using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            string s;
            double result = 0;
            string Res = null;
            while (x != 0)
            {
                s = Console.ReadLine();
                if (!(double.TryParse(s, out x)))
                {
                    Console.WriteLine("Неверное число, попробуйте еще раз.");
                    continue;
                }
                if (x > 0 && x % 2 == 1)
                {
                    result += x;
                    Res += " " + x;
                }
            }
            Console.WriteLine($"Сумма нечетных положительных: {result}\nЧисла:{Res}");
        }
    }
}
