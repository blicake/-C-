using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Действия с комплексными числами.");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Сложение\n2. Вычитание\n3. Произведение\n4. Выход");
                string s = Console.ReadLine();
                int x;
                if(!(int.TryParse(s, out x)) || (x < 1) || (x > 4))
                {
                    Console.WriteLine("Неверное число, попробуйте еще раз.");
                    continue;
                }
                if (x == 4) break;
                else
                {
                    Complex z1 = new Complex();
                    Complex z2 = new Complex();
                    Console.WriteLine("Введите действительную часть первого числа");
                    z1.re = DoubleVal();
                    Console.WriteLine("Введите мнимую часть первого числа");
                    z1.im = DoubleVal();
                    Console.WriteLine("Введите действительную часть второго числа");
                    z2.re = DoubleVal();
                    Console.WriteLine("Введите мнимую часть второго числа");
                    z2.im = DoubleVal();
                    Complex z3 = new Complex();
                    string result = null;
                    switch (x)
                    {
                        case 1:
                            z3 = z1.Plus(z2);
                            result = z3.ToString();
                            break;
                        case 2:
                            z3 = z1.Minus(z2);
                            result = z3.ToString();
                            break;
                        case 3:
                            z3 = z1.Multiply(z2);
                            result = z3.ToString();
                            break;
                    }
                    Console.WriteLine($"Новое число: {result}");
                }
            }
        }

        private static double DoubleVal()
        {
            double val;
            while (true)
            {
                string s = Console.ReadLine();
                if (!(double.TryParse(s, out val)))
                {
                    Console.WriteLine("Неверное число, попробуйте еще раз.");
                    continue;
                }
                break;
            }
            return val;
        }
    }
}
