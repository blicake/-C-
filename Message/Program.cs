using System;

namespace Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение");
            string mes = Console.ReadLine();

            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            Message.LessThanN(N, mes);

            Console.WriteLine("Введите символ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Message.DeleteWord(c, mes));

            Console.WriteLine(Message.LongestWord(mes));

            Console.WriteLine(Message.BuildLongestWord(mes));
        }
    }
}
