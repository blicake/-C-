using System;

namespace Anketa
{
    class Anketa
    {
        static void Main(string[] args)
        {
            //Снисаренко Екатерина

            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            Console.WriteLine("Программа Анкета.");
            Console.WriteLine("1. Введите Ваше имя.");
            string Name = Console.ReadLine();
            Console.WriteLine("2. Введите Вашу фамилию.");
            string LastName = Console.ReadLine();
            Console.WriteLine("3. Введите Ваш возраст (полных лет).");
            string Age = Console.ReadLine();
            Console.WriteLine("4. Введите ваш вес (кг).");
            string Weight = Console.ReadLine();

            Console.WriteLine(Name + " " + LastName + ", " + Age + ", " + Weight + "кг.");
            Console.WriteLine("{0} {1}, {2}, {3}кг.", Name, LastName, Age, Weight);
            Console.WriteLine($"{Name} {LastName}, {Age}, {Weight}кг.");


        }
    }
}
