using System;

namespace IMT
{
    class IMT
    {
        static void Main(string[] args)
        {
            // Снисаренко Екатерина

            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле 
            //I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Программа Индекс массы тела.");
            Console.WriteLine("Введите ваш вес (кг).");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост (м).");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);
            Console.WriteLine($"Индекс массы вашего тела = {I}.");
        }
    }
}
