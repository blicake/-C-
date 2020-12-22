using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Снисаренко Екатерина

            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.

            int a = 1;
            int b = 2;
            Console.WriteLine($"Переменная а = {a}, переменная b = {b}.");

            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Переменная а = {a}, переменная b = {b}.");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Переменная а = {a}, переменная b = {b}.");
        }
    }
}
